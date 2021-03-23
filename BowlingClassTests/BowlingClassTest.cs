using BowlingScoreClassLibrary;
using LancioClassLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingClassTests
{
    [TestFixture]
    public class BowlingClassTest
    {
        private ILancio[] lancio;

        [SetUp]
        public void Init()
        {
            lancio = new ILancio[12];
            for (int i = 0; i < lancio.Length; i++)
                lancio[i] = new Lancio();
        }

        
        [TearDown]
        public void CleanUp()
        {
            lancio = null;
        }


        [Test]
        public void SumTest()
        {

            lancio[0].FirstSet(3);
            lancio[0].SecondSet(4);

            lancio[1].FirstSet(4);
            lancio[1].SecondSet(6);

            lancio[2].FirstSet(4);
            lancio[2].SecondSet(3);

            lancio[3].FirstSet(5);
            lancio[3].SecondSet(4);

            lancio[4].FirstSet(1);
            lancio[4].SecondSet(0);

            lancio[5].FirstSet(0);
            lancio[5].SecondSet(7);

            lancio[6].FirstSet(10);

            lancio[7].FirstSet(4);
            lancio[7].SecondSet(5);

            lancio[8].FirstSet(6);
            lancio[8].SecondSet(3);

            lancio[9].FirstSet(3);
            lancio[9].SecondSet(3);

            IBowling bowling = new Bowling(lancio);

            Assert.That(() => bowling.Score(), Is.EqualTo(88));
        }

        [Test]
        public void SpareTest()
        {

            lancio[0].FirstSet(3);
            lancio[0].SecondSet(4);

            lancio[1].FirstSet(6);
            lancio[1].SecondSet(4);

            lancio[2].FirstSet(4);
            lancio[2].SecondSet(5);

            IBowling bowling = new Bowling(lancio);

            Assert.That(() => bowling.Score(), Is.EqualTo(30));
        }

        [Test]
        public void StrikeTest() {

            lancio[0].FirstSet(3);
            lancio[0].SecondSet(4);

            lancio[1].FirstSet(10);

            lancio[2].FirstSet(4);
            lancio[2].SecondSet(5);

            IBowling bowling = new Bowling(lancio);

            Assert.That(() => bowling.Score(), Is.EqualTo(35));
        }

       

        [Test]
        public void ArgumentException()
        {

            IBowling bowling = new Bowling(lancio);

            lancio[0].FirstSet(3);
            lancio[0].SecondSet(-8);

            Assert.That(() => bowling.Score(), Throws.TypeOf<ArgumentException>());
        }

    }
}
