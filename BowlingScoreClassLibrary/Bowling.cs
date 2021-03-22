using LancioClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreClassLibrary
{
    public interface IBowling
    {
        int Score();

    }

    public class Bowling : IBowling
    {
        private ILancio[] _bow;

        public Bowling(ILancio[] bow)
        {

            _bow = bow;

        }

        public Bowling()
        {
            _bow = new ILancio[12];

            for (int i = 0; i < _bow.Length; i++)
            {
                _bow[i] = new Lancio();
            }
        }
        public int Score()
        {
            int somma = 0;

            for (var i = 0; i < _bow.Length; i++)
            {
                if (_bow[i].IsTrike())
                    somma += _bow[i].FirstGet() + _bow[i + 1].FirstGet() + _bow[i + 1].SecondGet();

                else if (_bow[i].IsSpare())
                    somma += _bow[i].FirstGet() + _bow[i].SecondGet() + _bow[i + 1].FirstGet();

                else
                    somma += _bow[i].FirstGet() + _bow[i].SecondGet();
            }


            return somma;
        }
    }
}
