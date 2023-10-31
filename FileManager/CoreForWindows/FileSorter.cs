using MainCore;
using System.IO;

namespace FileCore
{
    public class FileSorter : AbstrFileSorter
    {
        public FileSorter(string pathMainFolder, string pathFinalFolder, Filter filter, bool cutSortedFiles = true, bool sortFilesFromSubFolders = true) : base(pathMainFolder, pathFinalFolder, filter, cutSortedFiles, sortFilesFromSubFolders)
        {
        }


        protected override void CopyFile(string path, string pathToCopy)
        {
            File.Copy(path, pathToCopy + "\\" + Path.GetFileName(path), true);
        }

        protected override void MoveFile(string path, string pathToMove)
        {
            File.Move(path, pathToMove + "\\" + Path.GetFileName(path), true);
        }
        protected override string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        protected override string[] GetAlFiles(string path)
        {
            return Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        }

        protected override FileProperties GetFileProperties(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            return new FileProperties(path, fileInfo.Name, fileInfo.LastWriteTime, fileInfo.CreationTime, fileInfo.Length);
        }


        public override void DeleteAllSubdirectories()
        {
            _DeleteAllSubdirectories(PathMainFolder); //Для рекурсии обязательно нужен параметр, поэтому для красоты второй метод под капотом
        }
        private void _DeleteAllSubdirectories(string path)
        {
            string[] subdirectories = Directory.GetDirectories(path);

            for (int i = 0; i < subdirectories.Length; i++)
            {
                _DeleteAllSubdirectories(subdirectories[i]);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                File.Move(file, PathMainFolder + "\\" + Path.GetFileName(file), true);
            }
        }
    }
}