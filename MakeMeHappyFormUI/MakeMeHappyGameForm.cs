using MakeMeHappyFormUI.Abstract;
using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeMeHappyFormUI
{
    public partial class MakeMeHappyGameForm : Form, IHappy
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;

        public MakeMeHappyGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxHappy1, pbxHappy2, pbxHappy3, pbxHappy4, pbxHappy5, pbxHappy6, pbxHappy7, pbxHappy8, pbxHappy9, pbxHappy10, pbxSad1, pbxSad2, pbxSad3, pbxSad4, pbxSad5, pbxSad6, pbxSad7, pbxSad8, pbxSad9, pbxSad10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearFaceBox(pbxFace);
            this.Hide();
        }

        private void MakeMeHappyGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
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
                box.MouseClick += FaceScanner;
                ClearFaceBox(pbxFace);
            }
            void FaceScanner(object sender, MouseEventArgs e)
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
                    MessageBox.Show("You Are Look Like Happy =)", "=)", MessageBoxButtons.OK);
                    ClearFaceBox(pbxFace);
                }
                else if (pbxCounter <= 20)
                {
                    MessageBox.Show("You Are Look Like Sad =(", "=(", MessageBoxButtons.OK);
                    ClearFaceBox(pbxFace);
                }
            }
        }
    }
}
