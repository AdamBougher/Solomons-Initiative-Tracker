namespace Solomons_initiative_Tracker
{
    partial class About
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
            nameLabel = new Label();
            versionLabel = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(14, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(318, 32);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Solomons Initative Tracker";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            versionLabel.Location = new Point(12, 62);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(63, 25);
            versionLabel.TabIndex = 2;
            versionLabel.Text = "V 0.01";
            versionLabel.Click += versionLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 351);
            label3.Name = "label3";
            label3.Size = new Size(155, 15);
            label3.TabIndex = 3;
            label3.Text = "Program By: Adam Bougher";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(14, 281);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(318, 67);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Icons by  u/FatMani https://www.reddit.com/r/DnD/comments/g1yb4j/5e_roll20_token_markers_conditions_damage_types/\n";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 375);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(versionLabel);
            Controls.Add(nameLabel);
            Name = "About";
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label versionLabel;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}