using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHatFormUI.Abstract
{
    public interface IHat
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearMainBox(PictureBox pbxHat);
        void ClickEvents(PictureBox[] pbx);
    }
}
