namespace KolokwiumDwaPawelSkalski
{
    public class Produkt
    {
        public int id;
        public string nazwa;

        public Produkt(int id, string nazwa)
        {
            this.id = id;
            this.nazwa = nazwa;
        }

        public int Id
        {
            get => id;
        }

        public string Nazwa
        {
            get => nazwa;
            set => nazwa = value;
        }
    }
}