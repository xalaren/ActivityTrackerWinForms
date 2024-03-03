using System.IO;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    public class Files
    {
        public string ParentDirectoryPath { get; private set; }  //Родительский каталог
        public string DirectoryPath { get; private set; }  //Каталог, задаваемый пользователем

        public Files()
        {
            ParentDirectoryPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            DirectoryCreateOrOpen();
        }

        private void DirectoryCreateOrOpen()
        {
            if (!Directory.Exists(ParentDirectoryPath))
            {
                Directory.CreateDirectory(ParentDirectoryPath);
            }
            DirectoryPath = ParentDirectoryPath;
        }

        public void DirectoryCreateOrOpen(string name)
        {
            DirectoryPath = ParentDirectoryPath + @"\" + name;
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
        }

        public void ToCatalog(string catalogName)
        {
            if (catalogName != @"\")
            {
                DirectoryCreateOrOpen(catalogName);
            }
            else
            {
                DirectoryCreateOrOpen();
            }
        }
    }
}
