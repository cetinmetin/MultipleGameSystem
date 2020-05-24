using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartClassroomFormUI
{
    public class SmartClassroomTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new SmartClassroomGameForm(), "Recognising images as Fan On or Fan Off", "Fan On","Fan Off");
            generalTrainForm.Show();
        }
    }
}
