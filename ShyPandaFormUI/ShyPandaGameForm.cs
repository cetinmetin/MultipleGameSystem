using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
using ShyPandaFormUI.Abstract;
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

namespace ShyPandaFormUI
{
    public partial class ShyPandaGameForm : Form, IPanda
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public ShyPandaGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxLooking1, pbxLooking2, pbxLooking3, pbxLooking4, pbxLooking5, pbxLooking6, pbxLooking7, pbxLooking8, pbxLooking9, pbxLooking10, pbxNotLooking1, pbxNotLooking2, pbxNotLooking3, pbxNotLooking4, pbxNotLooking5, pbxNotLooking6, pbxNotLooking7, pbxNotLooking8, pbxNotLooking9, pbxNotLooking10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearFaceBox(pbxPanda);
            ClearFaceBox(pbxFace);
            this.Hide();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearFaceBox(pbxPanda);
            ClearFaceBox(pbxFace);
            pbxPanda.ImageLocation = String.Format("{0}\\ShyPandaFormUI\\Assets-Panda\\1.jpg", _projectDirectory);
        }

        private void ShyPandaGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
            pbxPanda.ImageLocation = String.Format("{0}\\ShyPandaFormUI\\Assets-Panda\\1.jpg", _projectDirectory);
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

        public void ClearFaceBox(PictureBox box)
        {
            if (box.Image != null)
            {
                box.Image = null;
            }
        }

        public void ClickEvents(PictureBox[] pbx)
        {
            foreach (PictureBox box in pbx)
            {
                box.MouseClick += new MouseEventHandler((o, a) => pbxFace.Image = box.Image);
                box.MouseClick += LookSensor;
            }
            void LookSensor(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxFace.Image)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 10)
                {
                    ClearFaceBox(pbxPanda);
                    pbxPanda.ImageLocation = String.Format("{0}\\ShyPandaFormUI\\Assets-Panda\\2.jpg", _projectDirectory);
                }
                else if (pbxCounter <= 20)
                {
                    ClearFaceBox(pbxPanda);
                    pbxPanda.ImageLocation = String.Format("{0}\\ShyPandaFormUI\\Assets-Panda\\1.jpg", _projectDirectory);
                }
            }
        }
    }
}
