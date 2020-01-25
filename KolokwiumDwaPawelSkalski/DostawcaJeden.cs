using System;
using System.Collections.Generic;

namespace KolokwiumDwaPawelSkalski
{
    public class DostawcaJeden : IDostawca
    {
        List<Produkt> produkty = new List<Produkt>();

        public List<Produkt> Produkty
        {
            get => produkty;
            set => produkty = value;
        }
        public Produkt wyszukaj(string nazwa)
        {
            foreach (var VARIABLE in Produkty)
            {
                if (VARIABLE.Nazwa == nazwa)
                {
                    return VARIABLE;
                }
            }

            return new Produkt(-1, "brak");
        }

        public void zamow(Produkt produkt)
        {
            if (wyszukaj(produkt.Nazwa).Id == -1)
            {
                Console.WriteLine("Nie ma takiego produktu DostawcaJeden");
            }
            else
            {
                Console.WriteLine("Zamowione u Dostawcy1");
            }
        }
    }
}