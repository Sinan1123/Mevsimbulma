namespace Mevsimbulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Hangi ayın mevsim bilgisini almak istiyorsanız o ayın sayısını giriniz. 1 ile 12 arasında bir sayı. (çıkmak için 0)");

                int ayNumber = Convert.ToInt32(Console.ReadLine());
                string mevsim = "";

                if (ayNumber == 0) 
                {
                    break; 
                }

                if (ayNumber == 12 || ayNumber == 1 || ayNumber == 2)
                {
                    mevsim = "Kış";
                }
                else if (ayNumber >= 3 && ayNumber <= 5)
                {
                    mevsim = "İlkbahar";
                }
                else if (ayNumber >= 6 && ayNumber <= 8)
                {
                    mevsim = "Yaz";
                }
                else if (ayNumber >= 9 && ayNumber <= 11)
                {
                    mevsim = "Sonbahar";
                }

                if (ayNumber < 0 || ayNumber >= 13)
                {
                    Console.WriteLine("1 ile 12 arasında bir sayı girin");
                }
                else
                {
                    Console.WriteLine(ayNumber + " -> " + mevsim);
                }
            }
        }
    }
}
