namespace PokeQuest
{
    partial class PokeQuestForm
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
            this.TrainerNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.TrainerNameOutputLabel = new System.Windows.Forms.Label();
            this.AgeOutputLabel = new System.Windows.Forms.Label();
            this.GenderOutputLabel = new System.Windows.Forms.Label();
            this.TrainerNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.SubmitTrainerBtn = new System.Windows.Forms.Button();
            this.TrainerDescriptionLabel = new System.Windows.Forms.Label();
            this.TrainerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TrainerNameLabel
            // 
            this.TrainerNameLabel.AutoSize = true;
            this.TrainerNameLabel.Location = new System.Drawing.Point(32, 25);
            this.TrainerNameLabel.Name = "TrainerNameLabel";
            this.TrainerNameLabel.Size = new System.Drawing.Size(74, 13);
            this.TrainerNameLabel.TabIndex = 0;
            this.TrainerNameLabel.Text = "Trainer Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(32, 55);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 13);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Age:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(32, 86);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 13);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Gender:";
            // 
            // TrainerNameOutputLabel
            // 
            this.TrainerNameOutputLabel.AutoSize = true;
            this.TrainerNameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrainerNameOutputLabel.Location = new System.Drawing.Point(112, 25);
            this.TrainerNameOutputLabel.Name = "TrainerNameOutputLabel";
            this.TrainerNameOutputLabel.Size = new System.Drawing.Size(2, 15);
            this.TrainerNameOutputLabel.TabIndex = 0;
            // 
            // AgeOutputLabel
            // 
            this.AgeOutputLabel.AutoSize = true;
            this.AgeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgeOutputLabel.Location = new System.Drawing.Point(67, 55);
            this.AgeOutputLabel.Name = "AgeOutputLabel";
            this.AgeOutputLabel.Size = new System.Drawing.Size(2, 15);
            this.AgeOutputLabel.TabIndex = 0;
            // 
            // GenderOutputLabel
            // 
            this.GenderOutputLabel.AutoSize = true;
            this.GenderOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GenderOutputLabel.Location = new System.Drawing.Point(83, 84);
            this.GenderOutputLabel.Name = "GenderOutputLabel";
            this.GenderOutputLabel.Size = new System.Drawing.Size(2, 15);
            this.GenderOutputLabel.TabIndex = 0;
            // 
            // TrainerNameTextBox
            // 
            this.TrainerNameTextBox.Location = new System.Drawing.Point(112, 20);
            this.TrainerNameTextBox.Name = "TrainerNameTextBox";
            this.TrainerNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.TrainerNameTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(67, 52);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(92, 20);
            this.AgeTextBox.TabIndex = 2;
            // 
            // SubmitTrainerBtn
            // 
            this.SubmitTrainerBtn.Location = new System.Drawing.Point(392, 20);
            this.SubmitTrainerBtn.Name = "SubmitTrainerBtn";
            this.SubmitTrainerBtn.Size = new System.Drawing.Size(100, 47);
            this.SubmitTrainerBtn.TabIndex = 3;
            this.SubmitTrainerBtn.Text = "Submit Trainer Information";
            this.SubmitTrainerBtn.UseVisualStyleBackColor = true;
            // 
            // TrainerDescriptionLabel
            // 
            this.TrainerDescriptionLabel.AutoSize = true;
            this.TrainerDescriptionLabel.Location = new System.Drawing.Point(32, 111);
            this.TrainerDescriptionLabel.Name = "TrainerDescriptionLabel";
            this.TrainerDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.TrainerDescriptionLabel.TabIndex = 4;
            this.TrainerDescriptionLabel.Text = "Trainer Description";
            // 
            // TrainerDescriptionTextBox
            // 
            this.TrainerDescriptionTextBox.Location = new System.Drawing.Point(35, 127);
            this.TrainerDescriptionTextBox.Name = "TrainerDescriptionTextBox";
            this.TrainerDescriptionTextBox.Size = new System.Drawing.Size(329, 20);
            this.TrainerDescriptionTextBox.TabIndex = 5;
            // 
            // PokeQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 741);
            this.Controls.Add(this.TrainerDescriptionTextBox);
            this.Controls.Add(this.TrainerDescriptionLabel);
            this.Controls.Add(this.SubmitTrainerBtn);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.TrainerNameTextBox);
            this.Controls.Add(this.GenderOutputLabel);
            this.Controls.Add(this.AgeOutputLabel);
            this.Controls.Add(this.TrainerNameOutputLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.TrainerNameLabel);
            this.Name = "PokeQuestForm";
            this.Text = "PokeQuest";
            this.Load += new System.EventHandler(this.PokeQuestWindow_OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainerNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label TrainerNameOutputLabel;
        private System.Windows.Forms.Label AgeOutputLabel;
        private System.Windows.Forms.Label GenderOutputLabel;
        private System.Windows.Forms.TextBox TrainerNameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Button SubmitTrainerBtn;
        private System.Windows.Forms.Label TrainerDescriptionLabel;
        private System.Windows.Forms.TextBox TrainerDescriptionTextBox;
    }
}

