public class DusenMeyveler
{
    static void Main()
    {
        Console.WriteLine("Başlangıç, bitiş, elma koordinatı, portakal koordinatı, elma sayısı, portakal sayısı, elma düşüş uzaklıkları, portakal düşüş uzaklıkları:");
        string input = Console.ReadLine();

       
        string[] data = input.Split(' ');
        int s = int.Parse(data[0]);
        int t = int.Parse(data[1]);
        int a = int.Parse(data[2]);
        int b = int.Parse(data[3]);
        int m = int.Parse(data[4]);
        int n = int.Parse(data[5]);

        int[] elmaDususUzakliklari = new int[m];
        int[] portakalDususUzakliklari = new int[n];

        
        for (int i = 0; i < m; i++)
        {
            elmaDususUzakliklari[i] = int.Parse(data[6 + i]);
        }

        
        for (int i = 0; i < n; i++)
        {
            portakalDususUzakliklari[i] = int.Parse(data[6 + m + i]);
        }

        
        Tuple<int, int> sonuclar = MeyveSayilari(s, t, a, b, elmaDususUzakliklari, portakalDususUzakliklari);

       
        Console.WriteLine($"Düşen elma sayısı: {sonuclar.Item1}, Düşen portakal sayısı: {sonuclar.Item2}");
    }

    static Tuple<int, int> MeyveSayilari(int s, int t, int a, int b, int[] elmaDususUzakliklari, int[] portakalDususUzakliklari)
    {
        int elmaSayisi = 0;
        int portakalSayisi = 0;

        foreach (var elma in elmaDususUzakliklari)
        {
            int pozisyon = a + elma;
            if (s <= pozisyon && pozisyon <= t)
            {
                elmaSayisi++;
            }
        }

        foreach (var portakal in portakalDususUzakliklari)
        {
            int pozisyon = b + portakal;
            if (s <= pozisyon && pozisyon <= t)
            {
                portakalSayisi++;
            }
        }

        return Tuple.Create(elmaSayisi, portakalSayisi);
    }
}
