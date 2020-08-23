using EUFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EUFA
{
    public static class Extensions
    {
        public static void TrySave(this EUFAEntities a)
        {
            try
            {
                a.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
