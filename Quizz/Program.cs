using Kysymykset;
using MiniProjekti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Program
    {
        static void Main(string[] args)
        {
            // valitaan mitä peliä pelataan
            Console.WriteLine("Tervetuloa pelivalikkoon. Kirjoita 1, 2 tai 3");

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1": //luokan nimi pelille
                    Peli1.PelaajanNimiMetodi();
                    Peli1.AllQuestions();
                    Peli1.EndGame();

                    break;

                case "2": //luokan nimi pelille
                    Console.Write("Anna nimesi: ");
                    Peli2.nimi = Console.ReadLine();
                    Peli2.Kysymysgeneraattori();

                    break;

                case "3": //luokan nimi pelille
                    Peli3.TekeeJuttuja();
                    break;

                default:
                    break;
            }

        }
    }
}
