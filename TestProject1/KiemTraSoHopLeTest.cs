using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH61157_632006;

namespace PH61157_632026.Test
{
    [TestFixture]
    public class KiemTraSoHopLeTest
    {
        public KiemTraSoHopLe kiemTraSoHopLe = null;
        [SetUp]
        public void Setup()
        {
            kiemTraSoHopLe = new KiemTraSoHopLe();
        }
        [Test]
        public void TestSoNhoHon1()
        {
            Assert.That(kiemTraSoHopLe.KiemTraSo(0), Is.False);

        }
        [Test]
        public void TestSoNhoHon1001()
        {
            Assert.That(kiemTraSoHopLe.KiemTraSo(101), Is.False);
        }
        [Test]
        public void TestSoChiaHetCho5()
        {
            Assert.That(kiemTraSoHopLe.KiemTraSo(10), Is.False);
        }
        [Test]
        public void TestSoHopLe()
        {
            Assert.That(kiemTraSoHopLe.KiemTraSo(7), Is.True);
        }
        [Test]
        public void TestSoHopLe99()
        {
            Assert.That(kiemTraSoHopLe.KiemTraSo(99), Is.True);
        }

    }
}
