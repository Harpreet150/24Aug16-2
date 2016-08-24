namespace _24Aug16_2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbWheat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTurkey = new System.Windows.Forms.RadioButton();
            this.rbHam = new System.Windows.Forms.RadioButton();
            this.rbChicken = new System.Windows.Forms.RadioButton();
            this.lblRecap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWheat);
            this.groupBox1.Controls.Add(this.rbWhite);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bread";
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Checked = true;
            this.rbWhite.Location = new System.Drawing.Point(7, 20);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(53, 17);
            this.rbWhite.TabIndex = 0;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbWheat
            // 
            this.rbWheat.AutoSize = true;
            this.rbWheat.Location = new System.Drawing.Point(7, 43);
            this.rbWheat.Name = "rbWheat";
            this.rbWheat.Size = new System.Drawing.Size(57, 17);
            this.rbWheat.TabIndex = 0;
            this.rbWheat.Text = "Wheat";
            this.rbWheat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbChicken);
            this.groupBox2.Controls.Add(this.rbHam);
            this.groupBox2.Controls.Add(this.rbTurkey);
            this.groupBox2.Location = new System.Drawing.Point(149, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meat";
            // 
            // rbTurkey
            // 
            this.rbTurkey.AutoSize = true;
            this.rbTurkey.Location = new System.Drawing.Point(7, 20);
            this.rbTurkey.Name = "rbTurkey";
            this.rbTurkey.Size = new System.Drawing.Size(58, 17);
            this.rbTurkey.TabIndex = 0;
            this.rbTurkey.TabStop = true;
            this.rbTurkey.Text = "Turkey";
            this.rbTurkey.UseVisualStyleBackColor = true;
            this.rbTurkey.CheckedChanged += new System.EventHandler(this.rbTurkey_CheckedChanged);
            // 
            // rbHam
            // 
            this.rbHam.AutoSize = true;
            this.rbHam.Location = new System.Drawing.Point(7, 43);
            this.rbHam.Name = "rbHam";
            this.rbHam.Size = new System.Drawing.Size(47, 17);
            this.rbHam.TabIndex = 0;
            this.rbHam.TabStop = true;
            this.rbHam.Text = "Ham";
            this.rbHam.UseVisualStyleBackColor = true;
            this.rbHam.CheckedChanged += new System.EventHandler(this.rbHam_CheckedChanged);
            // 
            // rbChicken
            // 
            this.rbChicken.AutoSize = true;
            this.rbChicken.Location = new System.Drawing.Point(7, 66);
            this.rbChicken.Name = "rbChicken";
            this.rbChicken.Size = new System.Drawing.Size(64, 17);
            this.rbChicken.TabIndex = 0;
            this.rbChicken.TabStop = true;
            this.rbChicken.Text = "Chicken";
            this.rbChicken.UseVisualStyleBackColor = true;
            this.rbChicken.CheckedChanged += new System.EventHandler(this.rbChicken_CheckedChanged);
            // 
            // lblRecap
            // 
            this.lblRecap.AutoSize = true;
            this.lblRecap.Location = new System.Drawing.Point(13, 187);
            this.lblRecap.Name = "lblRecap";
            this.lblRecap.Size = new System.Drawing.Size(0, 13);
            this.lblRecap.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.Controls.Add(this.lblRecap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jimmy John\'s";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWheat;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbChicken;
        private System.Windows.Forms.RadioButton rbHam;
        private System.Windows.Forms.RadioButton rbTurkey;
        private System.Windows.Forms.Label lblRecap;
    }
}

