using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSaver
{
    class Bloodpackoperations
    {

        public static void SearchbyBloodtype(ref DataGridView dg,blood_types bloodtype) {
            string q = "select BloodBank.bb_name,BloodBank.bb_email,BloodBank.bb_mobile,BloodBank.bb_address,BloodBank.bb_type from BloodBank INNER JOIN BloodPacks ON bb_id=bpack_bank and bpack_bloodtype='" + bloodtype.ToString()+"'";
            dg = DatabaseHandler.gettabletoGridView(q);
        }

        public static void SearchbyBloodbank(ref DataGridView dg, string bloodbank)
        {
            string q = "select bb_name,bb_email,bb_mobile,bb_address,bb_type from BloodBank where bb_name='"+bloodbank+"'";
            dg = DatabaseHandler.gettabletoGridView(q);
        }

    }
}
