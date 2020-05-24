using CarOrCupFormUI;
using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOrCupGameFormUI
{
    public class CarOrCupTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new CarOrCupGameForm(), "Recognising images as Car or Cup", "Cars", "Cups");
            generalTrainForm.Show();
        }
        
    }
}
