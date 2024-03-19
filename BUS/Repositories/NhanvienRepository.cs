using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class NhanvienRepository
    {
        //1. khai báo context từ DAL
        DBContext context;

        //2. ctor + tab
        public NhanvienRepository()
        {
            //3. khởi tạo context đã khai báo
            context = new DBContext();
        }
        //----------------------------------------------------
        // hàm select : select * from nhanvien
        public List<Nhanvien> GetAll()
        {
            return context.Nhanviens.ToList();
            //context: chui vào DB (NET102_Demo)
            //Nhanviens: truy cập bảng nhân viên, lấy ra toàn bộ dữ liệu
            //ToList: chuyển thành danh sách
        }

        // hàm insert : insert into nhanvien values
        public bool Add_Obj(Nhanvien nv)
        {
            if(nv == null)
            {
                return false;
            }
            context.Nhanviens.Add(nv);
            //context: chui vào DB (NET102_Demo)
            //Nhanviens: truy cập bảng nhân viên, lấy ra toàn bộ dữ liệu
            //Add | Update | Delete: thêm | sửa | xóa đối tượng
            return true;
        }
        public bool Update_Obj(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.Nhanviens.Update(nv);
            return true;
        }
        public bool Remove_Obj(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.Nhanviens.Remove(nv);
            return true;
        }
    }
}
