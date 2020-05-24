using SnapFormUI.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapFormUI
{
    public partial class SnapGameForm : Form, ISnap
    {
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public SnapGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxDiamond, pbxHearth, pbxSpade };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearMoveBox(pbxUserMove);
            ClearMoveBox(pbxCompMove);
            this.Hide();
        }

        private void SnapGameForm_Load(object sender, EventArgs e)
        {
            FillUserBoxes(pictureBoxes);
            ClickEvents(pictureBoxes);
        }

        public void ClearPictureBoxes(PictureBox[] box)
        {
            foreach (PictureBox pbx in box)
            {
                if (pbx.Image != null)
                {
                    pbx.Image.Dispose();
                    pbx.Image = null;
                }
            }
        }

        public void ClearMoveBox(PictureBox box)
        {
            if (box.Image != null)
            {
                box.Image = null;
            }
        }

        public void FillUserBoxes(PictureBox[] pbx)
        {
            int imageCounter = 0;
            int imageFolders = 1;
            var location = String.Format("{0}\\{1}\\Assets", _projectDirectory, this.ProductName);
            System.IO.DirectoryInfo di = new DirectoryInfo(location);
            try
            {
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        pbx[imageCounter].Image = new Bitmap(file.FullName.ToString());
                        break;
                    }
                    imageFolders++;
                    if (imageFolders == 2)
                    {
                        imageCounter = 1;
                    }
                    if (imageFolders == 3)
                    {
                        imageCounter = 2;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Resim toplama sırasında bir hata oluştu!!");
            }
        }

        public string ComputerMove()
        {
            Random rnd = new Random();
            int pictureNumber = rnd.Next(1, 4);
            var location = String.Format("{0}\\{1}\\Assets-ComputerMove\\{2}.jpg", _projectDirectory, this.ProductName, pictureNumber.ToString());
            pbxCompMove.ImageLocation = location;
            switch (pictureNumber)
            {
                case 1:
                    return "Diamond";
                case 2:
                    return "Hearth";
                case 3:
                    return "Spade";
                default:
                    return "";
            }
        }

        public void ClickEvents(PictureBox[] pbx)
        {
            foreach (PictureBox box in pbx)
            {
                box.MouseClick += new MouseEventHandler((o, a) => pbxUserMove.Image = box.Image);
                box.MouseClick += MoveDedector;
                ClearMoveBox(pbxUserMove);
                ClearMoveBox(pbxCompMove);
            }

            void MoveDedector(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                string computerMove = ComputerMove();
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxUserMove.Image)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 1)
                {
                    lblUserMove.Text = "You: Diamond";
                    if (computerMove == "Diamond")
                    {
                        lblWinner.Text = "Snap!";
                    }
                    else
                    {
                        lblWinner.Text = "";
                    }
                }
                else if (pbxCounter <= 2)
                {
                    lblUserMove.Text = "You: Hearth";
                    if (computerMove == "Hearth")
                    {
                        lblWinner.Text = "Snap!";
                    }
                    else
                    {
                        lblWinner.Text = "";
                    }
                }
                else if (pbxCounter <= 3)
                {
                    lblUserMove.Text = "You: Spade";
                    if (computerMove == "Spade")
                    {
                        lblWinner.Text = "Snap!";
                    }
                    else
                    {
                        lblWinner.Text = "";
                    }
                }
            }
        }
    }
}
