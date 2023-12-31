namespace Solomons_initiative_Tracker
{
    partial class DamageSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageSelect));
            label1 = new Label();
            DamageCombo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Damage Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DamageCombo
            // 
            DamageCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DamageCombo.FormattingEnabled = true;
            DamageCombo.Location = new Point(12, 27);
            DamageCombo.Name = "DamageCombo";
            DamageCombo.Size = new Size(180, 23);
            DamageCombo.TabIndex = 206;
            DamageCombo.SelectedValueChanged += DamageCombo_SelectedValueChanged;
            // 
            // DamageSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 61);
            Controls.Add(DamageCombo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DamageSelect";
            Load += DamageSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox DamageCombo;
    }
}