using ekarton.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ekarton.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisnikService _korisnikService;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,ILoggerFactory logger,UrlEncoder encoder,ISystemClock clock,IKorisnikService korisnikService)
            : base(options, logger, encoder, clock)
        {
            _korisnikService = korisnikService;
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if(!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing authorization header");
            }
            Model.Models.Korisnik user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = await _korisnikService.Login(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }
            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                new Claim(ClaimTypes.Name, user.Ime),
            };
            foreach (var role in user.KorisnikUlogas)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }


    }
}
