using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_listy3p2
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }    
        public bool Dostepny { get; set; }
        public string Kategoria { get; set; }

        public Produkt(string nazwa, double cena, bool dostepny, string kategoria)
        {
            Nazwa = nazwa;
            Cena = cena;
            Dostepny = dostepny;
            Kategoria = kategoria;
        }
    }
}
