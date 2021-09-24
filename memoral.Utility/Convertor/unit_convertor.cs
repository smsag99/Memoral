using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace memoral.Utility.Convertor
{
    public static class unit_convertor
    {
        public static Bitmap ToImage(this byte[] image)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(image, 0, image.Length);
            return new Bitmap(stream);
        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");

        }
        public static DateTime ToMiladi(    DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, new System.Globalization.PersianCalendar());
        }
        public static string ToPersianInt(this string persianStr)
        {
            Dictionary<string, string> LettersDictionary = new Dictionary<string, string>
            {
                ["0"] = "٠",
                ["1"] = "١",
                ["2"] = "٢",
                ["3"] = "٣",
                ["4"] = "٤",
                ["5"] = "٥",
                ["6"] = "٦",
                ["7"] = "٧",
                ["8"] = "٨",
                ["9"] = "٩"
            };
            return LettersDictionary.Aggregate(persianStr, (current, item) =>
                         current.Replace(item.Key, item.Value));

        }

        public static string ToEnglishInt(this string persianStr)
        {
            Dictionary<string, string> LettersDictionary = new Dictionary<string, string>
            {
                ["٠"] = "0",
                ["١"] = "1",
                ["٢"] = "2",
                ["٣"] = "3",
                ["٤"] = "4",
                ["٥"] = "5",
                ["٦"] = "6",
                ["٧"] = "7",
                ["٨"] = "8",
                ["٩"] = "9"
            };
            return LettersDictionary.Aggregate(persianStr, (current, item) =>
                         current.Replace(item.Key, item.Value));

        }

        public static void ToPersianInt(this KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar < 58)
                e.KeyChar = (char)(1632 + int.Parse(e.KeyChar.ToString()));
        }


        public static void JustDecimal(this KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
