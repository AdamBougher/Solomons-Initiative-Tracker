namespace Solomons_initiative_Tracker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            InitiativeDGV = new DataGridView();
            initiative = new DataGridViewTextBoxColumn();
            AC = new DataGridViewTextBoxColumn();
            HP = new DataGridViewTextBoxColumn();
            CharName = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            ListContext = new ContextMenuStrip(components);
            characterToolStripMenuItem2 = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            removeToolStripMenuItem1 = new ToolStripMenuItem();
            healToolStripMenuItem = new ToolStripMenuItem();
            damageToolStripMenuItem = new ToolStripMenuItem();
            sortListToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            characterToolStripMenuItem = new ToolStripMenuItem();
            characterToolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            damageToolStripMenuItem1 = new ToolStripMenuItem();
            healToolStripMenuItem1 = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            endToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            concitionsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            label2 = new Label();
            RoundLable = new Label();
            CombatBtn = new Button();
            label3 = new Label();
            currentNameLbl = new Label();
            CharacterPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            AClabel = new Label();
            panel6 = new Panel();
            label5 = new Label();
            HPlabel = new Label();
            panel7 = new Panel();
            speedLabel = new Label();
            label1 = new Label();
            EditConditionBtn = new Button();
            ConditionFLP = new FlowLayoutPanel();
            AbilityScorePanel = new FlowLayoutPanel();
            p0 = new Panel();
            StrTB0 = new Label();
            label6 = new Label();
            StrCB = new CheckBox();
            p1 = new Panel();
            DexTB1 = new Label();
            label7 = new Label();
            DexCB = new CheckBox();
            panel2 = new Panel();
            label8 = new Label();
            ConCB = new CheckBox();
            ConTB2 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            IntTB3 = new Label();
            IntCB = new CheckBox();
            panel4 = new Panel();
            label10 = new Label();
            WisTB4 = new Label();
            WisCB = new CheckBox();
            Panel5 = new Panel();
            ChaTB5 = new Label();
            label11 = new Label();
            ChaCB = new CheckBox();
            CharacterInformationTB = new TextBox();
            tooltip = new ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)InitiativeDGV).BeginInit();
            ListContext.SuspendLayout();
            menuStrip1.SuspendLayout();
            CharacterPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            AbilityScorePanel.SuspendLayout();
            p0.SuspendLayout();
            p1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // InitiativeDGV
            // 
            InitiativeDGV.AllowUserToAddRows = false;
            InitiativeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InitiativeDGV.Columns.AddRange(new DataGridViewColumn[] { initiative, AC, HP, CharName, Class });
            InitiativeDGV.ContextMenuStrip = ListContext;
            InitiativeDGV.Location = new Point(12, 56);
            InitiativeDGV.MultiSelect = false;
            InitiativeDGV.Name = "InitiativeDGV";
            InitiativeDGV.RowHeadersVisible = false;
            InitiativeDGV.Size = new Size(270, 343);
            InitiativeDGV.TabIndex = 6;
            InitiativeDGV.EditingControlShowing += InitiativeDGV_EditingControlShowing;
            InitiativeDGV.RowEnter += InitiativeDGV_RowEnter;
            InitiativeDGV.SortCompare += InitiativeDGV_SortCompare;
            InitiativeDGV.KeyPress += Column1_KeyPress;
            // 
            // initiative
            // 
            initiative.HeaderText = "#";
            initiative.MaxInputLength = 2;
            initiative.Name = "initiative";
            initiative.Resizable = DataGridViewTriState.False;
            initiative.Width = 20;
            // 
            // AC
            // 
            AC.HeaderText = "AC";
            AC.MaxInputLength = 3;
            AC.Name = "AC";
            AC.Resizable = DataGridViewTriState.False;
            AC.ToolTipText = "Characters Armor Class";
            AC.Width = 30;
            // 
            // HP
            // 
            HP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HP.FillWeight = 50F;
            HP.HeaderText = "HP";
            HP.MaxInputLength = 4;
            HP.Name = "HP";
            // 
            // CharName
            // 
            CharName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CharName.FillWeight = 133.140671F;
            CharName.HeaderText = "Name";
            CharName.MaxInputLength = 50;
            CharName.Name = "CharName";
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.ReadOnly = true;
            // 
            // ListContext
            // 
            ListContext.BackColor = SystemColors.ControlDarkDark;
            ListContext.Items.AddRange(new ToolStripItem[] { characterToolStripMenuItem2, sortListToolStripMenuItem, clearToolStripMenuItem });
            ListContext.Name = "contextMenuStrip1";
            ListContext.Size = new Size(126, 70);
            // 
            // characterToolStripMenuItem2
            // 
            characterToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, removeToolStripMenuItem1, healToolStripMenuItem, damageToolStripMenuItem });
            characterToolStripMenuItem2.Name = "characterToolStripMenuItem2";
            characterToolStripMenuItem2.Size = new Size(125, 22);
            characterToolStripMenuItem2.Text = "Character";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(118, 22);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += AddCharacter;
            // 
            // removeToolStripMenuItem1
            // 
            removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            removeToolStripMenuItem1.Size = new Size(118, 22);
            removeToolStripMenuItem1.Text = "Remove";
            removeToolStripMenuItem1.Click += RemoveFromList;
            // 
            // healToolStripMenuItem
            // 
            healToolStripMenuItem.Name = "healToolStripMenuItem";
            healToolStripMenuItem.Size = new Size(118, 22);
            healToolStripMenuItem.Text = "Heal";
            healToolStripMenuItem.Click += DamageOrHeal;
            // 
            // damageToolStripMenuItem
            // 
            damageToolStripMenuItem.Name = "damageToolStripMenuItem";
            damageToolStripMenuItem.Size = new Size(118, 22);
            damageToolStripMenuItem.Text = "Damage";
            damageToolStripMenuItem.Click += DamageOrHeal;
            // 
            // sortListToolStripMenuItem
            // 
            sortListToolStripMenuItem.Name = "sortListToolStripMenuItem";
            sortListToolStripMenuItem.Size = new Size(125, 22);
            sortListToolStripMenuItem.Text = "Sort List";
            sortListToolStripMenuItem.Click += SortList;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(125, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { characterToolStripMenuItem, endToolStripMenuItem, informationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(859, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { characterToolStripMenuItem1, sortToolStripMenuItem, clearToolStripMenuItem1 });
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(37, 20);
            characterToolStripMenuItem.Text = "List";
            // 
            // characterToolStripMenuItem1
            // 
            characterToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, damageToolStripMenuItem1, healToolStripMenuItem1 });
            characterToolStripMenuItem1.Name = "characterToolStripMenuItem1";
            characterToolStripMenuItem1.Size = new Size(125, 22);
            characterToolStripMenuItem1.Text = "Character";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(118, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += AddCharacter;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(118, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += RemoveFromList;
            // 
            // damageToolStripMenuItem1
            // 
            damageToolStripMenuItem1.Name = "damageToolStripMenuItem1";
            damageToolStripMenuItem1.Size = new Size(118, 22);
            damageToolStripMenuItem1.Text = "Damage";
            damageToolStripMenuItem1.Click += DamageOrHeal;
            // 
            // healToolStripMenuItem1
            // 
            healToolStripMenuItem1.Name = "healToolStripMenuItem1";
            healToolStripMenuItem1.Size = new Size(118, 22);
            healToolStripMenuItem1.Text = "Heal";
            healToolStripMenuItem1.Click += DamageOrHeal;
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(125, 22);
            sortToolStripMenuItem.Text = "Sort";
            sortToolStripMenuItem.Click += SortList;
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(125, 22);
            clearToolStripMenuItem1.Text = "Clear";
            clearToolStripMenuItem1.Click += ClearToolStripMenuItem_Click;
            // 
            // endToolStripMenuItem
            // 
            endToolStripMenuItem.Name = "endToolStripMenuItem";
            endToolStripMenuItem.Size = new Size(39, 20);
            endToolStripMenuItem.Text = "End";
            endToolStripMenuItem.Visible = false;
            endToolStripMenuItem.Click += EndToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { concitionsToolStripMenuItem, aboutToolStripMenuItem1 });
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(44, 20);
            informationToolStripMenuItem.Text = "Help";
            // 
            // concitionsToolStripMenuItem
            // 
            concitionsToolStripMenuItem.Name = "concitionsToolStripMenuItem";
            concitionsToolStripMenuItem.Size = new Size(193, 22);
            concitionsToolStripMenuItem.Text = "Condition Information";
            concitionsToolStripMenuItem.Click += ConditionsMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(193, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += AboutToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 31);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 40;
            label2.Text = "Round :";
            // 
            // RoundLable
            // 
            RoundLable.AutoSize = true;
            RoundLable.Location = new Point(128, 31);
            RoundLable.Name = "RoundLable";
            RoundLable.Size = new Size(13, 15);
            RoundLable.TabIndex = 41;
            RoundLable.Text = "0";
            // 
            // CombatBtn
            // 
            CombatBtn.Location = new Point(9, 27);
            CombatBtn.Name = "CombatBtn";
            CombatBtn.Size = new Size(59, 23);
            CombatBtn.TabIndex = 42;
            CombatBtn.Text = "Start";
            CombatBtn.UseVisualStyleBackColor = true;
            CombatBtn.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 30);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 43;
            label3.Text = "Current Turn :";
            // 
            // currentNameLbl
            // 
            currentNameLbl.AutoSize = true;
            currentNameLbl.Location = new Point(233, 31);
            currentNameLbl.Name = "currentNameLbl";
            currentNameLbl.Size = new Size(0, 15);
            currentNameLbl.TabIndex = 44;
            // 
            // CharacterPanel
            // 
            CharacterPanel.BackColor = Color.DarkGray;
            CharacterPanel.Controls.Add(flowLayoutPanel1);
            CharacterPanel.Controls.Add(EditConditionBtn);
            CharacterPanel.Controls.Add(ConditionFLP);
            CharacterPanel.Controls.Add(AbilityScorePanel);
            CharacterPanel.Controls.Add(CharacterInformationTB);
            CharacterPanel.Location = new Point(295, 56);
            CharacterPanel.Name = "CharacterPanel";
            CharacterPanel.Size = new Size(552, 343);
            CharacterPanel.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Location = new Point(91, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(95, 100);
            flowLayoutPanel1.TabIndex = 206;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AClabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 22);
            panel1.TabIndex = 207;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 4);
            label4.MinimumSize = new Size(30, 15);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 103;
            label4.Text = "AC :";
            // 
            // AClabel
            // 
            AClabel.AutoSize = true;
            AClabel.BackColor = Color.WhiteSmoke;
            AClabel.BorderStyle = BorderStyle.Fixed3D;
            AClabel.Location = new Point(52, 4);
            AClabel.MaximumSize = new Size(0, 15);
            AClabel.MinimumSize = new Size(15, 15);
            AClabel.Name = "AClabel";
            AClabel.Size = new Size(15, 15);
            AClabel.TabIndex = 105;
            AClabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(HPlabel);
            panel6.Location = new Point(3, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(92, 22);
            panel6.TabIndex = 208;
            // 
            // label5
            // 
            label5.Location = new Point(16, 5);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 104;
            label5.Text = "HP :";
            // 
            // HPlabel
            // 
            HPlabel.AutoSize = true;
            HPlabel.BackColor = Color.WhiteSmoke;
            HPlabel.BorderStyle = BorderStyle.Fixed3D;
            HPlabel.Location = new Point(52, 5);
            HPlabel.MinimumSize = new Size(15, 15);
            HPlabel.Name = "HPlabel";
            HPlabel.Size = new Size(15, 17);
            HPlabel.TabIndex = 106;
            HPlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(speedLabel);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(92, 22);
            panel7.TabIndex = 209;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.BackColor = Color.WhiteSmoke;
            speedLabel.BorderStyle = BorderStyle.Fixed3D;
            speedLabel.Location = new Point(52, 4);
            speedLabel.MinimumSize = new Size(15, 15);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(15, 17);
            speedLabel.TabIndex = 205;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 4);
            label1.MinimumSize = new Size(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 204;
            label1.Text = "Speed :";
            // 
            // EditConditionBtn
            // 
            EditConditionBtn.Enabled = false;
            EditConditionBtn.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            EditConditionBtn.Location = new Point(192, 9);
            EditConditionBtn.Name = "EditConditionBtn";
            EditConditionBtn.Size = new Size(30, 30);
            EditConditionBtn.TabIndex = 15;
            EditConditionBtn.Text = "±";
            EditConditionBtn.UseVisualStyleBackColor = true;
            EditConditionBtn.Click += EditCondition_Click;
            // 
            // ConditionFLP
            // 
            ConditionFLP.Location = new Point(228, 9);
            ConditionFLP.Name = "ConditionFLP";
            ConditionFLP.Size = new Size(292, 75);
            ConditionFLP.TabIndex = 108;
            // 
            // AbilityScorePanel
            // 
            AbilityScorePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AbilityScorePanel.Controls.Add(p0);
            AbilityScorePanel.Controls.Add(p1);
            AbilityScorePanel.Controls.Add(panel2);
            AbilityScorePanel.Controls.Add(panel3);
            AbilityScorePanel.Controls.Add(panel4);
            AbilityScorePanel.Controls.Add(Panel5);
            AbilityScorePanel.FlowDirection = FlowDirection.TopDown;
            AbilityScorePanel.Location = new Point(0, 0);
            AbilityScorePanel.Name = "AbilityScorePanel";
            AbilityScorePanel.Size = new Size(85, 343);
            AbilityScorePanel.TabIndex = 107;
            AbilityScorePanel.WrapContents = false;
            // 
            // p0
            // 
            p0.BackColor = Color.Transparent;
            p0.Controls.Add(StrTB0);
            p0.Controls.Add(label6);
            p0.Controls.Add(StrCB);
            p0.Location = new Point(3, 3);
            p0.Name = "p0";
            p0.Size = new Size(75, 50);
            p0.TabIndex = 108;
            // 
            // StrTB0
            // 
            StrTB0.AutoSize = true;
            StrTB0.BackColor = Color.WhiteSmoke;
            StrTB0.BorderStyle = BorderStyle.Fixed3D;
            StrTB0.Font = new Font("Segoe UI", 9F);
            StrTB0.Location = new Point(9, 15);
            StrTB0.MinimumSize = new Size(25, 25);
            StrTB0.Name = "StrTB0";
            StrTB0.Size = new Size(25, 25);
            StrTB0.TabIndex = 108;
            StrTB0.Text = "-";
            StrTB0.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(StrTB0, "Hint Click to show Modifier");
            StrTB0.Click += ToggleModifier;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 54;
            label6.Text = "Strength";
            // 
            // StrCB
            // 
            StrCB.AutoCheck = false;
            StrCB.AutoSize = true;
            StrCB.Location = new Point(40, 18);
            StrCB.Name = "StrCB";
            StrCB.Size = new Size(15, 14);
            StrCB.TabIndex = 12;
            StrCB.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            p1.BackColor = Color.Transparent;
            p1.Controls.Add(DexTB1);
            p1.Controls.Add(label7);
            p1.Controls.Add(DexCB);
            p1.Location = new Point(3, 59);
            p1.Name = "p1";
            p1.Size = new Size(75, 50);
            p1.TabIndex = 108;
            // 
            // DexTB1
            // 
            DexTB1.AutoSize = true;
            DexTB1.BackColor = Color.WhiteSmoke;
            DexTB1.BorderStyle = BorderStyle.Fixed3D;
            DexTB1.Font = new Font("Segoe UI", 9F);
            DexTB1.Location = new Point(9, 13);
            DexTB1.MinimumSize = new Size(25, 25);
            DexTB1.Name = "DexTB1";
            DexTB1.Size = new Size(25, 25);
            DexTB1.TabIndex = 109;
            DexTB1.Text = "-";
            DexTB1.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(DexTB1, "Hint Click to show Modifier");
            DexTB1.Click += ToggleModifier;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 55;
            label7.Text = "Dexterity";
            // 
            // DexCB
            // 
            DexCB.AutoCheck = false;
            DexCB.AutoSize = true;
            DexCB.Location = new Point(40, 18);
            DexCB.Name = "DexCB";
            DexCB.Size = new Size(15, 14);
            DexCB.TabIndex = 13;
            DexCB.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(ConCB);
            panel2.Controls.Add(ConTB2);
            panel2.Location = new Point(3, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 50);
            panel2.TabIndex = 108;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 56;
            label8.Text = "Constitution";
            // 
            // ConCB
            // 
            ConCB.AutoCheck = false;
            ConCB.AutoSize = true;
            ConCB.Location = new Point(40, 18);
            ConCB.Name = "ConCB";
            ConCB.Size = new Size(15, 14);
            ConCB.TabIndex = 14;
            ConCB.UseVisualStyleBackColor = true;
            // 
            // ConTB2
            // 
            ConTB2.AutoSize = true;
            ConTB2.BackColor = Color.WhiteSmoke;
            ConTB2.BorderStyle = BorderStyle.Fixed3D;
            ConTB2.Font = new Font("Segoe UI", 9F);
            ConTB2.Location = new Point(9, 13);
            ConTB2.MinimumSize = new Size(25, 25);
            ConTB2.Name = "ConTB2";
            ConTB2.Size = new Size(25, 25);
            ConTB2.TabIndex = 110;
            ConTB2.Text = "-";
            ConTB2.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(ConTB2, "Hint Click to show Modifier");
            ConTB2.Click += ToggleModifier;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(IntTB3);
            panel3.Controls.Add(IntCB);
            panel3.Location = new Point(3, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(75, 50);
            panel3.TabIndex = 108;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 1);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 57;
            label9.Text = "Intelligence";
            // 
            // IntTB3
            // 
            IntTB3.AutoSize = true;
            IntTB3.BackColor = Color.WhiteSmoke;
            IntTB3.BorderStyle = BorderStyle.Fixed3D;
            IntTB3.Font = new Font("Segoe UI", 9F);
            IntTB3.Location = new Point(9, 16);
            IntTB3.MinimumSize = new Size(25, 25);
            IntTB3.Name = "IntTB3";
            IntTB3.Size = new Size(25, 25);
            IntTB3.TabIndex = 111;
            IntTB3.Text = "-";
            IntTB3.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(IntTB3, "Hint Click to show Modifier");
            IntTB3.Click += ToggleModifier;
            // 
            // IntCB
            // 
            IntCB.AutoCheck = false;
            IntCB.AutoSize = true;
            IntCB.Location = new Point(40, 19);
            IntCB.Name = "IntCB";
            IntCB.Size = new Size(15, 14);
            IntCB.TabIndex = 15;
            IntCB.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(WisTB4);
            panel4.Controls.Add(WisCB);
            panel4.Location = new Point(3, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(75, 50);
            panel4.TabIndex = 108;
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
            // WisTB4
            // 
            WisTB4.AutoSize = true;
            WisTB4.BackColor = Color.WhiteSmoke;
            WisTB4.BorderStyle = BorderStyle.Fixed3D;
            WisTB4.Font = new Font("Segoe UI", 9F);
            WisTB4.Location = new Point(9, 16);
            WisTB4.MinimumSize = new Size(25, 25);
            WisTB4.Name = "WisTB4";
            WisTB4.Size = new Size(25, 25);
            WisTB4.TabIndex = 112;
            WisTB4.Text = "-";
            WisTB4.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(WisTB4, "Hint Click to show Modifier");
            WisTB4.Click += ToggleModifier;
            // 
            // WisCB
            // 
            WisCB.AutoCheck = false;
            WisCB.AutoSize = true;
            WisCB.Location = new Point(40, 19);
            WisCB.Name = "WisCB";
            WisCB.Size = new Size(15, 14);
            WisCB.TabIndex = 16;
            WisCB.UseVisualStyleBackColor = true;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(ChaTB5);
            Panel5.Controls.Add(label11);
            Panel5.Controls.Add(ChaCB);
            Panel5.Location = new Point(3, 283);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(75, 50);
            Panel5.TabIndex = 21;
            // 
            // ChaTB5
            // 
            ChaTB5.AutoSize = true;
            ChaTB5.BackColor = Color.WhiteSmoke;
            ChaTB5.BorderStyle = BorderStyle.Fixed3D;
            ChaTB5.Font = new Font("Segoe UI", 9F);
            ChaTB5.Location = new Point(9, 15);
            ChaTB5.MinimumSize = new Size(25, 25);
            ChaTB5.Name = "ChaTB5";
            ChaTB5.Size = new Size(25, 25);
            ChaTB5.TabIndex = 113;
            ChaTB5.Text = "-";
            ChaTB5.TextAlign = ContentAlignment.MiddleCenter;
            tooltip.SetToolTip(ChaTB5, "Hint Click to show Modifier");
            ChaTB5.Click += ToggleModifier;
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
            // ChaCB
            // 
            ChaCB.AutoCheck = false;
            ChaCB.AutoSize = true;
            ChaCB.Location = new Point(40, 18);
            ChaCB.Name = "ChaCB";
            ChaCB.Size = new Size(15, 14);
            ChaCB.TabIndex = 17;
            ChaCB.UseVisualStyleBackColor = true;
            // 
            // CharacterInformationTB
            // 
            CharacterInformationTB.AcceptsReturn = true;
            CharacterInformationTB.AcceptsTab = true;
            CharacterInformationTB.AllowDrop = true;
            CharacterInformationTB.BackColor = Color.Gainsboro;
            CharacterInformationTB.Location = new Point(91, 123);
            CharacterInformationTB.MaxLength = 500;
            CharacterInformationTB.Multiline = true;
            CharacterInformationTB.Name = "CharacterInformationTB";
            CharacterInformationTB.PlaceholderText = "Character Information";
            CharacterInformationTB.Size = new Size(455, 214);
            CharacterInformationTB.TabIndex = 7;
            CharacterInformationTB.Leave += CharacterInformationTB_Leave;
            // 
            // tooltip
            // 
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(859, 411);
            Controls.Add(CharacterPanel);
            Controls.Add(currentNameLbl);
            Controls.Add(label3);
            Controls.Add(CombatBtn);
            Controls.Add(RoundLable);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Controls.Add(InitiativeDGV);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainWindow";
            Text = "Solomons Initiative Tracker";
            tooltip.SetToolTip(this, "Add or Remove a Condition");
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)InitiativeDGV).EndInit();
            ListContext.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            CharacterPanel.ResumeLayout(false);
            CharacterPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            AbilityScorePanel.ResumeLayout(false);
            p0.ResumeLayout(false);
            p0.PerformLayout();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView InitiativeDGV;
        private ContextMenuStrip ListContext;
        private ToolStripMenuItem sortListToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem characterToolStripMenuItem;
        private Label label2;
        private Label RoundLable;
        private Button CombatBtn;
        private Label label3;
        private Label currentNameLbl;
        private Panel CharacterPanel;
        private Label HPlabel;
        private Label AClabel;
        private Label label5;
        private Label label4;
        private TextBox CharacterInformationTB;
        private Panel Panel5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox ChaCB;
        private CheckBox WisCB;
        private CheckBox IntCB;
        private CheckBox ConCB;
        private CheckBox DexCB;
        private CheckBox StrCB;
        private Panel p1;
        private FlowLayoutPanel AbilityScorePanel;
        private Panel p0;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label StrTB0;
        private Label DexTB1;
        private Label ConTB2;
        private Label IntTB3;
        private Label WisTB4;
        private Label ChaTB5;
        private ToolTip tooltip;
        private FlowLayoutPanel ConditionFLP;
        private Button EditConditionBtn;
        private Label speedLabel;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private DataGridViewTextBoxColumn initiative;
        private DataGridViewTextBoxColumn AC;
        private DataGridViewTextBoxColumn HP;
        private DataGridViewTextBoxColumn CharName;
        private DataGridViewTextBoxColumn Class;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem endToolStripMenuItem;
        private ToolStripMenuItem characterToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem damageToolStripMenuItem1;
        private ToolStripMenuItem healToolStripMenuItem1;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem concitionsToolStripMenuItem;
        private ToolStripMenuItem characterToolStripMenuItem2;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem healToolStripMenuItem;
        private ToolStripMenuItem damageToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}