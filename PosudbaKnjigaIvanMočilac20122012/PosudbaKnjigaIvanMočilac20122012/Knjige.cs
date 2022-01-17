using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaKnjigaIvanMočilac20122012
{
    class Korisnici
    {
        int isbn;
        string naziv;
        string autor;

        public Korisnici(int isbn, string naziv, string autor)
        {
            this.isbn = isbn;
            this.naziv = naziv;
            this.autor = autor;
        }

        public int Isbn { get => isbn; set => isbn = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
