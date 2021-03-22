using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancioClassLibrary
{
    public interface ILancio
    {
        bool IsSpare();
        bool IsTrike();
        int FirstGet();
        int SecondGet();
        void FirstSet(int n);
        void SecondSet(int n);
    }
    public class Lancio
    {
    }
}
