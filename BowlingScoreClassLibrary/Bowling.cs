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
        public int Score()
        {
            throw new NotImplementedException();
        }
    }
}
