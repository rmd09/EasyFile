using Core;
using CoreForWindows;
using System.Text.Json;

namespace Interface
{
    public partial class Form1 : Form
    {
        private const string STANDART_SHABLONS = "������� �� ���������";
        private const string SHABLONS = "���������������� �������";
        private const int INDEX_OF_STANDART_SHABLONS = 0;
        private const int INDEX_OF_SHABLONS = 1;
        private readonly Color grey = Color.FromArgb(200, 200, 200);
        private readonly string pathStandartShablons = $"{Environment.CurrentDirectory}\\�������\\����������� �������.json";
        private readonly string pathShablons = $"{Environment.CurrentDirectory}\\�������\\���������������� �������.json";

        private Shablon tempShablon; //!!!!!!!!!!!!!!!!!
        private List<Shablon> standartShablons = new List<Shablon>();
        private List<Shablon> shablons = new List<Shablon>();
        private IndexOfTreeView indexOfTreeView = new IndexOfTreeView(0, 0);
        private bool isChanged = false;
        public Form1()
        {
            InitializeComponent();

            SetMaxMinValues();
            CheckShablons();
            FillTreeView();

            //List<Shablon> Shablons = new List<Shablon>(3)
            //{
            //    new Shablon("��������� ��������", new Filter("*.txt", true, true, true, new DateTimeInterval(new DateTime(2023, 11, 1), DateTime.Now), new DateTimeInterval(new DateTime(2023, 11, 6), DateTime.Now), new SizeInterval(2000, 14000))),
            //    new Shablon("��������� �������� Word", new Filter("*.doc*", false, false, false)),
            //    new Shablon("�������� PowerPoint", new Filter("*.ppt*", false, false, false))
            //};
            //JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            //jsonSerializerOptions.WriteIndented = true;
            //string json = JsonSerializer.Serialize(new JsonStruct(Shablons), jsonSerializerOptions);
            //File.WriteAllText(pathStandartShablons, json);
        }

        #region ���� �������� ����������
        /// <summary>
        /// ������������� ��������� ����� ������� �������� � �����-������ ������
        /// </summary>
        private void EnableElements()
        {
            textbInputMask.Enabled = true;
            bChangeName.Enabled = true;
            bDeleteShablon.Enabled = true;
            checkbDateChange.Enabled = true;
            checkbDateCreate.Enabled = true;
            checkbSize.Enabled = true;
        }
        /// <summary>
        /// ��������� ������� json-������ � ��������� �, ���� ��� ����, ��������� standartShablons � Shablons, � ��������� ������ ������� ��������������
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
                    MessageBox.Show("���� �� ������������ ��������� ��� �������� ��� ����������� ��������! ���������� ������ � ������� ����� ��� ���� ��������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("���� �� ������������ ��������� ��� �����! ���������� ������ � ������� ����� ��� ���� ��������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("���� � ����������������� ��������� ��� �����! ���������� ������ � ������� ����� ��� ���� ��������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Filter filter = shablon.Filter;
            lName.Text = shablon.Name;
            textbInputMask.Text = filter.Mask;

            FillSize(filter);
            FillDateCreate(filter);
            FillDateChange(filter);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] korenAndMean = e.Node.FullPath.Split('\\');
            if (korenAndMean.Length == 1)
                return;

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

            DischangeEvent();
        }

        /// <summary>
        /// ������������ ���������, �������� �������������
        /// </summary>
        private void ChangeEvent()
        {
            if (!isChanged)
            {
                isChanged = true;
                bSave.Enabled = true;
                tempShablon = new Shablon(standartShablons[indexOfTreeView.Index2]);
            }
        }
        /// <summary>
        /// ��������� ������ ����������
        /// </summary>
        private void DischangeEvent()
        {
            tempShablon = null;
            isChanged = false;
            bSave.Enabled = false;
        }
        #region ��������� ������
        private void checkbSize_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            ChangeEvent();
            if (chb.Checked)
            {
                DisableSize();
            }
            else
            {
                EnableSize();
            }

            Filter filter = tempShablon.Filter;
            filter.HasSizeBitsInterval = !chb.Checked;
            tempShablon.Filter = filter;
        }

        private void numSize1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            ChangeEvent();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.Start = (long)num.Value;
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;

        }

        private void numSize2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            ChangeEvent();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.End = (long)num.Value;
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ChangeEvent();

            SizeInterval interval = tempShablon.Filter.SizeBitesInterval;
            interval.TypeSize = GetTypeSize(comboBox.Text);
            Filter filter = tempShablon.Filter;
            filter.SizeBitesInterval = interval;
            tempShablon.Filter = filter;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
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
            DischangeEvent();
        }

        private void checkbDateCreate_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            ChangeEvent();
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
        }

        private void datetCreate1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeEvent();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalCreate;
            dateTimeInterval.Start = dateTimePicker.Value;
            filter.DateTimeIntervalCreate = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void datetCreate2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeEvent();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalCreate;
            dateTimeInterval.End = dateTimePicker.Value;
            filter.DateTimeIntervalCreate = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void checkbDateChange_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            ChangeEvent();
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
        }

        private void datetChange1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeEvent();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalChange;
            dateTimeInterval.Start = dateTimePicker.Value;
            filter.DateTimeIntervalChange = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        private void datetChange2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            ChangeEvent();

            Filter filter = tempShablon.Filter;
            DateTimeInterval dateTimeInterval = filter.DateTimeIntervalChange;
            dateTimeInterval.End = dateTimePicker.Value;
            filter.DateTimeIntervalChange = dateTimeInterval;
            tempShablon.Filter = filter;
        }

        #endregion
    }
}