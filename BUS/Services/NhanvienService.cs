using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanvienService
    {
        NhanvienRepository repos;
        public NhanvienService()
        {
            repos = new NhanvienRepository();
        }
        //-------------------------------------
        // lấy danh sách từ repos
        public List<Nhanvien> GetNhanviens()
        {
            return repos.GetAll();   
        }
    }
}
