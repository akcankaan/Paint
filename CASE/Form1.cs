using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace CASE
{
    public partial class Form1 : Form
    {
        bool cizimAktifmi = false;
        Sekiller[] sekil;
        Sekiller aktifSekil = null;
        Sekiller seciliSekil = null;
        int secilenSekil = 0;
        int sekilSayisi = 0;
        int maxSekilSayisi = 100;
        Bitmap bm;
        Color SecilenRenk;
        public Form1()
        {
            sekil = new Sekiller[maxSekilSayisi];
            SecilenRenk = Color.Red;
            secilenSekil = 1;
            InitializeComponent();
            bm = new Bitmap(Panel.Width, Panel.Height);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            cizimAktifmi = false;
            
            if(sekilSayisi != maxSekilSayisi)
            {
                sekil[sekilSayisi] = aktifSekil;
                sekilSayisi++;
            }
            Panel.Invalidate();
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Point konum = e.Location;
            label2.Text = konum.ToString();
            if (cizimAktifmi)
            {
                aktifSekil.BitisAta(e.X, e.Y);
                Panel.Invalidate();
            }
        }
        int secim;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (secim == 1)
            {
                foreach (var siradaki in sekil)
                {
                    if (siradaki == null)
                        continue;
                    if (siradaki.Icindemi(e.X, e.Y)==true)
                    {
                        seciliSekil = siradaki;
                        aktifSekil = seciliSekil;
                        siradaki.Sekilrengi = SecilenRenk;
                        Panel.Refresh();
                        secim = 0;
                        break;
                    }
                }
            }
            int sira = 0;
            if(secim == 2)
            {
                foreach(Sekiller item in sekil)
                {
                    if (item.Icindemi(e.X, e.Y)==false)
                    {
                        seciliSekil = item;
                        aktifSekil = seciliSekil;
                        sekil[sira] = null;
                        Panel.Refresh();
                        secim = 0;
                        break;
                    }
                } sira++;
            }
            if(!cizimAktifmi)
            {
                if(secilenSekil == 1)
                {
                    aktifSekil = new Kare();
                    cizimAktifmi = true;
                }
                else if(secilenSekil == 2)
                {
                    aktifSekil = new Daire();
                    cizimAktifmi = true;
                }
                else if (secilenSekil == 3)
                {
                    aktifSekil = new Ucgen();
                    cizimAktifmi = true;
                }
                else if (secilenSekil == 4)
                {
                    aktifSekil = new Altigen();
                    cizimAktifmi = true;
                }
                aktifSekil.x = e.X;
                aktifSekil.y = e.Y;
                aktifSekil.Sekilrengi = SecilenRenk;
            }
            Panel.Invalidate();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics cizim = e.Graphics;
            if(aktifSekil != null)
            {
                aktifSekil.Sekilrengi = SecilenRenk;
                aktifSekil.Ciz(cizim);
            }
            for(int i = 0; i < sekilSayisi; i++)
            {
                if (sekil[i]!=null)
                {
                    sekil[i].Ciz(cizim);
                }
            }
            if (seciliSekil != null)
            {
                seciliSekil.SinirCiz(cizim);
            }
        }

        private void pb_Dikdortgen_Click(object sender, EventArgs e)
        {
            secilenSekil = 1;
        }

        private void pb_Cember_Click(object sender, EventArgs e)
        {
            secilenSekil = 2;
        }

        private void pb_Ucgen_Click(object sender, EventArgs e)
        {
            secilenSekil=3;
        }

        private void pb_Altigen_Click(object sender, EventArgs e)
        {
           secilenSekil = 4;
        }

        private void Pb_Red_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Red;
        }

        private void Pb_Blue_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Blue;
        }

        private void Pb_Green_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Green;
        }

        private void Pb_Orange_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Orange;
        }

        private void Pb_Black_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Black;
        }

        private void Pb_Yellow_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Yellow;
        }

        private void Pb_Purple_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Purple;
        }

        private void Pb_Brown_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.Brown;
        }

        private void Pb_White_Click(object sender, EventArgs e)
        {
            SecilenRenk = Color.White;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Graphics setPaint = Graphics.FromImage(bm);
            Rectangle rect = Panel.RectangleToScreen(Panel.ClientRectangle);
            setPaint.CopyFromScreen(rect.Location, Point.Empty, Panel.Size);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Txt files| *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(save.FileName))
                        File.Delete(save.FileName);
                    if (save.FileName.Contains(".txt"))
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }


        private void pb_Cop_Click(object sender, EventArgs e)
        {
            secim = 2;
        }

        private void pb_Select_Click(object sender, EventArgs e)
        {
            secim = 1;
           
        }


        private void pb_Open_Click(object sender, EventArgs e)
        {
            Graphics setPaint = Graphics.FromImage(bm);
            Rectangle rect = Panel.RectangleToScreen(Panel.ClientRectangle);
            setPaint.CopyFromScreen(rect.Location, Point.Empty, Panel.Size);
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Txt files| *.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(open.FileName))
                        File.Delete(open.FileName);
                    if (open.FileName.Contains(".txt"))
                        bm.Save(open.FileName, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error : " + ex.Message);
                }
            }
        }

        private void pb_Cop_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Cop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
        }

        private void pb_Cop_MouseUp(object sender, MouseEventArgs e)
        {
         
                foreach (var item in seciliSekil.sekillers)
                {

                   
                        seciliSekil.sekillers.Remove(item);
                        Refresh();
                  
                }
         
        }

        private void pb_Clear_Click(object sender, EventArgs e)
        {
            Panel.Image = null;
            Panel.Refresh();
        }
    }
}
