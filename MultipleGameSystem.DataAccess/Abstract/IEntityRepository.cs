using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleGameSystem.DataAccess.Abstract
{
    public interface IEntityRepository
    {
        void FileSaver(int picSum, string gameName, string folderName, PictureBox[] pbx);
        void FileRemover(string gameName);
        void PictureSorter(string gameName, PictureBox[] pbx);
    }
}
