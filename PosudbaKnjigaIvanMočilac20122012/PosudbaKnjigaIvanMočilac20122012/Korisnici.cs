﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaKnjigaIvanMočilac20122012
{
    class Knjige
    {
        int id;
        string ime;
        string prezime;

        public Knjige(int id, string ime, string prezime)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}