namespace tms_machines_base
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.machinesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.turretLabel = new System.Windows.Forms.Label();
            this.magazinLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.diametrLabel = new System.Windows.Forms.Label();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.catalogNumberLabel = new System.Windows.Forms.Label();
            this.firmLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.machinesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // machinesGrid
            // 
            this.machinesGrid.AllowUserToAddRows = false;
            this.machinesGrid.AllowUserToDeleteRows = false;
            this.machinesGrid.AllowUserToResizeColumns = false;
            this.machinesGrid.AllowUserToResizeRows = false;
            this.machinesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machinesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.machineName,
            this.machineModel});
            this.machinesGrid.Location = new System.Drawing.Point(6, 25);
            this.machinesGrid.MultiSelect = false;
            this.machinesGrid.Name = "machinesGrid";
            this.machinesGrid.ReadOnly = true;
            this.machinesGrid.RowHeadersVisible = false;
            this.machinesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.machinesGrid.Size = new System.Drawing.Size(351, 392);
            this.machinesGrid.TabIndex = 0;
            this.machinesGrid.CurrentCellChanged += new System.EventHandler(this.machinesGrid_CurrentCellChanged);
            this.machinesGrid.SelectionChanged += new System.EventHandler(this.machinesGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // machineName
            // 
            this.machineName.HeaderText = "Марка";
            this.machineName.Name = "machineName";
            this.machineName.ReadOnly = true;
            this.machineName.Width = 150;
            // 
            // machineModel
            // 
            this.machineModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machineModel.HeaderText = "Модель";
            this.machineModel.Name = "machineModel";
            this.machineModel.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.picture2);
            this.groupBox1.Controls.Add(this.picture1);
            this.groupBox1.Controls.Add(this.turretLabel);
            this.groupBox1.Controls.Add(this.magazinLabel);
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.diametrLabel);
            this.groupBox1.Controls.Add(this.machineIDLabel);
            this.groupBox1.Controls.Add(this.modelLabel);
            this.groupBox1.Controls.Add(this.catalogNumberLabel);
            this.groupBox1.Controls.Add(this.firmLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(381, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 541);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики станка";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // turretLabel
            // 
            this.turretLabel.AutoSize = true;
            this.turretLabel.Location = new System.Drawing.Point(158, 174);
            this.turretLabel.Name = "turretLabel";
            this.turretLabel.Size = new System.Drawing.Size(52, 16);
            this.turretLabel.TabIndex = 15;
            this.turretLabel.Text = "label16";
            // 
            // magazinLabel
            // 
            this.magazinLabel.AutoSize = true;
            this.magazinLabel.Location = new System.Drawing.Point(158, 154);
            this.magazinLabel.Name = "magazinLabel";
            this.magazinLabel.Size = new System.Drawing.Size(52, 16);
            this.magazinLabel.TabIndex = 14;
            this.magazinLabel.Text = "label15";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(158, 133);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(52, 16);
            this.lengthLabel.TabIndex = 13;
            this.lengthLabel.Text = "label14";
            // 
            // diametrLabel
            // 
            this.diametrLabel.AutoSize = true;
            this.diametrLabel.Location = new System.Drawing.Point(158, 112);
            this.diametrLabel.Name = "diametrLabel";
            this.diametrLabel.Size = new System.Drawing.Size(52, 16);
            this.diametrLabel.TabIndex = 12;
            this.diametrLabel.Text = "label13";
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Location = new System.Drawing.Point(158, 91);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(52, 16);
            this.machineIDLabel.TabIndex = 11;
            this.machineIDLabel.Text = "label12";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(158, 48);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 16);
            this.modelLabel.TabIndex = 10;
            this.modelLabel.Text = "label11";
            // 
            // catalogNumberLabel
            // 
            this.catalogNumberLabel.AutoSize = true;
            this.catalogNumberLabel.Location = new System.Drawing.Point(158, 69);
            this.catalogNumberLabel.Name = "catalogNumberLabel";
            this.catalogNumberLabel.Size = new System.Drawing.Size(52, 16);
            this.catalogNumberLabel.TabIndex = 9;
            this.catalogNumberLabel.Text = "label10";
            // 
            // firmLabel
            // 
            this.firmLabel.AutoSize = true;
            this.firmLabel.Location = new System.Drawing.Point(158, 28);
            this.firmLabel.Name = "firmLabel";
            this.firmLabel.Size = new System.Drawing.Size(45, 16);
            this.firmLabel.TabIndex = 8;
            this.firmLabel.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Револьверная \r\nголовка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Магазин:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Длина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Диаметр (max):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Код станка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер каталога:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.machinesGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 423);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список станков";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(10, 214);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(300, 300);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 16;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(326, 214);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(300, 300);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2.TabIndex = 17;
            this.picture2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Рисунок 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Рисунок 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 112);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтры поиска";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Длина";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Диаметр";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "от";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "от";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "База станков";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machinesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView machinesGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineModel;
        private Machine _currentMachine = new Machine();
        private MachineCharacteristic _currentMachineChar = new MachineCharacteristic();
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turretLabel;
        private System.Windows.Forms.Label magazinLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label diametrLabel;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label catalogNumberLabel;
        private System.Windows.Forms.Label firmLabel;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

