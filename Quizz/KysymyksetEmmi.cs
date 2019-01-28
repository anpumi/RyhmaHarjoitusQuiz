using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text;

namespace Kysymykset
{
    class Kysymykset
    {
        public int kierrokset = 1;
        List<Kysymykset> luetutKysymykset;
        Pelaaja p = new Pelaaja();
        public string Kysymys { get; set; }
        public string Kyllä { get; set; }

        public string Ei { get; set; }
        public string Vastaus { get; set; }

        public Kysymykset()
        {
        }

        public Kysymykset(string kysymys, string kyllä, string ei, string vastaus)
        {
            Kysymys = kysymys;
            Kyllä = kyllä;
            Ei = ei;
            Vastaus = vastaus;

        }

        public void lueKysymykset()
        {
            StreamReader lukija = new StreamReader(@"C:\Users\Annukka\source\repos\Week4\Quizz\Quizz\kysymyksetEmmi.txt", Encoding.GetEncoding("iso-8859-1"));

            string rivi = lukija.ReadLine();
            luetutKysymykset = new List<Kysymykset>();
            while (rivi != null)
            {
                string[] vaihtoehdot = rivi.Split('|');
                Kysymykset k = new Kysymykset();
                k.Kysymys = vaihtoehdot[0];
                k.Kyllä = vaihtoehdot[1];
                k.Ei = vaihtoehdot[2];
                k.Vastaus = vaihtoehdot[3];

                luetutKysymykset.Add(k);
                rivi = lukija.ReadLine();
            }

            lukija.Close();
        }
        public int kysyKysymys()
        {
            int kierrokset = 0;

            int piste = 0;

            for (int i = 0; i < 10; i++)
            {

            Console.Clear();
            Console.WriteLine("Hei!");
            Console.WriteLine($"{luetutKysymykset[i].Kysymys}");
            Console.WriteLine($"1. {luetutKysymykset[i].Kyllä}");
            Console.WriteLine($"2. {luetutKysymykset[i].Ei}");
            Console.WriteLine("Mikä on vastaus?");
            string check = Console.ReadLine();

                if (check == "1")
                {
                    check = luetutKysymykset[i].Kyllä;
                }
                if (check == "2")
                {
                    check = luetutKysymykset[i].Ei;
                }

            if (check == luetutKysymykset[i].Vastaus)
            {
                Console.WriteLine("Oikein!");
                    //p.Pistelisäys();
                    piste++;
                        kierrokset++;
                
            }
            else
                Console.WriteLine("Väärin!");
                kierrokset++;
       
            }
            return piste;
        }
        


     

    }
}
