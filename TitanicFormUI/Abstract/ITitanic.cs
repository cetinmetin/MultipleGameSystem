using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitanicFormUI.Abstract
{
    public interface ITitanic
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearMainBox(PictureBox box);
        void ClickEvents(PictureBox[] pbx);
    }
}
