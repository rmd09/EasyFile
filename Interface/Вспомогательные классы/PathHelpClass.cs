namespace Interface
{
    /// <summary>
    /// Структура для общения двух форм перед сортировкой
    /// </summary>
    public class PathHelpClass
    {
        public string PathMain { get; set; } = null;
        public string PathFinal { get; set; } = null;
        public bool CutSortedFiles { get; set; } = true;
        public bool SortAllSubdirictories { get; set; } = true;
        /// <summary>
        /// Удачно ли прошёл ввод  путей к файлам
        /// </summary>
        public bool isOK { get; set; } = false;
    }
}
