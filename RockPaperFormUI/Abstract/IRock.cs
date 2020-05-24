using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperFormUI.Abstract
{
    public interface IRock
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearMoveBox(PictureBox box);
        void FillUserBoxes(PictureBox[] pbx);
        string ComputerMove();
        void ClickEvents(PictureBox[] pbx);
    }
}
