using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH61157_632006
{
    public class SachService
    {
        private List<Sach> ListSach = new List<Sach>()
        {
            new Sach() { maSach = "S001", tenSach = "C# ", tacGia = "Nguyen Van A", namXuatBan = 2020, gia = 100000 },
            new Sach() { maSach = "S002", tenSach = "ASP.NET Core", tacGia = "Nguyen Van B", namXuatBan = 2021, gia = 150000 },
        };

        public bool ThemSach(Sach sachMoi)
        {
            if (sachMoi == null) return false;

            if (string.IsNullOrWhiteSpace(sachMoi.maSach) ||
                string.IsNullOrWhiteSpace(sachMoi.tenSach) ||
                sachMoi.gia <= 0)
            {
                return false;
            }

            bool isDuplicate = ListSach.Any(s => s.maSach == sachMoi.maSach);

            if (isDuplicate)
            {
                return false;
            }

            ListSach.Add(sachMoi);
            return true;
        }
        public Sach GetSachByMaSach(string maSach)
        {
            return ListSach.FirstOrDefault(s => s.maSach == maSach);
        }
        public bool SuaSach(Sach sachMoi)
        {
            if (sachMoi == null) return false;

            if (string.IsNullOrEmpty(sachMoi.maSach)
                || string.IsNullOrEmpty(sachMoi.tenSach)
                || string.IsNullOrEmpty(sachMoi.tacGia)
                || sachMoi.namXuatBan <= 0
                || sachMoi.gia <= 0)
            {
                return false;
            }

            var sachCu = ListSach.FirstOrDefault(s => s.maSach == sachMoi.maSach);

            if (sachCu == null) return false;

            // 4. Cập nhật thông tin
            sachCu.tenSach = sachMoi.tenSach;
            sachCu.tacGia = sachMoi.tacGia;
            sachCu.namXuatBan = sachMoi.namXuatBan;
            sachCu.gia = sachMoi.gia;

            return true;
        }
        public Sach? GetSach(string maSach)
        {
            return ListSach.FirstOrDefault(s => s.maSach == maSach);
        }
    }
}
