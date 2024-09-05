namespace GrifindoLeaveMS
{
    partial class ManageLeaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLeaves));
            this.dataGridDefineR = new System.Windows.Forms.DataGridView();
            this.btnreject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.grifindoLeaveMSDataSet4 = new GrifindoLeaveMS.GrifindoLeaveMSDataSet4();
            this.eApplyLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eApplyLeaveTableAdapter = new GrifindoLeaveMS.GrifindoLeaveMSDataSet4TableAdapters.EApplyLeaveTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApplyLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDefineR
            // 
            this.dataGridDefineR.AutoGenerateColumns = false;
            this.dataGridDefineR.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridDefineR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefineR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.leaveCategoryDataGridViewTextBoxColumn,
            this.leaveDateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridDefineR.DataSource = this.eApplyLeaveBindingSource;
            this.dataGridDefineR.Location = new System.Drawing.Point(101, 121);
            this.dataGridDefineR.Name = "dataGridDefineR";
            this.dataGridDefineR.RowHeadersWidth = 51;
            this.dataGridDefineR.RowTemplate.Height = 24;
            this.dataGridDefineR.Size = new System.Drawing.Size(904, 255);
            this.dataGridDefineR.TabIndex = 63;
            this.dataGridDefineR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefineR_CellContentClick);
            this.dataGridDefineR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDefineR_CellContentClick);
            // 
            // btnreject
            // 
            this.btnreject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnreject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreject.ForeColor = System.Drawing.SystemColors.Window;
            this.btnreject.Location = new System.Drawing.Point(613, 406);
            this.btnreject.Name = "btnreject";
            this.btnreject.Size = new System.Drawing.Size(127, 42);
            this.btnreject.TabIndex = 61;
            this.btnreject.Text = "Reject";
            this.btnreject.UseVisualStyleBackColor = false;
            this.btnreject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(205)))));
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.Window;
            this.btnApprove.Location = new System.Drawing.Point(423, 406);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(127, 42);
            this.btnApprove.TabIndex = 59;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 27);
            this.label6.TabIndex = 57;
            this.label6.Text = "Manage Leaves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Employee\'s Leave Table";
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
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(205)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Window;
            this.btnView.Location = new System.Drawing.Point(880, 399);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 49);
            this.btnView.TabIndex = 70;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "EmployeeID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpID.Location = new System.Drawing.Point(106, 414);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(229, 27);
            this.txtEmpID.TabIndex = 71;
            // 
            // grifindoLeaveMSDataSet4
            // 
            this.grifindoLeaveMSDataSet4.DataSetName = "GrifindoLeaveMSDataSet4";
            this.grifindoLeaveMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eApplyLeaveBindingSource
            // 
            this.eApplyLeaveBindingSource.DataMember = "EApplyLeave";
            this.eApplyLeaveBindingSource.DataSource = this.grifindoLeaveMSDataSet4;
            // 
            // eApplyLeaveTableAdapter
            // 
            this.eApplyLeaveTableAdapter.ClearBeforeFill = true;
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
            // ManageLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1080, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridDefineR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnreject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.label6);
            this.Name = "ManageLeaves";
            this.Text = "ManageLeaves";
            this.Load += new System.EventHandler(this.ManageLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApplyLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDefineR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnreject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private GrifindoLeaveMSDataSet4 grifindoLeaveMSDataSet4;
        private System.Windows.Forms.BindingSource eApplyLeaveBindingSource;
        private GrifindoLeaveMSDataSet4TableAdapters.EApplyLeaveTableAdapter eApplyLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
    }
}