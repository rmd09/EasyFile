namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Шаблоны по умолчанию");
            TreeNode treeNode2 = new TreeNode("Пользовательские шаблоны");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl = new TabControl();
            tabSorters = new TabPage();
            tabShablons = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            bNewShablon = new Button();
            treeView1 = new TreeView();
            splitContainer2 = new SplitContainer();
            lName = new Label();
            groupBox5 = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label6 = new Label();
            checkBox3 = new CheckBox();
            groupBox4 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            checkBox2 = new CheckBox();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl.SuspendLayout();
            tabShablons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSorters);
            tabControl.Controls.Add(tabShablons);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1242, 725);
            tabControl.TabIndex = 0;
            // 
            // tabSorters
            // 
            tabSorters.Location = new Point(4, 29);
            tabSorters.Name = "tabSorters";
            tabSorters.Padding = new Padding(3);
            tabSorters.Size = new Size(1234, 692);
            tabSorters.TabIndex = 0;
            tabSorters.Text = "Сортировки";
            tabSorters.UseVisualStyleBackColor = true;
            // 
            // tabShablons
            // 
            tabShablons.Controls.Add(splitContainer1);
            tabShablons.Location = new Point(4, 29);
            tabShablons.Name = "tabShablons";
            tabShablons.Padding = new Padding(3);
            tabShablons.Size = new Size(1234, 692);
            tabShablons.TabIndex = 1;
            tabShablons.Text = "Шаблоны";
            tabShablons.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(1228, 686);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bNewShablon);
            groupBox1.Controls.Add(treeView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 682);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список шаблонов";
            // 
            // bNewShablon
            // 
            bNewShablon.BackColor = Color.White;
            bNewShablon.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bNewShablon.Location = new Point(6, 622);
            bNewShablon.Name = "bNewShablon";
            bNewShablon.Size = new Size(275, 54);
            bNewShablon.TabIndex = 2;
            bNewShablon.Text = "Новый шаблон";
            bNewShablon.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.Location = new Point(3, 30);
            treeView1.Name = "treeView1";
            treeNode1.Name = "ShablonsStandart";
            treeNode1.Text = "Шаблоны по умолчанию";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Пользовательские шаблоны";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            treeView1.Size = new Size(281, 586);
            treeView1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lName);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(groupBox5);
            splitContainer2.Panel2.Controls.Add(groupBox4);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Panel2.Controls.Add(groupBox3);
            splitContainer2.Size = new Size(933, 686);
            splitContainer2.SplitterDistance = 80;
            splitContainer2.TabIndex = 0;
            // 
            // lName
            // 
            lName.Dock = DockStyle.Fill;
            lName.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lName.Location = new Point(0, 0);
            lName.Name = "lName";
            lName.Size = new Size(929, 76);
            lName.TabIndex = 15;
            lName.Text = "Новый шаблон";
            lName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker3);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(dateTimePicker4);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(checkBox3);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 358);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(929, 131);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Дата редактирования";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Location = new Point(371, 56);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 38);
            dateTimePicker3.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(323, 60);
            label5.Name = "label5";
            label5.Size = new Size(40, 31);
            label5.TabIndex = 25;
            label5.Text = "по";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker4.Location = new Point(59, 56);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 38);
            dateTimePicker4.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 60);
            label6.Name = "label6";
            label6.Size = new Size(25, 31);
            label6.TabIndex = 23;
            label6.Text = "с";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(758, 57);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(159, 35);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Любая дата";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dateTimePicker2);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 227);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(929, 131);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дата создания";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(371, 56);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 38);
            dateTimePicker2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(323, 60);
            label4.Name = "label4";
            label4.Size = new Size(40, 31);
            label4.TabIndex = 25;
            label4.Text = "по";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(59, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 38);
            dateTimePicker1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(25, 31);
            label2.TabIndex = 23;
            label2.Text = "с";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(758, 57);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(159, 35);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Любая дата";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(929, 125);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Размер";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(724, 58);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(193, 35);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Любой размер";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Гб", "Мб", "Кб", "Байт" });
            comboBox1.Location = new Point(391, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 39);
            comboBox1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(247, 56);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(118, 38);
            numericUpDown2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(192, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 31);
            label1.TabIndex = 18;
            label1.Text = "до";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(59, 56);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(118, 38);
            numericUpDown1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 58);
            label3.Name = "label3";
            label3.Size = new Size(36, 31);
            label3.TabIndex = 16;
            label3.Text = "от";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(929, 102);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Маска";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(3, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(923, 48);
            textBox1.TabIndex = 0;
            textBox1.Text = "Введите маску";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 522);
            button1.Name = "button1";
            button1.Size = new Size(267, 49);
            button1.TabIndex = 22;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(650, 522);
            button2.Name = "button2";
            button2.Size = new Size(267, 49);
            button2.TabIndex = 23;
            button2.Text = "Удалить шаблон";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(327, 522);
            button3.Name = "button3";
            button3.Size = new Size(267, 49);
            button3.TabIndex = 24;
            button3.Text = "Изменить название";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 725);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabShablons.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabSorters;
        private TabPage tabShablons;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TreeView treeView1;
        private Button bNewShablon;
        private SplitContainer splitContainer2;
        private Label lName;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox5;
        private DateTimePicker dateTimePicker3;
        private Label label5;
        private DateTimePicker dateTimePicker4;
        private Label label6;
        private CheckBox checkBox3;
        private GroupBox groupBox4;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private CheckBox checkBox2;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}