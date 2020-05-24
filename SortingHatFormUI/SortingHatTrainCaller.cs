using GeneralTrainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHatFormUI
{
    public class SortingHatTrainCaller:IFormCaller
    {
        public void EnableForm()
        {
            GeneralTrainForm generalTrainForm = new GeneralTrainForm(new SortingHatGameForm(), "Recognising images as Gryffindor, Slytherin or Hufflepuff", "Gryffindor","Slytherin","Hufflepuff");
            generalTrainForm.Show();
        }
    }
}
