using ChameleonFormUI.Abstract;
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

namespace ChameleonFormUI
{
    public partial class ChameleonGameForm : Form, IChameleon
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        public ChameleonGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxBlue1, pbxBlue2, pbxBlue3, pbxBlue4, pbxBlue5, pbxBlue6, pbxBlue7, pbxBlue8, pbxBlue9, pbxBlue10, pbxGreen1, pbxGreen2, pbxGreen3, pbxGreen4, pbxGreen5, pbxGreen6, pbxGreen7, pbxGreen8, pbxGreen9, pbxGreen10, pbxRed1, pbxRed2, pbxRed3, pbxRed4, pbxRed5, pbxRed6, pbxRed7, pbxRed8, pbxRed9, pbxRed10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearChameleonBox(pbxChameleon);
            this.Hide();
        }

        private void ChameleonGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
            pbxChameleon.ImageLocation = String.Format("{0}\\ChameleonFormUI\\Assets-Chameleons\\transparent.png", _projectDirectory);
            ClickEvents(pictureBoxes);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearChameleonBox(pbxChameleon);
            ClearChameleonBackground(pbxChameleon);
            pbxChameleon.ImageLocation = String.Format("{0}\\ChameleonFormUI\\Assets-Chameleons\\transparent.png", _projectDirectory);
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

        public void ClearChameleonBox(PictureBox chameleon)
        {
            if (chameleon.Image != null)
            {
                chameleon.Image = null;
            }
        }

        public void ClearChameleonBackground(PictureBox chameleon)
        {
            if (chameleon.BackgroundImage != null)
            {
                chameleon.BackgroundImage = null;
            }
        }

        public void ClickEvents(PictureBox[] pbx)
        {
            foreach (PictureBox box in pbx)
            {
                box.MouseClick += new MouseEventHandler((o, a) => pbxChameleon.BackgroundImage = box.Image);
                box.MouseClick += FindBackgroundColor;
            }
            void FindBackgroundColor(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxChameleon.BackgroundImage)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 10)
                {
                    ClearChameleonBox(pbxChameleon);
                    pbxChameleon.ImageLocation = String.Format("{0}\\ChameleonFormUI\\Assets-Chameleons\\blue.png", _projectDirectory);
                }
                else if (pbxCounter <= 20)
                {
                    ClearChameleonBox(pbxChameleon);
                    pbxChameleon.ImageLocation = String.Format("{0}\\ChameleonFormUI\\Assets-Chameleons\\green.png", _projectDirectory);
                }
                else if (pbxCounter <= 30)
                {
                    ClearChameleonBox(pbxChameleon);
                    pbxChameleon.ImageLocation = String.Format("{0}\\ChameleonFormUI\\Assets-Chameleons\\red.png", _projectDirectory);
                }
            }
        }
    }
}
