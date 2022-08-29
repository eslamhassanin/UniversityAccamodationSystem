
namespace UniversityAccamodationSystem
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
            this.btnWarden = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarden
            // 
            this.btnWarden.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnWarden.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWarden.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnWarden.Image = global::UniversityAccamodationSystem.Properties.Resources._21;
            this.btnWarden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWarden.Location = new System.Drawing.Point(436, 161);
            this.btnWarden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWarden.Name = "btnWarden";
            this.btnWarden.Size = new System.Drawing.Size(247, 72);
            this.btnWarden.TabIndex = 0;
            this.btnWarden.Text = "Warden";
            this.btnWarden.UseVisualStyleBackColor = false;
            this.btnWarden.Click += new System.EventHandler(this.btnWarden_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudent.Image = global::UniversityAccamodationSystem.Properties.Resources._21;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudent.Location = new System.Drawing.Point(436, 286);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(247, 72);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "University Accomodation System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = global::UniversityAccamodationSystem.Properties.Resources._21;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(436, 410);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(247, 72);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 737);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnWarden);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWarden;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

