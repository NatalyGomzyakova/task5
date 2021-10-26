using System;

namespace кнвннн
{
    class Program
    {


        static void Main(string[] args)
        {
        link:
            Console.WriteLine("Hello World!");
            string koordinate = Console.ReadLine();
            string abcd = "0abcdefgh";
            //int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string snum = "012345678";

            int kabc = 0;
            int knum = 0;


            if (koordinate.Length != 2)
            {
                Console.WriteLine("2 символа");


                goto link;
            }


            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < abcd.Length; j++)
                {

                    if (koordinate[k] == abcd[j])
                    {
                        kabc = abcd.IndexOf(koordinate[k]);
                        Console.Error.WriteLine("abcdefgh");
                    }

                    else if (koordinate[k] == snum[j])
                    {
                        knum = snum.IndexOf(koordinate[k]);
                        Console.Error.WriteLine("12345678");

                    }

                }

            }

            if ((knum == 0) || (kabc == 0))
            {
                Console.WriteLine("За пределом ");
                goto link;

            }
            Console.WriteLine($"knum{knum}, kabc{kabc}");



            //решение задачи
            int s = 0;
            int d = 0;
            int[] dx = { 0, -2, -2, 2, 2, 1, -1, 1, -1 };
            int[] dy = { 0, -1, 1, -1, 1, 2, -2, -2, 2 };

            for (int i = 1; i < dx.Length; i++)
            {
                s = knum + dx[i];
                d = kabc + dy[i];
                if (((s < snum.Length) && (s > 0)) && ((d < abcd.Length) && (d > 0)))
                {
                    Console.WriteLine($"{abcd[d]} {snum[s]}");

                }

            }
            Console.WriteLine($"Конец - Я молодец");
        }
    }
}

