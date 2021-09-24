using memoral.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoral
{
     class ShowProducts
    {
        public ShowProducts(List<DataLayer.Product> dt , Panel panel)
        {
            panel.Controls.Clear();
            product p;
           
            int x = 6, y = 6;
            for (int i = 0; i < dt.Count; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        p = new product();
                        panel.Controls.Add(p);
                        p = bindProduct(p, dt[i]);
                        p.Location = new Point(x, y);
                        x += 6 + p.Size.Width;
                        break;
                    case 1:
                        p = new product();
                        panel.Controls.Add(p);
                        p = bindProduct(p, dt[i]);
                        p.Location = new Point(x, y);
                        x += 6 + p.Size.Width;
                        break;
                    case 2:
                        p = new product();
                        panel.Controls.Add(p);
                        p = bindProduct(p, dt[i]);
                        p.Location = new Point(x, y);
                        y += 6 + p.Size.Height;
                        x = 6;
                        break;
                }
            }
        }
        private product bindProduct(product p, DataLayer.Product dt)
        {
            MemoryStream stream = new MemoryStream();
            byte[] barrImg = dt.image;
            stream.Write(barrImg, 0, barrImg.Length);
            Bitmap bitmap = new Bitmap(stream);
            p.picProductOnce.BackgroundImage = bitmap;
            p.productId = dt.ID;
            p.labelProductName.Text = dt.Name.ToPersianInt();
            p.productFrequry = dt.Frequery;
            p.price = dt.price;
            p.details = dt.details.ToPersianInt();
            return p;
        }
    }
}
