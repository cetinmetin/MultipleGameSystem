using FaceLockFormUI.Abstract;
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

namespace FaceLockFormUI
{
    public partial class FaceLockGameForm : Form, IFaceLock
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;

        public FaceLockGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxDenied1, pbxDenied2, pbxDenied3, pbxDenied4, pbxDenied5, pbxDenied6, pbxDenied7, pbxDenied8, pbxDenied9, pbxDenied10, pbxGranted1, pbxGranted2, pbxGranted3, pbxGranted4, pbxGranted5, pbxGranted6, pbxGranted7, pbxGranted8, pbxGranted9, pbxGranted10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearFaceBox(pbxFace);
            this.Hide();
        }

        private void FaceLockGameForm_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFaceBox(pbxFace);
                }
                else if (pbxCounter <= 20)
                {
                    MessageBox.Show("Access Granted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFaceBox(pbxFace);
                }
            }
        }
    }
}

