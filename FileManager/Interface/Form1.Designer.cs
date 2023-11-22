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
            bChangeName = new Button();
            bDeleteShablon = new Button();
            bSave = new Button();
            groupBox5 = new GroupBox();
            datetChange2 = new DateTimePicker();
            label5 = new Label();
            datetChange1 = new DateTimePicker();
            label6 = new Label();
            checkbDateChange = new CheckBox();
            groupBox4 = new GroupBox();
            datetCreate2 = new DateTimePicker();
            label4 = new Label();
            datetCreate1 = new DateTimePicker();
            label2 = new Label();
            checkbDateCreate = new CheckBox();
            groupBox2 = new GroupBox();
            checkbSize = new CheckBox();
            comboSize = new ComboBox();
            numSize2 = new NumericUpDown();
            groupBox3 = new GroupBox();
            textbInputMask = new TextBox();
            label1 = new Label();
            numSize1 = new NumericUpDown();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)numSize2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSize1).BeginInit();
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
            treeNode1.Name = "Шаьлоны по умолчанию";
            treeNode1.Text = "Шаблоны по умолчанию";
            treeNode2.Name = "Пользовательские шаблоны";
            treeNode2.Text = "Пользовательские шаблоны";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            treeView1.Size = new Size(281, 586);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
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
            splitContainer2.Panel2.Controls.Add(bChangeName);
            splitContainer2.Panel2.Controls.Add(bDeleteShablon);
            splitContainer2.Panel2.Controls.Add(bSave);
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
            // bChangeName
            // 
            bChangeName.BackColor = Color.WhiteSmoke;
            bChangeName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bChangeName.Location = new Point(327, 522);
            bChangeName.Name = "bChangeName";
            bChangeName.Size = new Size(267, 49);
            bChangeName.TabIndex = 24;
            bChangeName.Text = "Изменить название";
            bChangeName.UseVisualStyleBackColor = false;
            // 
            // bDeleteShablon
            // 
            bDeleteShablon.BackColor = Color.WhiteSmoke;
            bDeleteShablon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bDeleteShablon.Location = new Point(650, 522);
            bDeleteShablon.Name = "bDeleteShablon";
            bDeleteShablon.Size = new Size(267, 49);
            bDeleteShablon.TabIndex = 23;
            bDeleteShablon.Text = "Удалить шаблон";
            bDeleteShablon.UseVisualStyleBackColor = false;
            // 
            // bSave
            // 
            bSave.BackColor = Color.WhiteSmoke;
            bSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bSave.Location = new Point(9, 522);
            bSave.Name = "bSave";
            bSave.Size = new Size(267, 49);
            bSave.TabIndex = 22;
            bSave.Text = "Сохранить";
            bSave.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(datetChange2);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(datetChange1);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(checkbDateChange);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 358);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(929, 131);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Дата редактирования";
            // 
            // datetChange2
            // 
            datetChange2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datetChange2.Location = new Point(371, 56);
            datetChange2.Name = "datetChange2";
            datetChange2.Size = new Size(250, 38);
            datetChange2.TabIndex = 26;
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
            // datetChange1
            // 
            datetChange1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datetChange1.Location = new Point(59, 56);
            datetChange1.Name = "datetChange1";
            datetChange1.Size = new Size(250, 38);
            datetChange1.TabIndex = 24;
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
            // checkbDateChange
            // 
            checkbDateChange.AutoSize = true;
            checkbDateChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkbDateChange.Location = new Point(758, 57);
            checkbDateChange.Name = "checkbDateChange";
            checkbDateChange.Size = new Size(159, 35);
            checkbDateChange.TabIndex = 22;
            checkbDateChange.Text = "Любая дата";
            checkbDateChange.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(datetCreate2);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(datetCreate1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(checkbDateCreate);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 227);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(929, 131);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дата создания";
            // 
            // datetCreate2
            // 
            datetCreate2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datetCreate2.Location = new Point(371, 56);
            datetCreate2.Name = "datetCreate2";
            datetCreate2.Size = new Size(250, 38);
            datetCreate2.TabIndex = 26;
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
            // datetCreate1
            // 
            datetCreate1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datetCreate1.Location = new Point(59, 56);
            datetCreate1.Name = "datetCreate1";
            datetCreate1.Size = new Size(250, 38);
            datetCreate1.TabIndex = 24;
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
            // checkbDateCreate
            // 
            checkbDateCreate.AutoSize = true;
            checkbDateCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkbDateCreate.Location = new Point(758, 57);
            checkbDateCreate.Name = "checkbDateCreate";
            checkbDateCreate.Size = new Size(159, 35);
            checkbDateCreate.TabIndex = 22;
            checkbDateCreate.Text = "Любая дата";
            checkbDateCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkbSize);
            groupBox2.Controls.Add(comboSize);
            groupBox2.Controls.Add(numSize2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numSize1);
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
            // checkbSize
            // 
            checkbSize.AutoSize = true;
            checkbSize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkbSize.Location = new Point(724, 58);
            checkbSize.Name = "checkbSize";
            checkbSize.Size = new Size(193, 35);
            checkbSize.TabIndex = 21;
            checkbSize.Text = "Любой размер";
            checkbSize.UseVisualStyleBackColor = true;
            checkbSize.CheckedChanged += checkbSize_CheckedChanged;
            // 
            // comboSize
            // 
            comboSize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboSize.FormattingEnabled = true;
            comboSize.Items.AddRange(new object[] { "Гб", "Мб", "Кб", "Байт" });
            comboSize.Location = new Point(391, 55);
            comboSize.Name = "comboSize";
            comboSize.Size = new Size(151, 39);
            comboSize.TabIndex = 20;
            // 
            // numSize2
            // 
            numSize2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numSize2.Location = new Point(247, 56);
            numSize2.Name = "numSize2";
            numSize2.Size = new Size(118, 38);
            numSize2.TabIndex = 19;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textbInputMask);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(929, 102);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Маска";
            // 
            // textbInputMask
            // 
            textbInputMask.BorderStyle = BorderStyle.None;
            textbInputMask.Dock = DockStyle.Bottom;
            textbInputMask.ForeColor = SystemColors.ControlText;
            textbInputMask.Location = new Point(3, 51);
            textbInputMask.Multiline = true;
            textbInputMask.Name = "textbInputMask";
            textbInputMask.Size = new Size(923, 48);
            textbInputMask.TabIndex = 0;
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
            // numSize1
            // 
            numSize1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numSize1.Location = new Point(59, 56);
            numSize1.Name = "numSize1";
            numSize1.Size = new Size(118, 38);
            numSize1.TabIndex = 17;
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
            ((System.ComponentModel.ISupportInitialize)numSize2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSize1).EndInit();
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
        private TextBox textbInputMask;
        private GroupBox groupBox2;
        private NumericUpDown numSize2;
        private ComboBox comboSize;
        private CheckBox checkbSize;
        private GroupBox groupBox5;
        private DateTimePicker datetChange2;
        private Label label5;
        private DateTimePicker datetChange1;
        private Label label6;
        private CheckBox checkbDateChange;
        private GroupBox groupBox4;
        private DateTimePicker datetCreate2;
        private Label label4;
        private DateTimePicker datetCreate1;
        private Label label2;
        private CheckBox checkbDateCreate;
        private Button bChangeName;
        private Button bDeleteShablon;
        private Button bSave;
        private Label label1;
        private NumericUpDown numSize1;
        private Label label3;
    }
}