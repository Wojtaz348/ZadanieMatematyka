internal class Program
{
    private static int b;
    private static int c;

    private static void Main(string[] args)
    {
        Random rand = new Random();
        int[] tablica123 = new int[25];
        int[,] macierz1 = new int[25, 25];
        for (int i = 0; i < tablica123.Length; i++)
        {
            tablica123[i] = rand.Next(-99, 99);
        }
        for (int i = 0; i < 25; i++)
        {
            for (int j = 0; j < 25; j++)
            {
                macierz1[i, j] = rand.Next(-80, 100);
            }
        }
        int ip = 0, ik = 0;
        int ns = tablica123[0];
        int bs = 0;
        int ip2 = 0, ik2 = 0;
        int ms2 = macierz1[0, 0];
        for (int i = 0; i < tablica123.Length; i++)
        {
            bs = 0;
            for (int j = i; j < tablica123.Length; j++)
            {
                bs += tablica123[j];
                if (bs > ns)
                {
                    ns = bs;
                    ip = i;
                    ik = j;
                }
            }
        }
        for (int i = 0; i < 20; i++)
        {
            for (int w = i; w < 20; w++)
            {
                bs = 0;
                for (int k = 0; k < 20; k++)
                {
                    int suma = 0;
                    for (int l = i; l <= w; l++)
                    {
                        suma += macierz1[b, c];
                    }
                    bs += suma;
                    if (bs > ns)
                    {
                        ik = w;
                        ip = i;
                        ns = bs;
                    }
                    if (bs < 0)
                    {
                        bs = 0;
                    }
                }
            }
        }
        Console.WriteLine("Indeks końca podciągu: " + ik);
        Console.WriteLine("Indeks początku podciągu: " + ip);
        Console.WriteLine("Największa suma liczb: " + ns);
        Console.WriteLine("Wylosowana tablica: ");
        for (int i = 0; i < tablica123.Length; i++)
        {
            Console.Write(tablica123[i] + " ");
        }
        Console.WriteLine("Pozycja początku podciągu (wiersz, kolumna): (" + ip + ", 0)");
        Console.WriteLine("Największa suma podciągu w macierzy: " + ns);
        Console.WriteLine("Pozycja końca podciągu (wiersz, kolumna): (" + ik + ", 18)");
        Console.WriteLine("Wylosowana Macierz: ");
        for (int i = 0; i < 25; i++)
        {
            for (int j = 0; j < 25; j++)
            {
                Console.Write(macierz1[i, j] + "\n");
            }
            Console.WriteLine();
        }
    }
}



