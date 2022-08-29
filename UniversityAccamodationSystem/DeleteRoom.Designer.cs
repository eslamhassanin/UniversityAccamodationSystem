
namespace UniversityAccamodationSystem
{
    partial class DeleteRoom
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
            this.cmbRoomDelete = new System.Windows.Forms.ComboBox();
            this.cmbBlockDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(377, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Room Allocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(321, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(321, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block";
            // 
            // cmbRoomDelete
            // 
            this.cmbRoomDelete.FormattingEnabled = true;
            this.cmbRoomDelete.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbRoomDelete.Location = new System.Drawing.Point(468, 232);
            this.cmbRoomDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoomDelete.Name = "cmbRoomDelete";
            this.cmbRoomDelete.Size = new System.Drawing.Size(171, 33);
            this.cmbRoomDelete.TabIndex = 3;
            this.cmbRoomDelete.SelectedIndexChanged += new System.EventHandler(this.cmbRoomDelete_SelectedIndexChanged);
            // 
            // cmbBlockDelete
            // 
            this.cmbBlockDelete.FormattingEnabled = true;
            this.cmbBlockDelete.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbBlockDelete.Location = new System.Drawing.Point(468, 314);
            this.cmbBlockDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBlockDelete.Name = "cmbBlockDelete";
            this.cmbBlockDelete.Size = new System.Drawing.Size(171, 33);
            this.cmbBlockDelete.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(468, 412);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 57);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityAccamodationSystem.Properties.Resources._23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 738);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbBlockDelete);
            this.Controls.Add(this.cmbRoomDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteRoom";
            this.Text = "DeleteRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRoomDelete;
        private System.Windows.Forms.ComboBox cmbBlockDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}