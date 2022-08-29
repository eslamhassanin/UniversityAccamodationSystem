
namespace UniversityAccamodationSystem
{
    partial class ViewReport
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
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 150;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 150;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeight = 34;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.stdName,
            this.strtDate,
            this.eDate,
            this.RoomStatus});
            this.dgvFeedback.Location = new System.Drawing.Point(40, 20);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 62;
            this.dgvFeedback.RowTemplate.Height = 25;
            this.dgvFeedback.Size = new System.Drawing.Size(847, 540);
            this.dgvFeedback.TabIndex = 2;
            this.dgvFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // stdName
            // 
            this.stdName.FillWeight = 150F;
            this.stdName.HeaderText = "Student Name";
            this.stdName.MinimumWidth = 8;
            this.stdName.Name = "stdName";
            this.stdName.Width = 150;
            // 
            // strtDate
            // 
            this.strtDate.HeaderText = "Start Date";
            this.strtDate.MinimumWidth = 8;
            this.strtDate.Name = "strtDate";
            this.strtDate.Width = 150;
            // 
            // eDate
            // 
            this.eDate.HeaderText = "End Date";
            this.eDate.MinimumWidth = 8;
            this.eDate.Name = "eDate";
            this.eDate.Width = 150;
            // 
            // RoomStatus
            // 
            this.RoomStatus.HeaderText = "Room Status";
            this.RoomStatus.MinimumWidth = 8;
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.Width = 150;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 585);
            this.Controls.Add(this.dgvFeedback);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn strtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
    }
}