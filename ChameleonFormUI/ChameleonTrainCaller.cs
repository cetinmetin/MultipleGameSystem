using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChameleonFormUI
{
    public class ChameleonTrainCaller : IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new ChameleonGameForm(), "Recognising images as Red, Green or Blue", "Red", "Blue","Green");
            generalTrainForm.Show();
        }
    }
}
