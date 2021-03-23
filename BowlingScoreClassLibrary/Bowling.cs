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
            _bow = new ILancio[11];

            for (int i = 0; i < _bow.Length; i++)
            {
                _bow[i] = new Lancio();
            }
        }


        public void ControlValore()
        {
            foreach (var b in _bow)
                if (b.FirstGet() < 0 || b.SecondGet() < 0)
                    throw new ArgumentException();
            
        }

        public int Score()
        {
            int somma = 0;
            int lastPosizione = 9;

            ControlValore();

            for (var i = 0; i < _bow.Length; i++)
            {
                if (_bow[i].IsTrike())
                {
                    if (i == lastPosizione)
                    {
                        somma += _bow[i].FirstGet() + _bow[i + 1].FirstGet() + _bow[i + 1].SecondGet();
                        return somma;
                    }
                    else
                        somma += _bow[i].FirstGet() + _bow[i + 1].FirstGet() + _bow[i + 1].SecondGet();
                }
                   

                else if (_bow[i].IsSpare())
                {
                    if (i == lastPosizione)
                    {
                        somma += _bow[i].FirstGet() + _bow[i].SecondGet() + _bow[i + 1].FirstGet();
                        return somma;
                    }

                    else
                        somma += _bow[i].FirstGet() + _bow[i].SecondGet() + _bow[i + 1].FirstGet();
                }
                    

                else
                    somma += _bow[i].FirstGet() + _bow[i].SecondGet();
            }


            return somma;
        }
    }
}
