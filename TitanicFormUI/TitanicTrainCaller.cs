using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicFormUI
{
    public class TitanicTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new TitanicGameForm(), "Recognising tickets as Survived or Did not survived", "Survived","Did not survived");
            generalTrainForm.Show();
        }
    }
}
