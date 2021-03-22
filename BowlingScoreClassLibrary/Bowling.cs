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
        public int Score()
        {
            throw new NotImplementedException();
        }
    }
}
