using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceLockFormUI
{
    public class FaceLockTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new FaceLockGameForm(), "Recognising images as Granted or Denied", "Granted", "Denied");
            generalTrainForm.Show();
        }
    }
}
