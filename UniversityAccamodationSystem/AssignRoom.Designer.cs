
namespace UniversityAccamodationSystem
{
    partial class AssignRoom
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
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.textStdID = new System.Windows.Forms.TextBox();
            this.textStdName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(108, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(108, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Block";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(108, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "TP Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(108, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Name";
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbRoomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbRoomNo.Location = new System.Drawing.Point(356, 134);
            this.cmbRoomNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(372, 38);
            this.cmbRoomNo.TabIndex = 4;
            this.cmbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNo_SelectedIndexChanged);
            // 
            // cmbBlock
            // 
            this.cmbBlock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbBlock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbBlock.FormattingEnabled = true;
            this.cmbBlock.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbBlock.Location = new System.Drawing.Point(356, 216);
            this.cmbBlock.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(372, 38);
            this.cmbBlock.TabIndex = 5;
            // 
            // textStdID
            // 
            this.textStdID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textStdID.Cursor = System.Windows.Forms.Cursors.No;
            this.textStdID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textStdID.Location = new System.Drawing.Point(356, 318);
            this.textStdID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textStdID.Name = "textStdID";
            this.textStdID.Size = new System.Drawing.Size(372, 35);
            this.textStdID.TabIndex = 6;
            // 
            // textStdName
            // 
            this.textStdName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textStdName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textStdName.Location = new System.Drawing.Point(356, 426);
            this.textStdName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textStdName.Name = "textStdName";
            this.textStdName.Size = new System.Drawing.Size(372, 35);
            this.textStdName.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(287, 667);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 72);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(356, 519);
            this.startdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(372, 35);
            this.startdate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(108, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(108, 612);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date";
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(356, 607);
            this.enddate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(372, 35);
            this.enddate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(108, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(857, 53);
            this.label7.TabIndex = 13;
            this.label7.Text = "Assign Room | Register for the Upcoming Student";
            // 
            // AssignRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._1_YESLA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1560, 754);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textStdName);
            this.Controls.Add(this.textStdID);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AssignRoom";
            this.Text = "AssignRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.TextBox textStdID;
        private System.Windows.Forms.TextBox textStdName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label7;
    }
}