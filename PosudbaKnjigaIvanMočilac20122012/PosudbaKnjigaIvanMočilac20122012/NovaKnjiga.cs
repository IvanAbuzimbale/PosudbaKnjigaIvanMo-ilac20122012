using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class NovaKnjiga : Form
    {
        public NovaKnjiga()
        {
            InitializeComponent();
        }

        private void btnUnesiKnjigu_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument(
                new XElement("Knjige",
                    new XElement("ISBN", txtISBN.Text),
                    new XElement("Naziv", txtNaziv.Text),
                    new XElement("Autor", txtAutor.Text)
                )
            );
            doc.Save("Knjige.xml");
        }
    }
}
