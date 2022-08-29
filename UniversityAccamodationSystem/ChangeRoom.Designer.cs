
namespace UniversityAccamodationSystem
{
    partial class ChangeRoom
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
            this.cmbRoomFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBlockFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBlockTo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoomTo = new System.Windows.Forms.ComboBox();
            this.btnchangeRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 115);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // cmbRoomFrom
            // 
            this.cmbRoomFrom.FormattingEnabled = true;
            this.cmbRoomFrom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbRoomFrom.Location = new System.Drawing.Point(205, 181);
            this.cmbRoomFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoomFrom.Name = "cmbRoomFrom";
            this.cmbRoomFrom.Size = new System.Drawing.Size(164, 33);
            this.cmbRoomFrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(89, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(89, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Block";
            // 
            // cmbBlockFrom
            // 
            this.cmbBlockFrom.FormattingEnabled = true;
            this.cmbBlockFrom.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbBlockFrom.Location = new System.Drawing.Point(205, 229);
            this.cmbBlockFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBlockFrom.Name = "cmbBlockFrom";
            this.cmbBlockFrom.Size = new System.Drawing.Size(164, 33);
            this.cmbBlockFrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(89, 516);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Block";
            // 
            // cmbBlockTo
            // 
            this.cmbBlockTo.FormattingEnabled = true;
            this.cmbBlockTo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbBlockTo.Location = new System.Drawing.Point(205, 522);
            this.cmbBlockTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBlockTo.Name = "cmbBlockTo";
            this.cmbBlockTo.Size = new System.Drawing.Size(164, 33);
            this.cmbBlockTo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(89, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room#";
            // 
            // cmbRoomTo
            // 
            this.cmbRoomTo.FormattingEnabled = true;
            this.cmbRoomTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbRoomTo.Location = new System.Drawing.Point(205, 473);
            this.cmbRoomTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoomTo.Name = "cmbRoomTo";
            this.cmbRoomTo.Size = new System.Drawing.Size(164, 33);
            this.cmbRoomTo.TabIndex = 6;
            // 
            // btnchangeRoom
            // 
            this.btnchangeRoom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnchangeRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchangeRoom.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnchangeRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnchangeRoom.Location = new System.Drawing.Point(169, 604);
            this.btnchangeRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnchangeRoom.Name = "btnchangeRoom";
            this.btnchangeRoom.Size = new System.Drawing.Size(200, 74);
            this.btnchangeRoom.TabIndex = 10;
            this.btnchangeRoom.Text = "Change";
            this.btnchangeRoom.UseVisualStyleBackColor = false;
            this.btnchangeRoom.Click += new System.EventHandler(this.btnchangeRoom_Click);
            // 
            // ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._1_YESLA1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 721);
            this.Controls.Add(this.btnchangeRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBlockTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRoomTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBlockFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRoomFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeRoom";
            this.Text = "ChangeRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBlockFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBlockTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoomTo;
        private System.Windows.Forms.Button btnchangeRoom;
    }
}