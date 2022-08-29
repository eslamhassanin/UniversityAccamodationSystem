
namespace UniversityAccamodationSystem
{
    partial class StudentDashboard
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnWriteFeedback = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStudent.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStudent.Location = new System.Drawing.Point(211, 332);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(214, 77);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnWriteFeedback
            // 
            this.btnWriteFeedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteFeedback.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWriteFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWriteFeedback.Location = new System.Drawing.Point(722, 332);
            this.btnWriteFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWriteFeedback.Name = "btnWriteFeedback";
            this.btnWriteFeedback.Size = new System.Drawing.Size(214, 77);
            this.btnWriteFeedback.TabIndex = 1;
            this.btnWriteFeedback.Text = "Write Feedback";
            this.btnWriteFeedback.UseVisualStyleBackColor = false;
            this.btnWriteFeedback.Click += new System.EventHandler(this.btnWriteFeedback_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewStatus.Location = new System.Drawing.Point(472, 332);
            this.btnViewStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(214, 77);
            this.btnViewStatus.TabIndex = 2;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(963, 332);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 77);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._12;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 241);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(143, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Student Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1336, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnWriteFeedback);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnWriteFeedback;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}