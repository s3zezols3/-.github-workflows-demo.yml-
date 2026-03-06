using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH61157_632006
{
    internal class QLSach
    {
        private List<Sach> _danhSach = new List<Sach>();

        public void AddBook(Sach sachMoi)
        {
            bool exists = _danhSach.Any(s => s.maSach == sachMoi.maSach);

            if (exists)
            {
                throw new Exception("Mã sách này đã được sử dụng.");
            }
            else
            {
                _danhSach.Add(sachMoi);
            }
        }
    }
}
