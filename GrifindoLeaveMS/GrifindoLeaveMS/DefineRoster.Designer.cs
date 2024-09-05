namespace GrifindoLeaveMS
{
    partial class DefineRoster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineRoster));
            this.dataGridDefineR = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftRosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grifindoLeaveMSDataSet3 = new GrifindoLeaveMS.GrifindoLeaveMSDataSet3();
            this.btnUpdateShift = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.mtbStartTimeDR = new System.Windows.Forms.MaskedTextBox();
            this.mtbEndTimeDR = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shiftRosterTableAdapter = new GrifindoLeaveMS.GrifindoLeaveMSDataSet3TableAdapters.ShiftRosterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftRosterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDefineR
            // 
            this.dataGridDefineR.AutoGenerateColumns = false;
            this.dataGridDefineR.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridDefineR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDefineR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefineR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.shiftDateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridDefineR.DataSource = this.shiftRosterBindingSource;
            this.dataGridDefineR.Location = new System.Drawing.Point(174, 339);
            this.dataGridDefineR.Name = "dataGridDefineR";
            this.dataGridDefineR.RowHeadersWidth = 51;
            this.dataGridDefineR.RowTemplate.Height = 24;
            this.dataGridDefineR.Size = new System.Drawing.Size(737, 147);
            this.dataGridDefineR.TabIndex = 50;
            this.dataGridDefineR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefineR_CellContentClick);
            this.dataGridDefineR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefineR_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDateDataGridViewTextBoxColumn
            // 
            this.shiftDateDataGridViewTextBoxColumn.DataPropertyName = "ShiftDate";
            this.shiftDateDataGridViewTextBoxColumn.HeaderText = "ShiftDate";
            this.shiftDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDateDataGridViewTextBoxColumn.Name = "shiftDateDataGridViewTextBoxColumn";
            this.shiftDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftRosterBindingSource
            // 
            this.shiftRosterBindingSource.DataMember = "ShiftRoster";
            this.shiftRosterBindingSource.DataSource = this.grifindoLeaveMSDataSet3;
            // 
            // grifindoLeaveMSDataSet3
            // 
            this.grifindoLeaveMSDataSet3.DataSetName = "GrifindoLeaveMSDataSet3";
            this.grifindoLeaveMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdateShift
            // 
            this.btnUpdateShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(205)))));
            this.btnUpdateShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShift.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateShift.Location = new System.Drawing.Point(602, 274);
            this.btnUpdateShift.Name = "btnUpdateShift";
            this.btnUpdateShift.Size = new System.Drawing.Size(133, 50);
            this.btnUpdateShift.TabIndex = 48;
            this.btnUpdateShift.Text = "Update Shift";
            this.btnUpdateShift.UseVisualStyleBackColor = false;
            this.btnUpdateShift.Click += new System.EventHandler(this.btnUpdateShift_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date";
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(205)))));
            this.btnAddShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShift.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddShift.Location = new System.Drawing.Point(326, 274);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(133, 50);
            this.btnAddShift.TabIndex = 40;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDOB.Location = new System.Drawing.Point(102, 199);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(229, 22);
            this.datePickerDOB.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "Define Roster";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpID.Location = new System.Drawing.Point(102, 126);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(229, 27);
            this.txtEmpID.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Start Time";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 44);
            this.btnBack.TabIndex = 49;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mtbStartTimeDR
            // 
            this.mtbStartTimeDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbStartTimeDR.Location = new System.Drawing.Point(434, 201);
            this.mtbStartTimeDR.Name = "mtbStartTimeDR";
            this.mtbStartTimeDR.Size = new System.Drawing.Size(229, 22);
            this.mtbStartTimeDR.TabIndex = 57;
            // 
            // mtbEndTimeDR
            // 
            this.mtbEndTimeDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbEndTimeDR.Location = new System.Drawing.Point(744, 201);
            this.mtbEndTimeDR.Name = "mtbEndTimeDR";
            this.mtbEndTimeDR.Size = new System.Drawing.Size(229, 22);
            this.mtbEndTimeDR.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "EmployeeID:";
            // 
            // shiftRosterTableAdapter
            // 
            this.shiftRosterTableAdapter.ClearBeforeFill = true;
            // 
            // DefineRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1046, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbEndTimeDR);
            this.Controls.Add(this.mtbStartTimeDR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.dataGridDefineR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.datePickerDOB);
            this.Controls.Add(this.label1);
            this.Name = "DefineRoster";
            this.Text = "DefineRoster";
            this.Load += new System.EventHandler(this.DefineRoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftRosterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDefineR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateShift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.DateTimePicker datePickerDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbStartTimeDR;
        private System.Windows.Forms.MaskedTextBox mtbEndTimeDR;
        private System.Windows.Forms.Label label4;
        private GrifindoLeaveMSDataSet3 grifindoLeaveMSDataSet3;
        private System.Windows.Forms.BindingSource shiftRosterBindingSource;
        private GrifindoLeaveMSDataSet3TableAdapters.ShiftRosterTableAdapter shiftRosterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}