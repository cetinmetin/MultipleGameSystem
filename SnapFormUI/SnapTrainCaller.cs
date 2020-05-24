using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFormUI
{
    public class SnapTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new SnapGameForm(), "Recognising images as Heart, Diamond or Spade", "Heart","Diamond","Spade");
            generalTrainForm.Show();
        }
    }
}
