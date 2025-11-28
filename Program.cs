namespace ConsoleAppListaFeltoltesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<byte> csapadek = new List<byte>();
            Random random = new Random();
            for (int i = 0; csapadek.Count!=365; i++)
            {
                if (random.Next(1,18)==1 
                { 
                
                }

            File.WriteAllLines("C:\\adatok\\csapadek.txt", csapadek.Select(szam => szam + ""));


            csapadek = File.ReadAllLines("C:\\adatok\\csapadek.txt").Select(sor => Convert.ToByte(sor)).ToList();
        }
    }
}
