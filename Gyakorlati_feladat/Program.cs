namespace Gyakorlati_feladat
{
    internal class Program
    {
        static string[] huto_elemek = new string[10];


        static string[] zoldsegek = new string[5]

        { "Brokkoli","Cukkini","Répa","Retek","Padlizsán"};
        
        
        static Random r = new Random();
        static void hutoszekreny()
        {
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = "";
            }
            for (int i = 0; i < r.Next(1,10); i++)
            {
                huto_elemek[i] = "";
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
                Console.WriteLine($"Élelmiszerek darabszáma: {count}");
            }
            Takarit();
            
        }
        static void Main(string[] args)
        {
            hutoszekreny();

            
        }
    }
}
