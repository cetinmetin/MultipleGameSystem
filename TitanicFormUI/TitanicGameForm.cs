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
using TitanicFormUI.Abstract;

namespace TitanicFormUI
{
    public partial class TitanicGameForm : Form, ITitanic
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public TitanicGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxWillNotSurvive1, pbxWillNotSurvive2, pbxWillNotSurvive3, pbxWillNotSurvive4, pbxWillNotSurvive5, pbxWillNotSurvive6, pbxWillNotSurvive7, pbxWillNotSurvive8, pbxWillNotSurvive9, pbxWillNotSurvive10, pbxSurvive1, pbxSurvive2, pbxSurvive3, pbxSurvive4, pbxSurvive5, pbxSurvive6, pbxSurvive7, pbxSurvive8, pbxSurvive9, pbxSurvive10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearMainBox(pbxYourTicket);
            ClearMainBox(pbxDecision);
            this.Hide();
        }

        private void TitanicGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
            ClickEvents(pictureBoxes);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearMainBox(pbxYourTicket);
            ClearMainBox(pbxDecision);
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

        public void ClearMainBox(PictureBox box)
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
                box.MouseClick += new MouseEventHandler((o, a) => pbxYourTicket.Image = box.Image);
                box.MouseClick += LifeDecision;
            }
            void LifeDecision(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxYourTicket.Image)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 10)
                {
                    ClearMainBox(pbxDecision);
                    pbxDecision.ImageLocation = String.Format("{0}\\TitanicFormUI\\Assets-Decision\\1.png", _projectDirectory);
                }
                else if (pbxCounter <= 20)
                {
                    ClearMainBox(pbxDecision);
                    pbxDecision.ImageLocation = String.Format("{0}\\TitanicFormUI\\Assets-Decision\\2.png", _projectDirectory);
                }
            }
        }
    }
}
