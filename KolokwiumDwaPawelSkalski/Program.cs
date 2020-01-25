using System;
using System.Collections.Generic;

namespace KolokwiumDwaPawelSkalski
{
    
    class Program
    {
        static void zamowienie(string nazwa,DostawcaJeden dostawcaJeden, DostawcaDwa dostawcaDwa)
        {
            
            if (dostawcaJeden.wyszukaj(nazwa).id != -1)
            {
                Produkt produkt = dostawcaJeden.wyszukaj(nazwa);
                dostawcaJeden.zamow(produkt);
            }
            
            if (dostawcaDwa.wyszukaj(nazwa).id != -1)
            {
                Produkt produkt = dostawcaDwa.wyszukaj(nazwa);
                dostawcaDwa.zamow(produkt);
            }
            else
            {
                Console.WriteLine("Żaden z dostawców nie oferuje tego produktu");    
            }


        }
        static void Main(string[] args)
        {
            Telefon Nokia3310 = new Telefon();
            Smartfon XPhone = new Smartfon();
            Console.WriteLine(Nokia3310.Dzwon(2221010));
            Console.WriteLine(XPhone.Dzwon(123456789));
            Console.WriteLine(XPhone.LadujStroneWWW("google.com"));
            DostawcaDwa dostawcaDwa = new DostawcaDwa();
            dostawcaDwa.Produkty.Add(new Produkt(1,"jablko"));
            dostawcaDwa.Produkty.Add(new Produkt(2,"pomarancza"));
            dostawcaDwa.Produkty.Add(new Produkt(3,"arbuz"));
            dostawcaDwa.Produkty.Add(new Produkt(4,"gruszka"));
            dostawcaDwa.Produkty.Add(new Produkt(5,"pomidor"));
            
            DostawcaJeden dostawcaJeden = new DostawcaJeden();
            dostawcaJeden.Produkty.Add(new Produkt(1,"ziemniak"));
            dostawcaJeden.Produkty.Add(new Produkt(2,"kapusta"));
            dostawcaJeden.Produkty.Add(new Produkt(3,"salata"));
            dostawcaJeden.Produkty.Add(new Produkt(4,"marchew"));
            dostawcaJeden.Produkty.Add(new Produkt(5,"burak"));

            zamowienie("jablko", dostawcaJeden, dostawcaDwa);

        }
    }
}