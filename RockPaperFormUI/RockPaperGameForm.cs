using RockPaperFormUI.Abstract;
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

namespace RockPaperFormUI
{
    public partial class RockPaperGameForm : Form, IRock
    {
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public RockPaperGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxPap, pbxRoc, pbxSciss };
        }

        private void RockPaperGameForm_Load(object sender, EventArgs e)
        {
            FillUserBoxes(pictureBoxes);
            ClickEvents(pictureBoxes);
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearMoveBox(pbxUserMove);
            ClearMoveBox(pbxCompMove);
            this.Hide();
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
            var location = String.Format("{0}\\{1}\\Assets-ComputerMove\\{2}.png", _projectDirectory, this.ProductName, pictureNumber.ToString());
            pbxCompMove.ImageLocation = location;
            switch (pictureNumber)
            {
                case 1:
                    return "Paper";
                case 2:
                    return "Scissors";
                case 3:
                    return "Rock";
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
                    lblUserMove.Text = "Your Move: Paper";
                    if (computerMove == "Scissors")
                    {
                        lblWinner.Text = "You Lose!";
                    }
                    else if (computerMove == "Rock")
                    {
                        lblWinner.Text = "You Win!";
                    }
                    else
                    {
                        lblWinner.Text = "";
                    }
                }
                else if (pbxCounter <= 2)
                {
                    lblUserMove.Text = "Your Move: Rock";
                    if (computerMove == "Paper")
                    {
                        lblWinner.Text = "You Lose!";
                    }
                    else if (computerMove == "Scissors")
                    {
                        lblWinner.Text = "You Win!";
                    }
                    else
                    {
                        lblWinner.Text = "";
                    }
                }
                else if (pbxCounter <= 3)
                {
                    lblUserMove.Text = "Your Move: Scissors";
                    if (computerMove == "Rock")
                    {
                        lblWinner.Text = "You Lose!";
                    }
                    else if (computerMove == "Paper")
                    {
                        lblWinner.Text = "You Win!";
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
