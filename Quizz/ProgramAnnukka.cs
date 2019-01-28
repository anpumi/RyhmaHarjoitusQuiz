using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Peli1
    {
        public static int Pisteet;
        public static string PelaajanNimi;
        public static int MaxPisteet;
        public static int KysymyksenNumero;
        public static int randomKyssäri;

        //static void Main(string[] args)
        //{
        //    PelaajanNimiMetodi();
        //    AllQuestions();
        //    EndGame();
        //}

        public static void AllQuestions()
        {
            string vastaus = "";

            List<int> numbersOnList = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    randomKyssäri = rnd.Next(1, 16);
                    if (numbersOnList.Contains<int>(randomKyssäri))
                    {
                        j--;
                    }

                    else
                    {
                        numbersOnList.Add(randomKyssäri);
                        //Console.WriteLine("Random kyssärin numero: " + randomKyssäri);
                    }
                }

                // KYSYMYS 1
                if (randomKyssäri == 1)
                {
                    KysymyksenNumero++;
                    Question kysymys1 = new Question("absoluuttinen: häilyvä?", "väärin");
                    kysymys1.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys1.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 2
                if (randomKyssäri == 2)
                {
                    KysymyksenNumero++;
                    Question kysymys2 = new Question("absurdi: järjetön?", "oikein");
                    kysymys2.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys2.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 3
                if (randomKyssäri == 3)
                {
                    KysymyksenNumero++;
                    Question kysymys3 = new Question("addiktio: helppohoituisuus?", "väärin");
                    kysymys3.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys3.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 4
                if (randomKyssäri == 4)
                {
                    KysymyksenNumero++;
                    Question kysymys4 = new Question("aforismi: ajatelma?", "oikein");
                    kysymys4.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys4.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 5 
                if (randomKyssäri == 5)
                {
                    KysymyksenNumero++;
                    Question kysymys5 = new Question("aggressiivinen: lempeä?", "väärin");
                    kysymys5.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys5.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 6
                if (randomKyssäri == 6)
                {
                    KysymyksenNumero++;
                    Question kysymys6 = new Question("agraari: maatalouteen liittyvä?", "oikein");
                    kysymys6.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys6.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 7    
                if (randomKyssäri == 7)
                {
                    KysymyksenNumero++;
                    Question kysymys7 = new Question("aksentti: tanssi?", "väärin");
                    kysymys7.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys7.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 8    
                if (randomKyssäri == 8)
                {
                    KysymyksenNumero++;
                    Question kysymys8 = new Question("bakkanaalit: juomingit?", "oikein");
                    kysymys8.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys8.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 9    
                if (randomKyssäri == 9)
                {
                    KysymyksenNumero++;
                    Question kysymys9 = new Question("fakkiutua: rajoittua?", "oikein");
                    kysymys9.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys9.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 10    
                if (randomKyssäri == 10)
                {
                    KysymyksenNumero++;
                    Question kysymys10 = new Question("filatelia: kuviokellunta?", "väärin");
                    kysymys10.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys10.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 11 
                if (randomKyssäri == 11)
                {
                    KysymyksenNumero++;
                    Question kysymys11 = new Question("egoisti: taiteellinen?", "väärin");
                    kysymys11.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys11.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 12    
                if (randomKyssäri == 12)
                {
                    KysymyksenNumero++;
                    Question kysymys12 = new Question("lapsus: virhe?", "oikein");
                    kysymys12.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys12.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 13    
                if (randomKyssäri == 13)
                {
                    KysymyksenNumero++;
                    Question kysymys13 = new Question("aksiooma: itsestäänselvyys?", "oikein");
                    kysymys13.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys13.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 14    
                if (randomKyssäri == 14)
                {
                    KysymyksenNumero++;
                    Question kysymys14 = new Question("latentti: selkeä?", "väärin");
                    kysymys14.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys14.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }

                // KYSYMYS 15    
                if (randomKyssäri == 15)
                {
                    KysymyksenNumero++;
                    Question kysymys15 = new Question("degeneroitua: rappeutua?", "oikein");
                    kysymys15.PrintQuestion();
                    vastaus = Console.ReadLine();
                    MaxPisteet++;

                    if (vastaus == kysymys15.KysymyksenOikeaVastaus)
                    {
                        Pisteet++;
                        Console.WriteLine("Jee!!");
                    }

                    else
                    {
                        Console.WriteLine("Väärin!");
                    }
                    Console.WriteLine();
                }
                Console.Clear();
            }
        }

        public static void PelaajanNimiMetodi()
        {
            Console.WriteLine("Syötä pelaajan nimi: ");
            PelaajanNimi = Console.ReadLine();
            Console.Clear();
        }

        public static void EndGame()
        {
            if (Pisteet > 8)
            {
                Console.WriteLine($"Hyvin meni {PelaajanNimi}!, pisteesi: {Pisteet}/{MaxPisteet}");
            }

            else if (Pisteet < 8 && Pisteet >= 5)
            {
                Console.WriteLine($"Ihan ookoosti meni {PelaajanNimi}, pisteesi: {Pisteet}/{MaxPisteet}");
            }

            else
            {
                Console.WriteLine($"Koitappa skarpata {PelaajanNimi}, pisteesi: {Pisteet}/{MaxPisteet}");
            }
        }
    }
}
