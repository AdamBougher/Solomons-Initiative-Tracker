namespace Solomons_initiative_Tracker
{
    partial class Add_Character
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
            components = new System.ComponentModel.Container();
            HpTB = new TextBox();
            AcTB = new TextBox();
            label11 = new Label();
            label6 = new Label();
            StrTB = new TextBox();
            label10 = new Label();
            DexTB = new TextBox();
            ConTB = new TextBox();
            label9 = new Label();
            ChaCB = new CheckBox();
            StrCB = new CheckBox();
            DexCB = new CheckBox();
            WisCB = new CheckBox();
            ConCB = new CheckBox();
            IntCB = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            ChaTB = new TextBox();
            IntTB = new TextBox();
            WisTB = new TextBox();
            SaveBtn = new Button();
            OtherInfoTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label12 = new Label();
            amtToAddTB = new TextBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            speedTB = new TextBox();
            DamageFLP = new FlowLayoutPanel();
            ClassCombo = new ComboBox();
            label4 = new Label();
            CharacterCombo = new ComboBox();
            CharacterCM = new ContextMenuStrip(components);
            NameTB = new TextBox();
            classBindingSource = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classBindingSource).BeginInit();
            SuspendLayout();
            // 
            // HpTB
            // 
            HpTB.Location = new Point(149, 96);
            HpTB.MaxLength = 6;
            HpTB.Name = "HpTB";
            HpTB.Size = new Size(40, 23);
            HpTB.TabIndex = 2;
            HpTB.Text = "0";
            HpTB.KeyPress += IsNumber;
            // 
            // AcTB
            // 
            AcTB.Location = new Point(149, 124);
            AcTB.MaxLength = 2;
            AcTB.Name = "AcTB";
            AcTB.PlaceholderText = "10";
            AcTB.Size = new Size(20, 23);
            AcTB.TabIndex = 3;
            AcTB.TextAlign = HorizontalAlignment.Center;
            AcTB.KeyPress += IsNumber;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 59;
            label11.Text = "Charisma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 4);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 54;
            label6.Text = "Strength";
            // 
            // StrTB
            // 
            StrTB.HideSelection = false;
            StrTB.Location = new Point(3, 22);
            StrTB.MaxLength = 3;
            StrTB.Name = "StrTB";
            StrTB.Size = new Size(28, 23);
            StrTB.TabIndex = 5;
            StrTB.Text = "10";
            StrTB.TextAlign = HorizontalAlignment.Center;
            StrTB.KeyPress += IsNumber;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 1);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 58;
            label10.Text = "Wisdom";
            // 
            // DexTB
            // 
            DexTB.Location = new Point(1, 17);
            DexTB.Name = "DexTB";
            DexTB.Size = new Size(28, 23);
            DexTB.TabIndex = 7;
            DexTB.Text = "10";
            DexTB.TextAlign = HorizontalAlignment.Center;
            DexTB.KeyPress += IsNumber;
            // 
            // ConTB
            // 
            ConTB.Location = new Point(3, 17);
            ConTB.Name = "ConTB";
            ConTB.Size = new Size(28, 23);
            ConTB.TabIndex = 9;
            ConTB.Text = "10";
            ConTB.TextAlign = HorizontalAlignment.Center;
            ConTB.KeyPress += IsNumber;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(-1, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 57;
            label9.Text = "Intelligence";
            // 
            // ChaCB
            // 
            ChaCB.AutoSize = true;
            ChaCB.Location = new Point(38, 22);
            ChaCB.Name = "ChaCB";
            ChaCB.Size = new Size(15, 14);
            ChaCB.TabIndex = 16;
            ChaCB.UseVisualStyleBackColor = true;
            // 
            // StrCB
            // 
            StrCB.AutoSize = true;
            StrCB.Location = new Point(37, 26);
            StrCB.Name = "StrCB";
            StrCB.Size = new Size(15, 14);
            StrCB.TabIndex = 6;
            StrCB.UseVisualStyleBackColor = true;
            // 
            // DexCB
            // 
            DexCB.AutoSize = true;
            DexCB.Location = new Point(34, 21);
            DexCB.Name = "DexCB";
            DexCB.Size = new Size(15, 14);
            DexCB.TabIndex = 8;
            DexCB.UseVisualStyleBackColor = true;
            // 
            // WisCB
            // 
            WisCB.AutoSize = true;
            WisCB.Location = new Point(37, 23);
            WisCB.Name = "WisCB";
            WisCB.Size = new Size(15, 14);
            WisCB.TabIndex = 14;
            WisCB.UseVisualStyleBackColor = true;
            // 
            // ConCB
            // 
            ConCB.AutoSize = true;
            ConCB.Location = new Point(37, 21);
            ConCB.Name = "ConCB";
            ConCB.Size = new Size(15, 14);
            ConCB.TabIndex = 10;
            ConCB.UseVisualStyleBackColor = true;
            // 
            // IntCB
            // 
            IntCB.AutoSize = true;
            IntCB.Location = new Point(33, 22);
            IntCB.Name = "IntCB";
            IntCB.Size = new Size(15, 14);
            IntCB.TabIndex = 12;
            IntCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 55;
            label7.Text = "Dexterity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 56;
            label8.Text = "Constitution";
            // 
            // ChaTB
            // 
            ChaTB.Location = new Point(3, 18);
            ChaTB.Name = "ChaTB";
            ChaTB.Size = new Size(28, 23);
            ChaTB.TabIndex = 15;
            ChaTB.Text = "10";
            ChaTB.TextAlign = HorizontalAlignment.Center;
            ChaTB.KeyPress += IsNumber;
            // 
            // IntTB
            // 
            IntTB.Location = new Point(-1, 18);
            IntTB.Name = "IntTB";
            IntTB.Size = new Size(28, 23);
            IntTB.TabIndex = 11;
            IntTB.Text = "10";
            IntTB.TextAlign = HorizontalAlignment.Center;
            IntTB.KeyPress += IsNumber;
            // 
            // WisTB
            // 
            WisTB.Location = new Point(3, 19);
            WisTB.Name = "WisTB";
            WisTB.Size = new Size(28, 23);
            WisTB.TabIndex = 13;
            WisTB.Text = "10";
            WisTB.TextAlign = HorizontalAlignment.Center;
            WisTB.KeyPress += IsNumber;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(339, 399);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(45, 23);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Add";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // OtherInfoTB
            // 
            OtherInfoTB.AcceptsReturn = true;
            OtherInfoTB.AcceptsTab = true;
            OtherInfoTB.AllowDrop = true;
            OtherInfoTB.BackColor = Color.White;
            OtherInfoTB.Font = new Font("Verdana", 9.75F);
            OtherInfoTB.Location = new Point(104, 220);
            OtherInfoTB.MaxLength = 500;
            OtherInfoTB.Multiline = true;
            OtherInfoTB.Name = "OtherInfoTB";
            OtherInfoTB.PlaceholderText = "Notes:";
            OtherInfoTB.Size = new Size(280, 167);
            OtherInfoTB.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 99);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 26;
            label2.Text = "HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 127);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 27;
            label3.Text = "AC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 12);
            label5.MinimumSize = new Size(40, 23);
            label5.Name = "label5";
            label5.Size = new Size(40, 23);
            label5.TabIndex = 29;
            label5.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(217, 402);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 101;
            label12.Text = "Amount to Add";
            // 
            // amtToAddTB
            // 
            amtToAddTB.Location = new Point(313, 399);
            amtToAddTB.MaxLength = 2;
            amtToAddTB.Name = "amtToAddTB";
            amtToAddTB.PlaceholderText = "1";
            amtToAddTB.Size = new Size(20, 23);
            amtToAddTB.TabIndex = 200;
            amtToAddTB.TextAlign = HorizontalAlignment.Center;
            amtToAddTB.KeyPress += IsNumber;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(StrCB);
            panel2.Controls.Add(StrTB);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 45);
            panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(72, 327);
            flowLayoutPanel1.TabIndex = 201;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(DexTB);
            panel3.Controls.Add(DexCB);
            panel3.Location = new Point(3, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(67, 44);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(ConTB);
            panel4.Controls.Add(ConCB);
            panel4.Location = new Point(3, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(78, 50);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(IntCB);
            panel5.Controls.Add(IntTB);
            panel5.Location = new Point(3, 160);
            panel5.Name = "panel5";
            panel5.Size = new Size(67, 50);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(label10);
            panel6.Controls.Add(WisTB);
            panel6.Controls.Add(WisCB);
            panel6.Location = new Point(3, 216);
            panel6.Name = "panel6";
            panel6.Size = new Size(67, 50);
            panel6.TabIndex = 55;
            // 
            // panel7
            // 
            panel7.Controls.Add(label11);
            panel7.Controls.Add(ChaCB);
            panel7.Controls.Add(ChaTB);
            panel7.Location = new Point(3, 272);
            panel7.Name = "panel7";
            panel7.Size = new Size(67, 50);
            panel7.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 153);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 202;
            label1.Text = "Speed";
            // 
            // speedTB
            // 
            speedTB.Location = new Point(149, 150);
            speedTB.MaxLength = 4;
            speedTB.Name = "speedTB";
            speedTB.PlaceholderText = "30";
            speedTB.Size = new Size(40, 23);
            speedTB.TabIndex = 203;
            speedTB.TextAlign = HorizontalAlignment.Center;
            speedTB.KeyPress += IsNumber;
            // 
            // DamageFLP
            // 
            DamageFLP.Location = new Point(234, 43);
            DamageFLP.Name = "DamageFLP";
            DamageFLP.Size = new Size(150, 150);
            DamageFLP.TabIndex = 204;
            // 
            // ClassCombo
            // 
            ClassCombo.FormattingEnabled = true;
            ClassCombo.Location = new Point(56, 45);
            ClassCombo.Name = "ClassCombo";
            ClassCombo.Size = new Size(95, 23);
            ClassCombo.TabIndex = 205;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 45);
            label4.MinimumSize = new Size(0, 23);
            label4.Name = "label4";
            label4.Size = new Size(34, 23);
            label4.TabIndex = 206;
            label4.Text = "Class";
            // 
            // CharacterCombo
            // 
            CharacterCombo.FormattingEnabled = true;
            CharacterCombo.Items.AddRange(new object[] { "Load From File", "Save to File" });
            CharacterCombo.Location = new Point(233, 12);
            CharacterCombo.Name = "CharacterCombo";
            CharacterCombo.Size = new Size(151, 23);
            CharacterCombo.TabIndex = 207;
            CharacterCombo.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            // 
            // CharacterCM
            // 
            CharacterCM.Name = "CharacterCM";
            CharacterCM.Size = new Size(61, 4);
            // 
            // NameTB
            // 
            NameTB.Location = new Point(56, 12);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(115, 23);
            NameTB.TabIndex = 208;
            // 
            // classBindingSource
            // 
            classBindingSource.DataSource = typeof(Class);
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 50;
            toolTip1.AutoPopDelay = 100;
            toolTip1.InitialDelay = 10;
            toolTip1.ReshowDelay = 10;
            // 
            // Add_Character
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 431);
            Controls.Add(NameTB);
            Controls.Add(CharacterCombo);
            Controls.Add(label4);
            Controls.Add(ClassCombo);
            Controls.Add(DamageFLP);
            Controls.Add(speedTB);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(amtToAddTB);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OtherInfoTB);
            Controls.Add(SaveBtn);
            Controls.Add(AcTB);
            Controls.Add(HpTB);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Character";
            Text = "Add_Character";
            Load += Add_Character_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox HpTB;
        private TextBox AcTB;
        private Button SaveBtn;
        private CheckBox ChaCB;
        private CheckBox WisCB;
        private CheckBox IntCB;
        private CheckBox ConCB;
        private CheckBox DexCB;
        private CheckBox StrCB;
        private TextBox ChaTB;
        private TextBox ConTB;
        private TextBox DexTB;
        private TextBox WisTB;
        private TextBox IntTB;
        private TextBox StrTB;
        private TextBox OtherInfoTB;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label12;
        private TextBox amtToAddTB;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label1;
        private TextBox speedTB;
        private FlowLayoutPanel DamageFLP;
        private ComboBox ClassCombo;
        private Label label4;
        private ComboBox CharacterCombo;
        private ContextMenuStrip CharacterCM;
        private TextBox NameTB;
        private BindingSource classBindingSource;
        private ToolTip toolTip1;
    }
}