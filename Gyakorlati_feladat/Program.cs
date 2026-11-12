namespace Gyakorlati_feladat
{
    internal class Program
    {
        static string[] huto_elemek = new string[10];

        static string[] seged = new string[10];

        static string[] zoldsegek = new string[]

        { "brokkoli","cukkini","répa","retek","padlizsán","uborka"};
        
        
        static Random r = new Random();
        static void hutoszekreny()
        {

            
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = "";
            }
            for (int i = 0; i < r.Next(1,10); i++)
            {
                int random = r.Next(0, 9);
                if (huto_elemek[random] == "")
                {
                    huto_elemek[random] = zoldsegek[r.Next(0,6)];

                }
                
            }

            

            static void Takarit()
            {   
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
                        
                        keresettindex = i+1;
                    }
                    
                }
                Console.WriteLine($"A keresett étel a {keresettindex}.");
            }
            static void maganhangzosak()
            {
                string maganhangzok = "aáeéiíoóöőuúüű";
                string segedstring;
                for (int i = 0; i < huto_elemek.Length; i++)
                {
                    
                    if (huto_elemek[i] != "")
                    {
                        segedstring = huto_elemek[i];
                    
                        for (int j = 0; j < maganhangzok.Length; j++)
                        {
                        
                           if (segedstring[0] == maganhangzok[j])
                           {
                                Console.Write($"{huto_elemek[i]} ,");
                           }
                        }
                    }
                    
                    
                    
                }
            }

            Takarit();
            Keresetel();
            maganhangzosak();
            
        }

        static int[] szamok = new int[10];
        static void szamos_feladat()
        {
            static void FeltoltEgyediekkel()
            {

            }
        }
        static void Main(string[] args)
        {
            hutoszekreny();
            szamos_feladat();

            
        }
    }
}
