using GeneralTrainFormUI;
using MultipleGameSystem.DataAccess.Abstract;
using MultipleGameSystem.DataAccess.Concrete.FileOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainAndTestFormUI
{
    public partial class TrainAndTestForm : Form
    {
        IEntityRepository entityRepository = new EntityRepositoryBase();
        Form _formNameGame, _mainScreenForm;
        IFormCaller _formNameTrain;

        public TrainAndTestForm()
        {
            InitializeComponent();
        }

        public TrainAndTestForm(IFormCaller formNameTrain, Form formNameGame, Form mainScreenForm)
        {
            InitializeComponent();
            _formNameTrain = formNameTrain;
            _formNameGame = formNameGame;
            _mainScreenForm = mainScreenForm;
            lblGameName.Text = formNameGame.Text;
        }

        private void BtnTrain_Click(object sender, EventArgs e)
        {
            _formNameTrain.EnableForm();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            _formNameGame.ShowDialog();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            entityRepository.FileRemover(_formNameGame.ProductName);
            this.Hide();
            _mainScreenForm.Show();
        }

    }
}
