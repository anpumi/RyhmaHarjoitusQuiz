using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MiniProjekti
{
    class Program
    {
        static string nimi;
        
        static void Main(string[] args)
        {

            Console.Write("Anna nimesi: ");
            nimi = Console.ReadLine(); 
            Kysymysgeneraattori();
        }
                
        private static void Kysymysgeneraattori()
        {
            
            List<string[]> kysymykset = new List<string[]>();

            StreamReader sr = new StreamReader(@"C:\Users\erone\Documents\Academy tehtävät\Viikko 1\Viikko1 Miniprojekti\MiniProjekti\kysymykset.CSV", Encoding.GetEncoding("iso-8859-1"));

            string rivi = sr.ReadLine();
            while (rivi != null)
            {
                string[] kysymys = rivi.Split(';');
                kysymykset.Add(kysymys);
                rivi = sr.ReadLine();
            }
            sr.Close();


            List<string[]> randomIndex = new List<string[]>();

            Random rnd = new Random();

            while (randomIndex.Count != 10)
            {
                int luku = rnd.Next(0, kysymykset.Count);
                if (!randomIndex.Contains(kysymykset[luku]))
                {
                    randomIndex.Add(kysymykset[luku]);
                }
            }
 

            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(randomIndex[i][0]);
                alku1: Console.WriteLine("Totta vai tarua?");
                string vastaus = Console.ReadLine();
                vastaus = vastaus.ToLower();
                vastaus = vastaus.Trim();
                if (vastaus != "totta" && vastaus!="tarua")
                {
                    Console.WriteLine("Vastaususvaihtoehdot ovat \"totta\"" + " \"tarua\"");
                    goto alku1;
                    
                }

                if (vastaus == randomIndex[i][1])
                {
                    Console.WriteLine("Oikein!");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Väärin!");
                }
                Console.Clear();
            }

            string tulos = "";
            if (counter > 6)
                tulos = "Hyvin";
            else if (counter < 2)
                tulos = "Huonosti";
            else
                tulos = "Kohtalaisesti";

            Console.WriteLine($"{tulos} meni {nimi}, pisteesi {counter}/10");
        }
    }
}
