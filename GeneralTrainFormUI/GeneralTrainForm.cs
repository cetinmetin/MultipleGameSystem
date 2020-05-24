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

namespace GeneralTrainFormUI
{
    public partial class GeneralTrainForm : Form
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        int _firstObjects, _secondObjects, _thirdObjects = 0;
        PictureBox[] pbxFirst, pbxSecond, pbxThird;
        Form _gameScreen;

        public GeneralTrainForm()
        {
            InitializeComponent();
        }

        public GeneralTrainForm(Form gameScreen, string screenInfo, string firstGbxName)
        {
            InitializeComponent();
            lblScreenTitle.Text = screenInfo;
            gbxFirstObjectPictures.Text = firstGbxName;
            gbxSecondObjectPictures.Enabled = false;
            gbxThirdObjectPictures.Enabled = false;
            pbxFirst = new PictureBox[] { pbxFirstObject1, pbxFirstObject2, pbxFirstObject3, pbxFirstObject4, pbxFirstObject5, pbxFirstObject6, pbxFirstObject7, pbxFirstObject8, pbxFirstObject9, pbxFirstObject10 };
            _gameScreen = gameScreen;
        }

        public GeneralTrainForm(Form gameScreen, string screenInfo, string firstGbxName, string secondGbxName)
        {
            InitializeComponent();
            lblScreenTitle.Text = screenInfo;
            gbxFirstObjectPictures.Text = firstGbxName;
            gbxSecondObjectPictures.Text = secondGbxName;
            gbxThirdObjectPictures.Enabled = false;
            pbxFirst = new PictureBox[] { pbxFirstObject1, pbxFirstObject2, pbxFirstObject3, pbxFirstObject4, pbxFirstObject5, pbxFirstObject6, pbxFirstObject7, pbxFirstObject8, pbxFirstObject9, pbxFirstObject10 };
            pbxSecond = new PictureBox[] { pbxSecondObject1, pbxSecondObject2, pbxSecondObject3, pbxSecondObject4, pbxSecondObject5, pbxSecondObject6, pbxSecondObject7, pbxSecondObject8, pbxSecondObject9, pbxSecondObject10 };
            _gameScreen = gameScreen;
        }

        public GeneralTrainForm(Form gameScreen, string screenInfo, string firstGbxName, string secondGbxName, string thirdGbxName)
        {
            InitializeComponent();
            lblScreenTitle.Text = screenInfo;
            gbxFirstObjectPictures.Text = firstGbxName;
            gbxSecondObjectPictures.Text = secondGbxName;
            gbxThirdObjectPictures.Text = thirdGbxName;
            pbxFirst = new PictureBox[] { pbxFirstObject1, pbxFirstObject2, pbxFirstObject3, pbxFirstObject4, pbxFirstObject5, pbxFirstObject6, pbxFirstObject7, pbxFirstObject8, pbxFirstObject9, pbxFirstObject10 };
            pbxSecond = new PictureBox[] { pbxSecondObject1, pbxSecondObject2, pbxSecondObject3, pbxSecondObject4, pbxSecondObject5, pbxSecondObject6, pbxSecondObject7, pbxSecondObject8, pbxSecondObject9, pbxSecondObject10 };
            pbxThird = new PictureBox[] { pbxThirdObject1, pbxThirdObject2, pbxThirdObject3, pbxThirdObject4, pbxThirdObject5, pbxThirdObject6, pbxThirdObject7, pbxThirdObject8, pbxThirdObject9, pbxThirdObject10 };
            _gameScreen = gameScreen;
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddFirstObject_Click(object sender, EventArgs e)
        {
            Image pictureFirstObject;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (_firstObjects < 10)
                {
                    pictureFirstObject = Image.FromFile(f.FileName);
                    pbxFirst[_firstObjects].Image = pictureFirstObject;
                    _firstObjects++;
                }
                else
                {
                    MessageBox.Show("Maksimum Sayiya Ulaşıldı!!");
                }
            }
        }

        private void BtnSaveFirstObjects_Click(object sender, EventArgs e)
        {
            entityRepository.FileSaver(_firstObjects, _gameScreen.ProductName, gbxFirstObjectPictures.Text, pbxFirst);
        }

        private void BtnAddSecondObject_Click(object sender, EventArgs e)
        {
            Image pictureSecondObject;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (_secondObjects < 10)
                {
                    pictureSecondObject = Image.FromFile(f.FileName);
                    pbxSecond[_secondObjects].Image = pictureSecondObject;
                    _secondObjects++;
                }
                else
                {
                    MessageBox.Show("Maksimum Sayiya Ulaşıldı!!");
                }
            }
        }

        private void BtnSaveSecondObjects_Click(object sender, EventArgs e)
        {
            entityRepository.FileSaver(_secondObjects, _gameScreen.ProductName, gbxSecondObjectPictures.Text, pbxSecond);
        }

        private void BtnAddThirdObject_Click(object sender, EventArgs e)
        {
            Image pictureThirdObject;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (_thirdObjects < 10)
                {
                    pictureThirdObject = Image.FromFile(f.FileName);
                    pbxThird[_thirdObjects].Image = pictureThirdObject;
                    _thirdObjects++;
                }
                else
                {
                    MessageBox.Show("Maksimum Sayiya Ulaşıldı!!");
                }
            }
        }

        private void BtnSaveThirdObjects_Click(object sender, EventArgs e)
        {
            entityRepository.FileSaver(_thirdObjects, _gameScreen.ProductName, gbxThirdObjectPictures.Text, pbxThird);
        }
    }
}
