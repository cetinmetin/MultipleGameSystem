using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShyPandaFormUI.Abstract
{
    public interface IPanda
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearFaceBox(PictureBox box);
        void ClickEvents(PictureBox[] pbx);
    }
}
