using CarOrCupFormUI;
using CarOrCupGameFormUI;
using ChameleonFormUI;
using FaceLockFormUI;
using MainScreenFormUI.Abstract;
using MakeMeHappyFormUI;
using RockPaperFormUI;
using ShyPandaFormUI;
using SmartClassroomFormUI;
using SnapFormUI;
using SortingHatFormUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TitanicFormUI;
using TrainAndTestFormUI;

namespace MainScreenFormUI
{
    public partial class MainScreenForm : Form, IActive
    {
        public MainScreenForm()
        {
            InitializeComponent();
        }

        public void Active(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void PbxSmartClassroom_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new SmartClassroomTrainCaller(), new SmartClassroomGameForm(), new MainScreenForm()));
        }

        private void PbxMakeMeHappy_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new MakeMeHappyTrainCaller(), new MakeMeHappyGameForm(), new MainScreenForm()));
        }

        private void PbxSnap_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new SnapTrainCaller(), new SnapGameForm(), new MainScreenForm()));
        }

        private void PbxChameleon_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new ChameleonTrainCaller(), new ChameleonGameForm(), new MainScreenForm()));
        }

        private void PbxTitanic_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new TitanicTrainCaller(), new TitanicGameForm(), new MainScreenForm()));
        }

        private void PbxCarorCup_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new CarOrCupTrainCaller(), new CarOrCupGameForm(), new MainScreenForm()));
        }

        private void PbxFaceLock_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new FaceLockTrainCaller(), new FaceLockGameForm(), new MainScreenForm()));
        }

        private void PbxShyPanda_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new ShyPandaTrainCaller(), new ShyPandaGameForm(), new MainScreenForm()));
        }

        private void PbxSortingHat_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new SortingHatTrainCaller(), new SortingHatGameForm(), new MainScreenForm()));
        }

        private void PbxRockPaperScissors_Click(object sender, EventArgs e)
        {
            Active(new TrainAndTestForm(new RockPaperTrainCaller(), new RockPaperGameForm(), new MainScreenForm()));
        }
    }
}
