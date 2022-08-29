
namespace UniversityAccamodationSystem
{
    partial class ViewFeedbackstatus
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
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFeedback.ColumnHeadersHeight = 34;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Request,
            this.Description,
            this.Status});
            this.dgvFeedback.Location = new System.Drawing.Point(17, 20);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 62;
            this.dgvFeedback.RowTemplate.Height = 25;
            this.dgvFeedback.Size = new System.Drawing.Size(1077, 558);
            this.dgvFeedback.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 150;
            // 
            // Request
            // 
            this.Request.FillWeight = 150F;
            this.Request.HeaderText = "Request";
            this.Request.MinimumWidth = 8;
            this.Request.Name = "Request";
            this.Request.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 350;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // ViewFeedbackstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 592);
            this.Controls.Add(this.dgvFeedback);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewFeedbackstatus";
            this.Text = "ViewFeedbackstatus";
            this.Load += new System.EventHandler(this.ViewFeedbackstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}