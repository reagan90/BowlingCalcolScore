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
    public class Lancio : ILancio
    {
        public int _first { get; set; }
        public int _second { get; set; }

        public Lancio()
        {
            _first = 0;
            _second = 0;
        }

        public Lancio(int first, int second)
        {
            _first = first;
            _second = second;
        }

        public int FirstGet()
        {
            return _first;
        }

        public void FirstSet(int n)
        {
            _first = n;
        }

        public bool IsSpare()
        {
            return (_first + _second == 10);
        }

        public bool IsTrike()
        {
            return _first == 10;
        }

        public int SecondGet()
        {
            return this._second;
        }

        public void SecondSet(int n)
        {
            this._second = n;
        }
    }
}
