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

        private List<Shablon> standartShablons = new List<Shablon>();
        private List<Shablon> shablons = new List<Shablon>();
        private IndexOfTreeView indexOfTreeView = new IndexOfTreeView(0, 0);
        private Dictionary<string, int> indexesOfNodes = new Dictionary<string, int>();
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
                    shablons = JsonSerializer.Deserialize<List<Shablon>>(json);
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
                indexesOfNodes.Add(standartShablons[i].Name, i);
            }

            treeView1.Nodes[INDEX_OF_SHABLONS].Nodes.Clear();
            for (int i = 0; i < shablons.Count; i++)
            {
                treeView1.Nodes[INDEX_OF_SHABLONS].Nodes.Add(shablons[i].Name);
                indexesOfNodes.Add(shablons[i].Name, i);
            }
        }
        #endregion

        private void FillShablon(Shablon shablon)
        {
            Filter filter = shablon.Filter;
            lName.Text = shablon.Name;
            textbInputMask.Text = filter.Mask;

            FillSize(filter);
            FillDateCreate(filter);
            FillDateChange(filter);
        }

        private void checkbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbSize.Checked)
            {

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] korenAndMean = e.Node.FullPath.Split('\\');
            if (korenAndMean.Length == 1)
                return;

            indexOfTreeView.Index2 = indexesOfNodes[korenAndMean[1]];

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
        }
    }
}