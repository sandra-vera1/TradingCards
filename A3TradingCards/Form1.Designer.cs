namespace A3TradingCards
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
            components = new System.ComponentModel.Container();
            dataGridViewPlayers = new DataGridView();
            playerBindingSource = new BindingSource(components);
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_Name = new TextBox();
            label2 = new Label();
            textBoxSkills = new TextBox();
            label3 = new Label();
            textBoxNationality = new TextBox();
            label4 = new Label();
            textBoxGTAppearances = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerDOB = new DateTimePicker();
            listBoxTeams = new ListBox();
            btnUpdate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AllowUserToDeleteRows = false;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 493);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.RowHeadersWidth = 51;
            dataGridViewPlayers.Size = new Size(1078, 528);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tan;
            btnDelete.Location = new Point(981, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 48);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeletePlayer;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tan;
            btnAdd.Location = new Point(981, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 48);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += SaveNewPlayer;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(682, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 383);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += UploadPhoto;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(272, 62);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(252, 27);
            textBox_Name.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 98);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "DOB:";
            // 
            // textBoxSkills
            // 
            textBoxSkills.Location = new Point(274, 131);
            textBoxSkills.Name = "textBoxSkills";
            textBoxSkills.Size = new Size(252, 27);
            textBoxSkills.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 134);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 9;
            label3.Text = "Skills:";
            // 
            // textBoxNationality
            // 
            textBoxNationality.Location = new Point(274, 165);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(252, 27);
            textBoxNationality.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 168);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 11;
            label4.Text = "Nationality:";
            // 
            // textBoxGTAppearances
            // 
            textBoxGTAppearances.Location = new Point(274, 201);
            textBoxGTAppearances.Name = "textBoxGTAppearances";
            textBoxGTAppearances.Size = new Size(252, 27);
            textBoxGTAppearances.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 204);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 13;
            label5.Text = "Grand Tour Appearances:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 237);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 15;
            label6.Text = "Team Name:";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(274, 98);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(250, 27);
            dateTimePickerDOB.TabIndex = 17;
            // 
            // listBoxTeams
            // 
            listBoxTeams.FormattingEnabled = true;
            listBoxTeams.Location = new Point(274, 237);
            listBoxTeams.Name = "listBoxTeams";
            listBoxTeams.Size = new Size(252, 84);
            listBoxTeams.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Tan;
            btnUpdate.Location = new Point(981, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 48);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += UpdatePlayer;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(dateTimePickerDOB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBoxTeams);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxGTAppearances);
            panel1.Controls.Add(textBoxSkills);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxNationality);
            panel1.Location = new Point(17, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 367);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(12, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 414);
            panel2.TabIndex = 21;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tan;
            btnClear.Location = new Point(981, 73);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 48);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 1033);
            Controls.Add(btnClear);
            Controls.Add(panel2);
            Controls.Add(btnUpdate);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewPlayers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private BindingSource playerBindingSource;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox_Name;
        private Label label2;
        private TextBox textBoxSkills;
        private Label label3;
        private TextBox textBoxNationality;
        private Label label4;
        private TextBox textBoxGTAppearances;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerDOB;
        private ListBox listBoxTeams;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private Button btnClear;
    }
}
