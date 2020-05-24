using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
using SortingHatFormUI.Abstract;
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

namespace SortingHatFormUI
{
    public partial class SortingHatGameForm : Form, IHat
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public SortingHatGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxGryffindor1, pbxGryffindor2, pbxGryffindor3, pbxGryffindor4, pbxGryffindor5, pbxGryffindor6, pbxGryffindor7, pbxGryffindor8, pbxGryffindor9, pbxGryffindor10, pbxHufflepuff1, pbxHufflepuff2, pbxHufflepuff3, pbxHufflepuff4, pbxHufflepuff5, pbxHufflepuff6, pbxHufflepuff7, pbxHufflepuff8, pbxHufflepuff9, pbxHufflepuff10, pbxSlytherin1, pbxSlytherin2, pbxSlytherin3, pbxSlytherin4, pbxSlytherin5, pbxSlytherin6, pbxSlytherin7, pbxSlytherin8, pbxSlytherin9, pbxSlytherin10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearMainBox(pbxHat);
            ClearMainBox(pbxStudent);
            this.Hide();
        }

        private void SortingHatGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
            pbxHat.ImageLocation = String.Format("{0}\\SortingHatFormUI\\Assets-Hat\\hat.png", _projectDirectory);
            ClickEvents(pictureBoxes);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearMainBox(pbxStudent);
            lblHat.Text = "";
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

        public void ClearMainBox(PictureBox pbxHat)
        {
            if (pbxHat.Image != null)
            {
                pbxHat.Image = null;
            }
        }

        public void ClickEvents(PictureBox[] pbx)
        {
            foreach (PictureBox box in pbx)
            {
                box.MouseClick += new MouseEventHandler((o, a) => pbxStudent.Image = box.Image);
                box.MouseClick += FindHouse;
            }
            void FindHouse(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxStudent.Image)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 10)
                {
                    lblHat.Text = "Better be Gryffindor!";
                }
                else if (pbxCounter <= 20)
                {
                    lblHat.Text = "Better be Hufflepuff!";
                }
                else if (pbxCounter <= 30)
                {
                    lblHat.Text = "Better be Slytherin!";
                }
            }
        }
    }
}
