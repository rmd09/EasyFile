using Core;
using CoreForWindows;
using System.Text.Json;

namespace Interface
{
    public partial class Form1 : Form
    {
        private const string STANDART_SHABLONS = "Шаблоны по умолчанию";
        private const string SHABLONS = "Пользовательские шаблоны";
        private const int INDEX_OF_STANDART_SHABLONS = 0;
        private const int INDEX_OF_SHABLONS = 1;
        private readonly Color grey = Color.FromArgb(200, 200, 200);
        private readonly string pathStandartShablons = $"{Environment.CurrentDirectory}\\Шаблоны\\Стандартные шаблоны.json";
        private readonly string pathShablons = $"{Environment.CurrentDirectory}\\Шаблоны\\Пользовательские шаблоны.json";

        private Shablon tempShablon;
        private List<Shablon> standartShablons = new List<Shablon>();
        private List<Shablon> shablons = new List<Shablon>();
        private IndexOfTreeView indexOfTreeView = new IndexOfTreeView(0, 0);
        private bool isChanged = false;
        private bool isLoad = true;
        public Form1()
        {
            InitializeComponent();

            DisableElements();
            CheckShablons();
            FillTreeView();
            isLoad = false;
        }

        #region Этап загрузки приложения
        /// <summary>
        /// Разблокировка элементов после первого перехода в какой-нибудь шаблон
        /// </summary>
        private void EnableElements()
        {
            textName.Enabled = true;
            textbInputMask.Enabled = true;
            bStartSort.Enabled = true;
            bDeleteShablon.Enabled = true;
            checkbDateChange.Enabled = true;
            checkbDateCreate.Enabled = true;
            checkbSize.Enabled = true;
            numSize1.Enabled = true;
            numSize2.Enabled = true;
            datetChange1.Enabled = true;
            datetChange2.Enabled = true;
            datetCreate1.Enabled = true;
            datetCreate2.Enabled = true;
            comboSize.Enabled = true;
        }
        private void DisableElements()
        {
            textName.Enabled = false;
            textbInputMask.Enabled = false;
            bStartSort.Enabled = false;
            bDeleteShablon.Enabled = false;
            checkbDateChange.Enabled = false;
            checkbDateCreate.Enabled = false;
            checkbSize.Enabled = false;
            DisableSize();
            DisableDateChange();
            DisableDateCreate();
        }
        /// <summary>
        /// Проверяет наличие json-файлов с шаблонами и, если они есть, заполняет standartShablons и Shablons, в противном случае выводит предупреждение
        /// </summary>
        private void CheckShablons()
        {
            if (File.Exists(pathStandartShablons))
            {
                string json = File.ReadAllText(pathStandartShablons);
                try
                {
                    standartShablons = JsonSerializer.Deserialize<JsonStruct>(json).Shablons;
                }
                catch
                {
                    MessageBox.Show("Файл со стандартными шаблонами был повреждён или неправильно загружен! Дальнейшая работа с файлами будет без этих шаблонов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Файл со стандартными шаблонами был удалён! Дальнейшая работа с файлами будет без этих шаблонов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Create(pathStandartShablons).Close();
            }

            if (File.Exists(pathShablons))
            {
                string json = File.ReadAllText(pathShablons);
                try
                {
                    shablons = JsonSerializer.Deserialize<JsonStruct>(json).Shablons;
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Файл с пользовательскими шаблонами был удалён! Дальнейшая работа с файлами будет без этих шаблонов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Create(pathShablons).Close();
            }
        }

        private void FillTreeView()
        {
            treeView1.Nodes[INDEX_OF_STANDART_SHABLONS].Nodes.Clear();
            for (int i = 0; i < standartShablons.Count; i++)
            {
                treeView1.Nodes[INDEX_OF_STANDART_SHABLONS].Nodes.Add(standartShablons[i].Name);
            }

            treeView1.Nodes[INDEX_OF_SHABLONS].Nodes.Clear();
            for (int i = 0; i < shablons.Count; i++)
            {
                treeView1.Nodes[INDEX_OF_SHABLONS].Nodes.Add(shablons[i].Name);
            }
        }
        #endregion

        private void FillShablon(Shablon shablon)
        {
            EnableElements();
            SetMaxMinValues();
            Filter filter = shablon.Filter;
            textName.Text = shablon.Name;
            textbInputMask.Text = filter.Mask;

            FillSize(filter);
            FillDateCreate(filter);
            FillDateChange(filter);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] korenAndMean = e.Node.FullPath.Split('\\');
            if (korenAndMean.Length == 1)
            {
                indexOfTreeView.Index1 = korenAndMean[0] == STANDART_SHABLONS ? 0 : 1;
                return;
            }

            if (isChanged)
            {
                if (Warning("Сохранять изменения?"))
                {
                    bSave_Click(bSave, null);
                }
            }
            indexOfTreeView.Index2 = e.Node.Index;

            switch (korenAndMean[0])
            {
                case STANDART_SHABLONS:
                    indexOfTreeView.Index1 = 0;
                    FillShablon(standartShablons[indexOfTreeView.Index2]);
                    break;
                case SHABLONS:
                    indexOfTreeView.Index1 = 1;
                    FillShablon(shablons[indexOfTreeView.Index2]);
                    break;
                default:
                    throw new Exception();
            }

            DisChangeProperties();
        }

        private bool Warning(string message)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Обрабатывает изменения, внесённые пользователем
        /// </summary>
        private void ChangeProperties()
        {
            if (isLoad)
            {
                tempShablon = new Shablon();
            }
            else if (!isChanged)
            {
                isChanged = true;
                bSave.Enabled = true;
                tempShablon = indexOfTreeView.Index1 == INDEX_OF_STANDART_SHABLONS ? new Shablon(standartShablons[indexOfTreeView.Index2]) : new Shablon(shablons[indexOfTreeView.Index2]);
            }
        }
        /// <summary>
        /// Восстанавливает состояние формы
        /// </summary>
        private void DisChangeProperties()
        {
            tempShablon = null;
            isChanged = false;
            bSave.Enabled = false;
        }
        #region Изменение данных
        private void checkbSize_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            ChangeProperties();
            if (chb.Checked)
            {
                DisableSize();
            }
            else
            {
                EnableSize();
                comboSize_SelectedIndexChanged(comboSize, null);
            }

            Filter filter = tempShablon.Filter;
            filter.HasSizeBitsInterval = !chb.Checked;
            tempShablon.Filter = filter;
        }

        private void numSize1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            ChangeProperties();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.Start = (long)num.Value;
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;

        }

        private void numSize2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            ChangeProperties();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.End = (long)num.Value;
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ChangeProperties();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.TypeSize = GetTypeSize(comboBox.Text);
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;
        }

        private void checkbDateCreate_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            ChangeProperties();
            if (checkBox.Checked)
            {
                DisableDateCreate();
            }
            else
            {
                EnableDateCreate();
            }

            Filter filter = tempShablon.Filter;
            filter.HasDateTimeIntervalCreate = !checkBox.Checked;
            tempShablon.Filter = filter;

            datetCreate1.Value = DateTime.Now;
            datetCreate2.Value = DateTime.Now;
        }

        private void datetCreate1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeProperties();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalCreate;
            dateTimeInterval.Start = dateTimePicker.Value;
            filter.DateTimeIntervalCreate = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void datetCreate2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeProperties();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalCreate;
            dateTimeInterval.End = dateTimePicker.Value;
            filter.DateTimeIntervalCreate = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void checkbDateChange_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            ChangeProperties();
            if (checkBox.Checked)
            {
                DisableDateChange();
            }
            else
            {
                EnableDateChange();
            }

            Filter filter = tempShablon.Filter;
            filter.HasDateTimeIntervalChange = !checkBox.Checked;
            tempShablon.Filter = filter;

            datetChange1.Value = DateTime.Now;
            datetChange2.Value = DateTime.Now;
        }

        private void datetChange1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeProperties();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalChange;
            dateTimeInterval.Start = dateTimePicker.Value;
            filter.DateTimeIntervalChange = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void datetChange2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeProperties();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalChange;
            dateTimeInterval.End = dateTimePicker.Value;
            filter.DateTimeIntervalChange = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void textbInputMask_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            ChangeProperties();

            Filter filter = tempShablon.Filter;
            filter.Mask = textBox.Text;
            tempShablon.Filter = filter;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            ChangeProperties();

            tempShablon.Name = textBox.Text;
        }
        #endregion

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!CheckTheSameName(tempShablon.Name.Trim(), indexOfTreeView.Index2, indexOfTreeView.Index1))
            {
                MessageBox.Show("Шаблон с таким названием уже существует!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tempShablon.Name = tempShablon.Name.Replace('\n', ' ');
                textName.Text = tempShablon.Name;
            }

            treeView1.Nodes[indexOfTreeView.Index1].Nodes[indexOfTreeView.Index2].Text = tempShablon.Name;

            switch (indexOfTreeView.Index1)
            {
                case 0:
                    standartShablons[indexOfTreeView.Index2] = tempShablon;
                    break;
                case 1:
                    shablons[indexOfTreeView.Index2] = tempShablon;
                    break;
                default:
                    throw new Exception();
            }
            DisChangeProperties();
        }

        private void bDeleteShablon_Click(object sender, EventArgs e)
        {
            isLoad = true;
            if (!Warning("Вы действительно хотите удалить шаблон?"))
            {
                return;
            }
            isChanged = false;

            switch (indexOfTreeView.Index1)
            {
                case 0:
                    standartShablons.RemoveAt(indexOfTreeView.Index2);
                    break;
                case 1:
                    shablons.RemoveAt(indexOfTreeView.Index2);
                    break;
                default: throw new Exception();
            }
            treeView1.Nodes[indexOfTreeView.Index1].Nodes.RemoveAt(indexOfTreeView.Index2);
            DisableElements();
            treeView1.SelectedNode = null;
            isChanged = false;
            isLoad = false;
        }

        private void bNewShablon_Click(object sender, EventArgs e)
        {
            string name = ChooseName(-1);

            switch (indexOfTreeView.Index1)
            {
                case 0:
                    standartShablons.Add(new Shablon(name, new Filter("*.*", false, false, false)));
                    treeView1.Nodes[INDEX_OF_STANDART_SHABLONS].Nodes.Add(name);
                    break;
                case 1:
                    shablons.Add(new Shablon(name, new Filter("*.*", false, false, false)));
                    treeView1.Nodes[INDEX_OF_SHABLONS].Nodes.Add(name);
                    break;
                default:
                    throw new Exception();
            }
        }
        private string ChooseName(int indexOfName, string name = "Новый шаблон")
        {
            if (!CheckTheSameName(name, -1, -1))
            {
                indexOfName++;
                name = $"Новый шаблон ({indexOfName})";
                name = ChooseName(indexOfName, name);
            }

            return name;
        }

        private bool CheckTheSameName(string name, int indexOfElement, int indexOfGroup)
        {
            for (int i = 0; i < standartShablons.Count; i++)
            {
                if (name == standartShablons[i].Name)
                {
                    if (i != indexOfElement || indexOfGroup != INDEX_OF_STANDART_SHABLONS)
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < shablons.Count; i++)
            {
                if (name == shablons[i].Name)
                {
                    if (i != indexOfElement || indexOfGroup != INDEX_OF_SHABLONS)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                if (Warning("Сохранить изменить?"))
                {
                    bSave_Click(null, null);
                }
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonStandartShablons = JsonSerializer.Serialize(new JsonStruct(standartShablons), options);
            string jsonShablons = JsonSerializer.Serialize(new JsonStruct(shablons), options);

            using (FileStream fileStream = new FileStream(pathStandartShablons, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write(jsonStandartShablons);
                }
            }
            using (FileStream fileStream = new FileStream(pathShablons, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write(jsonShablons);
                }
            }
        }

        private void bStartSort_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                bSave_Click(bSave, null);
            }
            PathHelpClass pathHelpStruct = new PathHelpClass();
            new FormForPath(pathHelpStruct).ShowDialog();
            if (pathHelpStruct.isOK)
            {
                FileSorter fileSorter = new FileSorter(pathHelpStruct.PathMain, pathHelpStruct.PathFinal, indexOfTreeView.Index1 == INDEX_OF_STANDART_SHABLONS ? standartShablons[indexOfTreeView.Index2].Filter : shablons[indexOfTreeView.Index2].Filter, pathHelpStruct.CutSortedFiles, pathHelpStruct.SortAllSubdirictories);
                fileSorter.Sort();
                MessageBox.Show("Сортировка прошла успешно", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}