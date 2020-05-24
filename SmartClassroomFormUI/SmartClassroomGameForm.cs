using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
using SmartClassroomFormUI.Abstract;
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

namespace SmartClassroomFormUI
{
    public partial class SmartClassroomGameForm : Form, IClassroom
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        PictureBox[] pictureBoxes;
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public SmartClassroomGameForm()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] { pbxOff1, pbxOff2, pbxOff3, pbxOff4, pbxOff5, pbxOff6, pbxOff7, pbxOff8, pbxOff9, pbxOff10, pbxOn1, pbxOn2, pbxOn3, pbxOn4, pbxOn5, pbxOn6, pbxOn7, pbxOn8, pbxOn9, pbxOn10 };
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(pictureBoxes);
            ClearMainBox(pbxFan);
            ClearMainBox(pbxSwitch);
            this.Hide();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ClearMainBox(pbxFan);
            ClearMainBox(pbxSwitch);
            pbxFan.ImageLocation = String.Format("{0}\\SmartClassroomFormUI\\Assets-Fan\\1.jpeg", _projectDirectory);
        }

        private void SmartClassroomGameForm_Load(object sender, EventArgs e)
        {
            entityRepository.PictureSorter(this.ProductName, pictureBoxes);
            pbxFan.ImageLocation = String.Format("{0}\\SmartClassroomFormUI\\Assets-Fan\\1.jpeg", _projectDirectory);
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
                box.MouseClick += new MouseEventHandler((o, a) => pbxSwitch.Image = box.Image);
                box.MouseClick += SwitchSensor;
            }
            void SwitchSensor(object sender, MouseEventArgs e)
            {
                int pbxCounter = 0;
                foreach (PictureBox pBox in pictureBoxes)
                {
                    pbxCounter++;
                    if (pBox.Image == pbxSwitch.Image)
                    {
                        break;
                    }
                }
                if (pbxCounter <= 10)
                {
                    ClearMainBox(pbxFan);
                    pbxFan.ImageLocation = String.Format("{0}\\SmartClassroomFormUI\\Assets-Fan\\1.jpeg", _projectDirectory);
                }
                else if (pbxCounter <= 20)
                {
                    ClearMainBox(pbxFan);
                    pbxFan.ImageLocation = String.Format("{0}\\SmartClassroomFormUI\\Assets-Fan\\2.jpeg", _projectDirectory);
                }
            }
        }
    }
}
