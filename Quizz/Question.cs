using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Question
    {
        //public int KysymyksenNumero = 0;
        public string KysymyksenKysymys;
        public string KysymyksenOikeaVastaus;

        public Question()
        {
            //KysymyksenNumero++;
        }

        public Question(string _kysymyksenKysymys, string _kysymyksenOikeaVastaus)
        {
            KysymyksenKysymys = _kysymyksenKysymys;
            KysymyksenOikeaVastaus = _kysymyksenOikeaVastaus;
            //KysymyksenNumero++;
        }

        public void PrintQuestion()
        {
            Console.Write($"Kysymys: {Peli1.KysymyksenNumero}. ");
            Console.Write($"{KysymyksenKysymys} - (oikein/väärin) ");
        }
    }
}
