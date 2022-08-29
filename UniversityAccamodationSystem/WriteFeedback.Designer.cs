
namespace UniversityAccamodationSystem
{
    partial class WriteFeedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textstdID = new System.Windows.Forms.TextBox();
            this.cmbRequest = new System.Windows.Forms.ComboBox();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write Feedback";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Request";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // textstdID
            // 
            this.textstdID.Location = new System.Drawing.Point(163, 129);
            this.textstdID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textstdID.Name = "textstdID";
            this.textstdID.Size = new System.Drawing.Size(231, 31);
            this.textstdID.TabIndex = 4;
            this.textstdID.TextChanged += new System.EventHandler(this.textstdID_TextChanged);
            // 
            // cmbRequest
            // 
            this.cmbRequest.FormattingEnabled = true;
            this.cmbRequest.Items.AddRange(new object[] {
            "Need New Room",
            "Change Room",
            "Terminate Room"});
            this.cmbRequest.Location = new System.Drawing.Point(162, 200);
            this.cmbRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRequest.Name = "cmbRequest";
            this.cmbRequest.Size = new System.Drawing.Size(231, 33);
            this.cmbRequest.TabIndex = 5;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(20, 342);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(299, 309);
            this.textDescription.TabIndex = 6;
            this.textDescription.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPost.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPost.Location = new System.Drawing.Point(20, 661);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(156, 58);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // WriteFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._1_YESLA3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 733);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.cmbRequest);
            this.Controls.Add(this.textstdID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WriteFeedback";
            this.Text = "WriteFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textstdID;
        private System.Windows.Forms.ComboBox cmbRequest;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Button btnPost;
    }
}