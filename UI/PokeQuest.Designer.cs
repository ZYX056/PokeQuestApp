namespace PokeQuest
{
    partial class PokeQuestWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeQuestWindow));
            this.TrainerNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.TrainerNameOutputLabel = new System.Windows.Forms.Label();
            this.AgeOutputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TrainerNameLabel
            // 
            this.TrainerNameLabel.AutoSize = true;
            this.TrainerNameLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainerNameLabel.Location = new System.Drawing.Point(58, 42);
            this.TrainerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TrainerNameLabel.Name = "TrainerNameLabel";
            this.TrainerNameLabel.Size = new System.Drawing.Size(135, 24);
            this.TrainerNameLabel.TabIndex = 0;
            this.TrainerNameLabel.Text = "Trainer Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(58, 92);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(46, 24);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Age:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(428, 95);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(74, 24);
            this.GenderLabel.TabIndex = 2;
            this.GenderLabel.Text = "Gender:";
            // 
            // TrainerNameOutputLabel
            // 
            this.TrainerNameOutputLabel.AutoSize = true;
            this.TrainerNameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrainerNameOutputLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainerNameOutputLabel.Location = new System.Drawing.Point(205, 42);
            this.TrainerNameOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TrainerNameOutputLabel.Name = "TrainerNameOutputLabel";
            this.TrainerNameOutputLabel.Size = new System.Drawing.Size(2, 26);
            this.TrainerNameOutputLabel.TabIndex = 0;
            // 
            // AgeOutputLabel
            // 
            this.AgeOutputLabel.AutoSize = true;
            this.AgeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgeOutputLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeOutputLabel.Location = new System.Drawing.Point(116, 93);
            this.AgeOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AgeOutputLabel.Name = "AgeOutputLabel";
            this.AgeOutputLabel.Size = new System.Drawing.Size(2, 26);
            this.AgeOutputLabel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(205, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(116, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 30);
            this.textBox2.TabIndex = 2;
            // 
            // PokeQuestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 978);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AgeOutputLabel);
            this.Controls.Add(this.TrainerNameOutputLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.TrainerNameLabel);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PokeQuestWindow";
            this.Text = "PokeQuest";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainerNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label TrainerNameOutputLabel;
        private System.Windows.Forms.Label AgeOutputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

