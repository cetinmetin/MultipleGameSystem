using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyPandaFormUI
{
    public class ShyPandaTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new ShyPandaGameForm(), "Recognising images as Looking or Not Looking", "Looking","Not Looking");
            generalTrainForm.Show();
        }
    }
}
