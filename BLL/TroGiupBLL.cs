using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TroGiupBLL
    {
        private TroGiupDAL troGiupDAL = new TroGiupDAL();

        public DataTable LayDanhSachTroGiup()
        {
            return troGiupDAL.LayDanhSachTroGiup();
        }
    }
}
