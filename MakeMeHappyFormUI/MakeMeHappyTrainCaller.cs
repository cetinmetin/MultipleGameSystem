using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeHappyFormUI
{
    public class MakeMeHappyTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new MakeMeHappyGameForm(), "Recognising images as Happy or Sad", "Happy","Sad");
            generalTrainForm.Show();
        }
    }
}
