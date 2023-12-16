using System.Windows.Forms.Design;

namespace Interface
{
    public partial class FormForPath : Form
    {
        private PathHelpClass pathHelpStruct;
        private bool isPathMainCorect = false;
        private bool isPathFinalCorect = false;

        public FormForPath(PathHelpClass pathHelpStruct)
        {
            InitializeComponent();

            this.pathHelpStruct = pathHelpStruct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = GetPathWithDialog();
            if (path == null)
            {
                MessageBox.Show("Путь не выбран!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox1.Text = path;
            pathHelpStruct.PathMain = path;
            isPathMainCorect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = GetPathWithDialog();
            if (path == null)
            {
                MessageBox.Show("Путь не выбран!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox2.Text = path;
            pathHelpStruct.PathFinal = path;
            isPathFinalCorect = true;
        }

        public string GetPathWithDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isPathFinalCorect && isPathMainCorect)
            {
                pathHelpStruct.isOK = true;
                pathHelpStruct.CutSortedFiles = checkCut.Checked;
                pathHelpStruct.SortAllSubdirictories = checkSubdirictories.Checked;
                Close();
            }
            else if (!isPathMainCorect)
            {
                MessageBox.Show("Путь к начальной папки указан неправильно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isPathFinalCorect)
            {
                MessageBox.Show("Путь к конечной папки указан неправильно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isPathMainCorect = Directory.Exists(textBox1.Text);
            if (isPathMainCorect)
            {
                pathHelpStruct.PathMain = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isPathFinalCorect = Directory.Exists(textBox2.Text);
            if (isPathFinalCorect)
            {
                pathHelpStruct.PathFinal = textBox2.Text;
            }
        }
    }
}
