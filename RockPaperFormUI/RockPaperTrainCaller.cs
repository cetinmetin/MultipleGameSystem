using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperFormUI
{
    public class RockPaperTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new RockPaperGameForm(), "Recognising images Paper, Rock or Scissors", "Paper","Rock","Scissors");
            generalTrainForm.Show();
        }
    }
}
