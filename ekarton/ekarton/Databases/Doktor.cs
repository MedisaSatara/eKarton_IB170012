﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ekarton.Databases
{
    public partial class Doktor
    {
        public Doktor()
        {
            DodjeljeniDoktors = new HashSet<DodjeljeniDoktor>();
            OcjenaDoktoras = new HashSet<OcjenaDoktora>();
            Pregleds = new HashSet<Pregled>();
            Termins = new HashSet<Termin>();
        }

        public int DoktorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string DatumRodjenja { get; set; }
        public string Grad { get; set; }
        public string Jmbg { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int OdjelId { get; set; }

        public virtual Odjel Odjel { get; set; }
        public virtual ICollection<DodjeljeniDoktor> DodjeljeniDoktors { get; set; }
        public virtual ICollection<OcjenaDoktora> OcjenaDoktoras { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
