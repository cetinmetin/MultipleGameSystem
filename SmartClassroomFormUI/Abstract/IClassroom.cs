using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartClassroomFormUI.Abstract
{
    public interface IClassroom
    {
        void ClearPictureBoxes(PictureBox[] box);
        void ClearMainBox(PictureBox box);
        void ClickEvents(PictureBox[] pbx);
    }
}
