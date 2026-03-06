using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH61157_632006;

namespace PH61157_632026.Test
{
    public class SachServiceTest
    {
        private SachService sachService = new SachService();
        [SetUp]
        public void Setup()
        {
            sachService = new SachService();
        }
        [Test]
        public void TestSuaSachThanhCong()
        {
            var sachMoi = new Sach() { maSach = "S001", tenSach = "C#10", tacGia = "Nguyen Van A", namXuatBan = 2022, gia = 120000 };
            var result = sachService.SuaSach(sachMoi);
            Assert.That(result, Is.True);
            var after = sachService.GetSachByMaSach("S001");
            Assert.That(after.tenSach, Is.EqualTo("C#10"));
            Assert.That(after.namXuatBan, Is.EqualTo(2022));
            Assert.That(after.gia, Is.EqualTo(120000));

        }
        [Test]
        public void TestSuaSachThatBai()
        {
            var sachMoi = new Sach() { maSach = "S003", tenSach = "Java", tacGia = "Nguyen Van C", namXuatBan = 2021, gia = 130000 };
            var result = sachService.SuaSach(sachMoi);
            Assert.That(result, Is.False);
        }
        [Test]
        public void TestSuaSachThatBai_Null()
        {
            var sachMoi = new Sach() { maSach = "S001", tenSach = "C#10", tacGia = "", namXuatBan = 2022, gia = 120000 };
            var result = sachService.SuaSach(sachMoi);
            Assert.That(result, Is.False);
        }
        [Test]
        public void TestSuaSachNullThatBai()
        {
            var result = sachService.SuaSach(null);
            Assert.That(result, Is.False);
        }

        [Test]
        public void TestSuaSachMaSachNullThatBai()
        {
            var sachMoi = new Sach() { maSach = null, tenSach = "C#10", tacGia = "Nguyen Van A", namXuatBan = 2022, gia = 120000 };
            var result = sachService.SuaSach(sachMoi);
            Assert.That(result, Is.False);
        }
    }
}
