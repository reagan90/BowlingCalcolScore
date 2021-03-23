using BowlingScoreClassLibrary;
using LancioClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ILancio[] lancio = new ILancio[11];

            for (int i = 0; i < lancio.Length; i++)
                lancio[i] = new Lancio();

            lancio[0].FirstSet(1);
            lancio[0].SecondSet(2);

            lancio[1].FirstSet(10);
            lancio[1].SecondSet(0);

            lancio[2].FirstSet(0);
            lancio[2].SecondSet(10);

            lancio[3].FirstSet(4);
            lancio[3].SecondSet(2);

            lancio[4].FirstSet(0);
            lancio[4].SecondSet(10);

            lancio[5].FirstSet(6);
            lancio[5].SecondSet(2);

            lancio[6].FirstSet(0);
            lancio[6].SecondSet(10);

            lancio[7].FirstSet(6);
            lancio[7].SecondSet(4);

            lancio[8].FirstSet(8);
            lancio[8].SecondSet(2);

            lancio[9].FirstSet(2);
            lancio[9].SecondSet(8);

            lancio[10].FirstSet(8);


            foreach (var b in lancio)
            {
                Console.Write(b.FirstGet() + "/" + b.SecondGet() + " ");
            }

            Console.WriteLine();

            IBowling bowling = new Bowling(lancio);

            Console.WriteLine(bowling.Score());

            Console.ReadLine();
        }
    }
}
