using MultipleGameSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleGameSystem.DataAccess.Concrete.FileOperations
{
    public class EntityRepositoryBase : IEntityRepository
    {
        string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public void FileSaver(int picSum, string gameName, string folderName, PictureBox[] pbx)
        {
            for (int counter = 0; counter < picSum; counter++)
            {
                try
                {
                    var location = String.Format("{0}\\{1}\\Assets\\{2}\\{3}.jpeg", _projectDirectory, gameName, folderName, counter);

                    pbx[counter].Image.Save(location);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu!!");
                }
            }
        }

        public void FileRemover(string gameName)
        {
            var location = String.Format("{0}\\{1}\\Assets", _projectDirectory, gameName);
            System.IO.DirectoryInfo di = new DirectoryInfo(location);
            try
            {
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        file.Delete();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu!!");
            }
        }

        public void PictureSorter(string gameName, PictureBox[] pictureBox)
        {
            int imageCounter = 0;
            int imageFolders = 1;
            var location = String.Format("{0}\\{1}\\Assets", _projectDirectory, gameName);
            System.IO.DirectoryInfo di = new DirectoryInfo(location);
            try
            {
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        pictureBox[imageCounter].Image = new Bitmap(file.FullName.ToString());
                        imageCounter++;
                    }
                    imageFolders++;
                    if (imageFolders == 2)
                    {
                        imageCounter = 10;
                    }
                    if (imageFolders == 3)
                    {
                        imageCounter = 20;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Resim toplama sırasında bir hata oluştu!!");
            }
        }
    }
}
