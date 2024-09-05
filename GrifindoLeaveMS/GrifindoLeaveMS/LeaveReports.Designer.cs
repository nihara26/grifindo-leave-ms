namespace GrifindoLeaveMS
{
    partial class LeaveReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveReports));
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearchEmpID = new System.Windows.Forms.TextBox();
            this.dataGridDefineR = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePickerStartLR = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimePickerEndDateLR = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.grifindoLeaveMSDataSet5 = new GrifindoLeaveMS.GrifindoLeaveMSDataSet5();
            this.leaveHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveHistoryTableAdapter = new GrifindoLeaveMS.GrifindoLeaveMSDataSet5TableAdapters.LeaveHistoryTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Search Emp.ID";
            // 
            // txtsearchEmpID
            // 
            this.txtsearchEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchEmpID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsearchEmpID.Location = new System.Drawing.Point(96, 129);
            this.txtsearchEmpID.Name = "txtsearchEmpID";
            this.txtsearchEmpID.Size = new System.Drawing.Size(229, 27);
            this.txtsearchEmpID.TabIndex = 64;
            // 
            // dataGridDefineR
            // 
            this.dataGridDefineR.AutoGenerateColumns = false;
            this.dataGridDefineR.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridDefineR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDefineR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefineR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.leaveCategoryDataGridViewTextBoxColumn,
            this.leaveDateDataGridViewTextBoxColumn,
            this.actionDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridDefineR.DataSource = this.leaveHistoryBindingSource;
            this.dataGridDefineR.Location = new System.Drawing.Point(96, 285);
            this.dataGridDefineR.Name = "dataGridDefineR";
            this.dataGridDefineR.RowHeadersWidth = 51;
            this.dataGridDefineR.RowTemplate.Height = 24;
            this.dataGridDefineR.Size = new System.Drawing.Size(902, 203);
            this.dataGridDefineR.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Start Date";
            // 
            // TimePickerStartLR
            // 
            this.TimePickerStartLR.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerStartLR.Location = new System.Drawing.Point(96, 201);
            this.TimePickerStartLR.Name = "TimePickerStartLR";
            this.TimePickerStartLR.Size = new System.Drawing.Size(229, 22);
            this.TimePickerStartLR.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "Leave Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "End Date";
            // 
            // TimePickerEndDateLR
            // 
            this.TimePickerEndDateLR.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerEndDateLR.Location = new System.Drawing.Point(424, 201);
            this.TimePickerEndDateLR.Name = "TimePickerEndDateLR";
            this.TimePickerEndDateLR.Size = new System.Drawing.Size(229, 22);
            this.TimePickerEndDateLR.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Leave History Table";
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
            this.btnBack.TabIndex = 62;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(205)))));
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewAll.Location = new System.Drawing.Point(859, 225);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(121, 42);
            this.btnViewAll.TabIndex = 69;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // grifindoLeaveMSDataSet5
            // 
            this.grifindoLeaveMSDataSet5.DataSetName = "GrifindoLeaveMSDataSet5";
            this.grifindoLeaveMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveHistoryBindingSource
            // 
            this.leaveHistoryBindingSource.DataMember = "LeaveHistory";
            this.leaveHistoryBindingSource.DataSource = this.grifindoLeaveMSDataSet5;
            // 
            // leaveHistoryTableAdapter
            // 
            this.leaveHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveCategoryDataGridViewTextBoxColumn
            // 
            this.leaveCategoryDataGridViewTextBoxColumn.DataPropertyName = "LeaveCategory";
            this.leaveCategoryDataGridViewTextBoxColumn.HeaderText = "LeaveCategory";
            this.leaveCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveCategoryDataGridViewTextBoxColumn.Name = "leaveCategoryDataGridViewTextBoxColumn";
            this.leaveCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveDateDataGridViewTextBoxColumn
            // 
            this.leaveDateDataGridViewTextBoxColumn.DataPropertyName = "LeaveDate";
            this.leaveDateDataGridViewTextBoxColumn.HeaderText = "LeaveDate";
            this.leaveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveDateDataGridViewTextBoxColumn.Name = "leaveDateDataGridViewTextBoxColumn";
            this.leaveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // actionDateDataGridViewTextBoxColumn
            // 
            this.actionDateDataGridViewTextBoxColumn.DataPropertyName = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.HeaderText = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actionDateDataGridViewTextBoxColumn.Name = "actionDateDataGridViewTextBoxColumn";
            this.actionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // LeaveReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1044, 534);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimePickerEndDateLR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsearchEmpID);
            this.Controls.Add(this.dataGridDefineR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimePickerStartLR);
            this.Controls.Add(this.label1);
            this.Name = "LeaveReports";
            this.Text = "LeaveReports";
            this.Load += new System.EventHandler(this.LeaveReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearchEmpID;
        private System.Windows.Forms.DataGridView dataGridDefineR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePickerStartLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimePickerEndDateLR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewAll;
        private GrifindoLeaveMSDataSet5 grifindoLeaveMSDataSet5;
        private System.Windows.Forms.BindingSource leaveHistoryBindingSource;
        private GrifindoLeaveMSDataSet5TableAdapters.LeaveHistoryTableAdapter leaveHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}