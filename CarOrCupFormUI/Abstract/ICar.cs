using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOrCupGameFormUI.Abstract
{
    public interface ICar
    {
        void ClearPictureBoxes(PictureBox[] box);
        void PictureRandomSorter(string gameName, PictureBox[] pictureBox);
    }
}
