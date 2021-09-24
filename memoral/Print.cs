using memoral.Utility.Convertor;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoral
{
    public static class Print
    {
        public static void PrintDGV(DataGridView dgvSabad,StiReport stiPrint,int RecivefactoreId=0)
        {
            DataTable dtPrint = new DataTable();
            if (dtPrint.Columns.Count==0)
            {
                dtPrint.Columns.Add("Count");
                dtPrint.Columns.Add("ProductName");
                dtPrint.Columns.Add("Frequery");
                dtPrint.Columns.Add("Price");
            }

            int AllPrice = 0;
            foreach (DataGridViewRow row in dgvSabad.Rows)
            {
                dtPrint.Rows.Add(
                    (row.Index + 1).ToString().ToPersianInt(),
                    row.Cells[2].Value.ToString().ToPersianInt(),
                    row.Cells[3].Value.ToString().ToPersianInt(),
                    row.Cells[4].Value.ToString().ToPersianInt()
                    );
                AllPrice += (Convert.ToInt32(row.Cells[4].Value.ToString().ToEnglishInt()) * Convert.ToInt32(row.Cells[3].Value.ToString().ToEnglishInt()));
            }

            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Compile();
            stiPrint["DateTime"] = DateTime.Now.ToShamsi();
            if (RecivefactoreId == 0)
            {
                stiPrint["FactoreId"] = (HomeForm.MaxFactoreCount + 1).ToString().ToPersianInt();
            }else if (RecivefactoreId == 1)
            {
                stiPrint["FactoreId"] = "گزارشات قبلی ";
            }
            stiPrint["AllPrice"] = "   جمع کل " + AllPrice.ToString().ToPersianInt();
            stiPrint.Show();
            dtPrint.Clear();
        }
    }
}
