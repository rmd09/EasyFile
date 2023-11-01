namespace Core
{
    public abstract class AbstrFileSorter
    {
        public AbstrFileSorter(string pathMainFolder, string pathFinalFolder, Filter filter, bool cutSortedFiles = true, bool sortFilesFromSubFolders = true)
        {
            PathMainFolder = pathMainFolder;
            PathFinalFolder = pathFinalFolder;
            Filter = filter;
            MoveSortedFiles = cutSortedFiles;
            SortFilesFromSubFolders = sortFilesFromSubFolders;
        }

        public string PathMainFolder { get; private set; }
        public string PathFinalFolder { get; private set; }
        public Filter Filter { get; private set; }
        /// <summary>
        /// Мы вырезаем отсортированные файлы в папку назначения или копируем их туда
        /// </summary>
        public bool MoveSortedFiles { get; private set; }
        /// <summary>
        /// true: сортируем все файлы корневой папки и в её подпапках
        /// false: сортирует файлы только в корневой папке
        /// </summary>
        public bool SortFilesFromSubFolders { get; private set; }


        /// <summary>
        /// Возвращает массив файлов из главной папки и всех её подпапок
        /// </summary>
        /// <param name="path">Главная папка</param>
        /// <returns>Пути к файлам</returns>
        protected abstract string[] GetAlFiles(string path);
        /// <summary>
        /// Возвращает файлы только из главной папки (без файлов её подпапок)
        /// </summary>
        /// <param name="path">Главная папка</param>
        /// <returns>Пути к файлам</returns>
        protected abstract string[] GetFiles(string path);
        protected abstract void MoveFile(string path, string pathToMove);
        protected abstract void CopyFile(string path, string pathToCopy);
        protected abstract FileProperties GetFileProperties(string path);
        /// <summary>
        /// Удаляет все подпапки по указанному пути. Все файлы из подпапок перемещаются в главную папку (указанный путь)
        /// </summary>
        public abstract void DeleteAllSubdirectories();

        public void Sort()
        {
            string[] files = SortFilesFromSubFolders ? GetAlFiles(PathMainFolder) : GetFiles(PathMainFolder);

            for (int i = 0; i < files.Length; i++)
            {
                FileProperties fileProperties = GetFileProperties(files[i]);
                if (SortWithFilter(fileProperties, Filter))
                {
                    if (MoveSortedFiles)
                        MoveFile(fileProperties.Path, PathFinalFolder);
                    else
                        CopyFile(fileProperties.Path, PathFinalFolder);
                }

            }
        }

        private bool SortWithFilter(FileProperties fileProperties, Filter filter)
        {
            bool isRightMask = fileProperties.Name.SortWithMask(filter.Mask);
            bool isRightDateTimeIntervalChange = fileProperties.TimeOfLastChange.SortDateByInterval(filter.DateTimeIntervalChange);
            bool isRightDateTimeIntervalCreate = fileProperties.TimeCreate.SortDateByInterval(filter.DateTimeIntervalCreate);
            bool isRightSize = fileProperties.SizeBites.SortBySize(filter.SizeBitesInterval);

            if (
                isRightMask && 
                (!filter.HasDateTimeIntervalChange || isRightDateTimeIntervalChange) && 
                (!filter.HasDateTimeIntervalChange ||isRightDateTimeIntervalCreate) && 
                (!filter.HasSizeBitsInterval || isRightSize)
                )
                return true;
            else
                return false;
        }
    }
}
