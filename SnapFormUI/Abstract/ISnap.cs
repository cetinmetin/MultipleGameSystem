using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapFormUI.Abstract
{
    public interface ISnap
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearMoveBox(PictureBox box);
        void FillUserBoxes(PictureBox[] pbx);
        string ComputerMove();
        void ClickEvents(PictureBox[] pbx);
    }
}
