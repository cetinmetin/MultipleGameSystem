using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChameleonFormUI.Abstract
{
    public interface IChameleon
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearChameleonBox(PictureBox chameleon);
        void ClearChameleonBackground(PictureBox chameleon);
        void ClickEvents(PictureBox[] pbx);
    }
}
