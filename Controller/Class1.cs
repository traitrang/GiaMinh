using System;
using System.Collections.Generic;
using System.Text;
using Model.Model;

namespace Controller
{
    public class Class1
    {
        private ThongTinDonVi ThongTinDonViModel = new ThongTinDonVi();
        public int ThemThongTinDonVi(ThongTinDonVi TTDonViModel)
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}
