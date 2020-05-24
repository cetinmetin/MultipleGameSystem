using CarOrCupGameFormUI.Abstract;
using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
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

namespace CarOrCupFormUI
{
    public partial class CarOrCupGameForm : Form, ICar
    {
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes, randomPictureBoxes;

        public CarOrCupGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxCar1, pbxCar2, pbxCar3, pbxCar4, pbxCar5, pbxCar6, pbxCar7, pbxCar8, pbxCar9, pbxCar10, pbxCup1, pbxCup2, pbxCup3, pbxCup4, pbxCup5, pbxCup6, pbxCup7, pbxCup8, pbxCup9, pbxCup10 };
            randomPictureBoxes = new PictureBox[] { pbx1, pbx2, pbx3, pbx4, pbx5, pbx6, pbx7, pbx8, pbx9, pbx10, pbx11, pbx12, pbx13, pbx14, pbx15, pbx16, pbx17, pbx18, pbx19, pbx20 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearPictureBoxes(randomPictureBoxes);
            this.Hide();
        }

        private void CarOrCupGameForm_Load(object sender, EventArgs e)
        {
            PictureRandomSorter(this.ProductName, randomPictureBoxes);
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearPictureBoxes(randomPictureBoxes);
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearPictureBoxes(randomPictureBoxes);
            PictureRandomSorter(this.ProductName, randomPictureBoxes);
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

        public void PictureRandomSorter(string gameName, PictureBox[] pictureBox)
        {
            Random rnd = new Random();
            int randomNumber = 0;
            var location = String.Format("{0}\\{1}\\Assets", _projectDirectory, gameName);
            System.IO.DirectoryInfo di = new DirectoryInfo(location);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    randomNumber = rnd.Next(0, 20);
                    if (pictureBox[randomNumber].Image == null)
                    {
                        pictureBox[randomNumber].Image = new Bitmap(file.FullName.ToString());
                        randomNumber = rnd.Next(0, 20);
                    }
                    else
                    {
                        randomNumber = rnd.Next(0, 20);
                    }
                }
            }
        }
    }
}
