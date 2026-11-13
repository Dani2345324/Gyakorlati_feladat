using System.ComponentModel.DataAnnotations;

namespace Gyakorlati_feladat
{
    internal class Program
    {
        
        static string[] huto_elemek = new string[10];

        static string[] seged = new string[10];

        static string[] zoldsegek =

        { "brokkoli","cukkini","répa","retek","padlizsán","uborka"};


        static Random r = new Random();
        static void hutoszekreny()
        {

            Console.WriteLine("Véletlen tömbfeltöltés: ");
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = "";
            }
            for (int i = 0; i < r.Next(1, 10); i++)
            {
                int random = r.Next(0, 9);
                if (huto_elemek[random] == "")
                {
                    huto_elemek[random] = zoldsegek[r.Next(0, 6)];

                }

            }
            foreach (var item in huto_elemek)
            {
                Console.WriteLine(item);
            }
            

        }

        static void Takarit()
        {
            Console.WriteLine("Takarítás: ");
            int count = 0;
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] != "")
                {
                    count++;
                }
            }
            count = 0;
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] != "")
                {
                    seged[count] = huto_elemek[i];
                    count++;
                }
            }
            for (int i = 0; i < seged.Length; i++)
            {
                if (seged[i] == null)
                {
                    seged[i] = "";
                }
            }
            for (int i = 0; i < huto_elemek.Length; i++)
            {

                huto_elemek[i] = seged[i];
                Console.WriteLine(huto_elemek[i]);


            }


            Console.WriteLine($"Élelmiszerek darabszáma: {count}");
        }
        static void Keresetel()

        {
            int keresettindex = 0;
            Console.Write("Kérem adja meg a keresett étel nevét: ");
            string etelNeve = Console.ReadLine();
            for (int i = 0; i < huto_elemek.Length; i++)
            {

                if (huto_elemek[i] == etelNeve)
                {

                    keresettindex = i + 1;
                }

            }
            Console.WriteLine($"A keresett étel a {keresettindex}.");
        }
        static void maganhangzosak()
        {
            Console.WriteLine();
            Console.Write("Magánhangzóval kezdődő ételek: ");
            string maganhangzok = "aáeéiíoóöőuúüű";

            for (int i = 0; i < seged.Length; i++)
            {

                if (huto_elemek[i] != "")
                {
                    if (maganhangzok.Contains(seged[i][0]))
                    {
                        Console.Write($"{seged[i]} ,");
                    }

                }



            }
        }





        static int[] szamok = new int[10];

        static int[] szamok_leghosszabb_novekvo = new int[10];

        static int[] szamok_novekvo = new int[10];
        static void FeltoltEgyediekkel(int min = -50, int max = 100)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Számos feladat:");
            for (int count = 0; count < szamok.Length;)
            {
                int random = r.Next(min, max + 1);
                if (szamok.Contains(random))
                {
                    
                }
                else
                {
                    szamok[count] = random;
                    count++;
                }
            }
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void LeghosszabbNovekvo()
        {
            
            int count = 0;
            
            for (int j = 0; j < szamok.Length; j++)
            {
                count = 0;
                for (int i = 0; i < szamok.Length; i++)
                {
                   if (szamok[j] > szamok[i]){
                        count++;
                   } 
                }
                
                szamok_novekvo[count] = szamok[j];
                

                

            }
            foreach (var item in szamok_novekvo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            
                



        }
        static void AtlagAlattiDuplazas()
        {
            Console.WriteLine();
            Console.WriteLine("Átlag alatti számok duplázása");
            double atlag = 0;
            int sum = 0;
            foreach (var item in szamok)
            {
                sum += item;
            }
            atlag = sum / szamok.Length;
            Console.WriteLine(atlag);
            Console.WriteLine();
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] = szamok[i]*2;
                }
                
            }
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            hutoszekreny();
            Takarit();
            Keresetel();
            maganhangzosak();
            FeltoltEgyediekkel();
            LeghosszabbNovekvo();
            AtlagAlattiDuplazas();



        }
    }
}
