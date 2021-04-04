using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crop_a_Portion_of_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap originalImage;

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                Bitmap image = (Bitmap)Bitmap.FromFile(filePath);

                listViewOfImages.Items.Add(filePath);
                originalImage = image;
            }
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            int width = int.Parse(textBoxWidth.Text);
            int height = int.Parse(textBoxHeight.Text);
            int x = int.Parse(textBoxXposition.Text);
            int y = int.Parse(textBoxYposition.Text);

            List<Bitmap> cropedImages = new List<Bitmap>();

            Rectangle cropRect = new Rectangle(x, y, width, height);

            Bitmap bmp = new Bitmap(width, height);


            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height), cropRect, GraphicsUnit.Pixel);

            cropedImages.Add(bmp);

            SaveImages(cropedImages);
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
        }

        private void SaveImages(List<Bitmap> images)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                foreach (Bitmap image in images)
                    image.Save(path);
                
            }
        }
    }
}
