namespace KolokwiumDwaPawelSkalski
{
    public interface IDostawca
    {
        Produkt wyszukaj(string nazwa);
        void zamow(Produkt produkt);
    }
    
}