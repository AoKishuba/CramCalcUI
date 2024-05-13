namespace CramCalcUI
{
    partial class InputForm
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
            GaugeUD = new NumericUpDown();
            GaugeLabel = new Label();
            TotalPerSecLabel = new Label();
            ToolTip = new ToolTip(components);
            HighAltFuzeCB = new CheckBox();
            LowAltFuzeCB = new CheckBox();
            TimeFromLaunchFuzeCB = new CheckBox();
            InertialFuzeCB = new CheckBox();
            PendepthFuzeCB = new CheckBox();
            TimeFromImpactFuze = new CheckBox();
            HollowPointCB = new CheckBox();
            SuppressorBarrelCB = new CheckBox();
            CompactorUD = new NumericUpDown();
            HardPerSecUD = new NumericUpDown();
            TotalPerSecUD = new NumericUpDown();
            PayloadTypeDD = new ComboBox();
            ImpactAngleUD = new NumericUpDown();
            AddArmorLayerButton = new Button();
            DelArmorLayerButton = new Button();
            TargetArmorLB = new ListBox();
            TargetArmorLayerDD = new ComboBox();
            FuzeBoxPanel = new Panel();
            FuzeCountLabel = new Label();
            FuzeLabel = new Label();
            FiringPiecePanel = new Panel();
            ImpactAngleLabel = new Label();
            PayloadSecondaryLabel = new Label();
            PayloadDamageLabel = new Label();
            APLabel = new Label();
            RawKDLabel = new Label();
            PayloadPerSecLabel = new Label();
            HardPerSecLabel = new Label();
            ReloadTimeLabel = new Label();
            PrepTimeLabel = new Label();
            PackingTimeLabel = new Label();
            MaxCapacityLabel = new Label();
            CompactorLabel = new Label();
            FiringPieceLabel = new Label();
            DetectionRangeLabel = new Label();
            ShellSpeedLabel = new Label();
            BarrelPanel = new Panel();
            MaxDpsLabel = new Label();
            ShellHealthLabel = new Label();
            BarrelPanelLabel = new Label();
            TargetArmorPanel = new Panel();
            ExcessKDLabel = new Label();
            KDToPenLabel = new Label();
            TargetArmorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)GaugeUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompactorUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HardPerSecUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalPerSecUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImpactAngleUD).BeginInit();
            FuzeBoxPanel.SuspendLayout();
            FiringPiecePanel.SuspendLayout();
            BarrelPanel.SuspendLayout();
            TargetArmorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GaugeUD
            // 
            GaugeUD.Location = new Point(118, 28);
            GaugeUD.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            GaugeUD.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            GaugeUD.Name = "GaugeUD";
            GaugeUD.Size = new Size(55, 23);
            GaugeUD.TabIndex = 0;
            GaugeUD.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(GaugeUD, "Cannon diameter in millimetres");
            GaugeUD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            GaugeUD.ValueChanged += GaugeUD_ValueChanged;
            // 
            // GaugeLabel
            // 
            GaugeLabel.AutoSize = true;
            GaugeLabel.Location = new Point(8, 32);
            GaugeLabel.Name = "GaugeLabel";
            GaugeLabel.Size = new Size(74, 15);
            GaugeLabel.TabIndex = 1;
            GaugeLabel.Text = "Gauge (mm)";
            // 
            // TotalPerSecLabel
            // 
            TotalPerSecLabel.AutoSize = true;
            TotalPerSecLabel.Location = new Point(8, 58);
            TotalPerSecLabel.Name = "TotalPerSecLabel";
            TotalPerSecLabel.Size = new Size(69, 15);
            TotalPerSecLabel.TabIndex = 3;
            TotalPerSecLabel.Text = "Total pellets";
            // 
            // HighAltFuzeCB
            // 
            HighAltFuzeCB.AutoSize = true;
            HighAltFuzeCB.Location = new Point(10, 54);
            HighAltFuzeCB.Name = "HighAltFuzeCB";
            HighAltFuzeCB.Size = new Size(95, 19);
            HighAltFuzeCB.TabIndex = 8;
            HighAltFuzeCB.Text = "High altitude";
            ToolTip.SetToolTip(HighAltFuzeCB, "Check to include High altitude fuze");
            HighAltFuzeCB.UseVisualStyleBackColor = true;
            HighAltFuzeCB.CheckedChanged += HighAltFuzeCB_CheckedChanged;
            // 
            // LowAltFuzeCB
            // 
            LowAltFuzeCB.AutoSize = true;
            LowAltFuzeCB.Location = new Point(10, 32);
            LowAltFuzeCB.Name = "LowAltFuzeCB";
            LowAltFuzeCB.Size = new Size(91, 19);
            LowAltFuzeCB.TabIndex = 7;
            LowAltFuzeCB.Text = "Low altitude";
            ToolTip.SetToolTip(LowAltFuzeCB, "Check to include Low altitude fuze");
            LowAltFuzeCB.UseVisualStyleBackColor = true;
            LowAltFuzeCB.CheckedChanged += LowAltFuzeCB_CheckedChanged;
            // 
            // TimeFromLaunchFuzeCB
            // 
            TimeFromLaunchFuzeCB.AutoSize = true;
            TimeFromLaunchFuzeCB.Location = new Point(10, 76);
            TimeFromLaunchFuzeCB.Name = "TimeFromLaunchFuzeCB";
            TimeFromLaunchFuzeCB.Size = new Size(120, 19);
            TimeFromLaunchFuzeCB.TabIndex = 9;
            TimeFromLaunchFuzeCB.Text = "Time from launch";
            ToolTip.SetToolTip(TimeFromLaunchFuzeCB, "Check to include Timed fuze");
            TimeFromLaunchFuzeCB.UseVisualStyleBackColor = true;
            TimeFromLaunchFuzeCB.CheckedChanged += TimeFromLaunchFuzeCB_CheckedChanged;
            // 
            // InertialFuzeCB
            // 
            InertialFuzeCB.AutoSize = true;
            InertialFuzeCB.Location = new Point(10, 98);
            InertialFuzeCB.Name = "InertialFuzeCB";
            InertialFuzeCB.Size = new Size(62, 19);
            InertialFuzeCB.TabIndex = 10;
            InertialFuzeCB.Text = "Inertial";
            ToolTip.SetToolTip(InertialFuzeCB, "Check to include Inertial fuze");
            InertialFuzeCB.UseVisualStyleBackColor = true;
            InertialFuzeCB.CheckedChanged += InertialFuzeCB_CheckedChanged;
            // 
            // PendepthFuzeCB
            // 
            PendepthFuzeCB.AutoSize = true;
            PendepthFuzeCB.Location = new Point(10, 120);
            PendepthFuzeCB.Name = "PendepthFuzeCB";
            PendepthFuzeCB.Size = new Size(121, 19);
            PendepthFuzeCB.TabIndex = 11;
            PendepthFuzeCB.Text = "Penetration depth";
            ToolTip.SetToolTip(PendepthFuzeCB, "Check to include Pendepth fuze");
            PendepthFuzeCB.UseVisualStyleBackColor = true;
            PendepthFuzeCB.CheckedChanged += PendepthFuzeCB_CheckedChanged;
            // 
            // TimeFromImpactFuze
            // 
            TimeFromImpactFuze.AutoSize = true;
            TimeFromImpactFuze.Location = new Point(10, 142);
            TimeFromImpactFuze.Name = "TimeFromImpactFuze";
            TimeFromImpactFuze.Size = new Size(144, 19);
            TimeFromImpactFuze.TabIndex = 12;
            TimeFromImpactFuze.Text = "Time from first impact";
            ToolTip.SetToolTip(TimeFromImpactFuze, "Check to include Impact time fuze");
            TimeFromImpactFuze.UseVisualStyleBackColor = true;
            TimeFromImpactFuze.CheckedChanged += TimeFromImpactFuze_CheckedChanged;
            // 
            // HollowPointCB
            // 
            HollowPointCB.AutoSize = true;
            HollowPointCB.Location = new Point(10, 186);
            HollowPointCB.Name = "HollowPointCB";
            HollowPointCB.Size = new Size(95, 19);
            HollowPointCB.TabIndex = 13;
            HollowPointCB.Text = "Hollow point";
            ToolTip.SetToolTip(HollowPointCB, "Check to make shell hollow point.\r\nReduces max KD, but ignores impact angle and \r\nnever overpens.");
            HollowPointCB.UseVisualStyleBackColor = true;
            HollowPointCB.CheckedChanged += HollowPointCB_CheckedChanged;
            // 
            // SuppressorBarrelCB
            // 
            SuppressorBarrelCB.AutoSize = true;
            SuppressorBarrelCB.Location = new Point(9, 32);
            SuppressorBarrelCB.Name = "SuppressorBarrelCB";
            SuppressorBarrelCB.Size = new Size(113, 19);
            SuppressorBarrelCB.TabIndex = 6;
            SuppressorBarrelCB.Text = "Flash suppressor";
            ToolTip.SetToolTip(SuppressorBarrelCB, "Check to use a flash suppression barrel");
            SuppressorBarrelCB.UseVisualStyleBackColor = true;
            SuppressorBarrelCB.CheckedChanged += SuppressorBarrelCB_CheckedChanged;
            // 
            // CompactorUD
            // 
            CompactorUD.Location = new Point(118, 132);
            CompactorUD.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            CompactorUD.Name = "CompactorUD";
            CompactorUD.Size = new Size(55, 23);
            CompactorUD.TabIndex = 3;
            CompactorUD.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(CompactorUD, "Total compactor/packer connections.");
            CompactorUD.ValueChanged += CompactorUD_ValueChanged;
            // 
            // HardPerSecUD
            // 
            HardPerSecUD.Location = new Point(118, 80);
            HardPerSecUD.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            HardPerSecUD.Name = "HardPerSecUD";
            HardPerSecUD.Size = new Size(55, 23);
            HardPerSecUD.TabIndex = 2;
            HardPerSecUD.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(HardPerSecUD, "Total hardener pellet/packer connections.\r\nAppears in popup UI after \"Pellets\" as \"Hardener\".");
            HardPerSecUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            HardPerSecUD.ValueChanged += HardPerSecUD_ValueChanged;
            // 
            // TotalPerSecUD
            // 
            TotalPerSecUD.Location = new Point(118, 54);
            TotalPerSecUD.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            TotalPerSecUD.Name = "TotalPerSecUD";
            TotalPerSecUD.Size = new Size(55, 23);
            TotalPerSecUD.TabIndex = 1;
            TotalPerSecUD.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(TotalPerSecUD, "Total pellet/packer connections.\r\nAppears in popup UI as \"Pellets\".");
            TotalPerSecUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TotalPerSecUD.ValueChanged += TotalPerSecUD_ValueChanged;
            // 
            // PayloadTypeDD
            // 
            PayloadTypeDD.DropDownStyle = ComboBoxStyle.DropDownList;
            PayloadTypeDD.FormattingEnabled = true;
            PayloadTypeDD.Location = new Point(73, 310);
            PayloadTypeDD.Name = "PayloadTypeDD";
            PayloadTypeDD.Size = new Size(100, 23);
            PayloadTypeDD.TabIndex = 5;
            ToolTip.SetToolTip(PayloadTypeDD, "Payload damage type");
            PayloadTypeDD.SelectedIndexChanged += PayloadTypeDD_SelectedIndexChanged;
            // 
            // ImpactAngleUD
            // 
            ImpactAngleUD.Location = new Point(118, 269);
            ImpactAngleUD.Maximum = new decimal(new int[] { 89, 0, 0, 0 });
            ImpactAngleUD.Name = "ImpactAngleUD";
            ImpactAngleUD.Size = new Size(55, 23);
            ImpactAngleUD.TabIndex = 4;
            ImpactAngleUD.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(ImpactAngleUD, "Impact angle, measured from perpendicular.\r\n0° is a direct hit; 89° is almost a miss.");
            ImpactAngleUD.Value = new decimal(new int[] { 45, 0, 0, 0 });
            ImpactAngleUD.ValueChanged += ImpactAngleUD_ValueChanged;
            // 
            // AddArmorLayerButton
            // 
            AddArmorLayerButton.Location = new Point(8, 110);
            AddArmorLayerButton.Name = "AddArmorLayerButton";
            AddArmorLayerButton.Size = new Size(45, 23);
            AddArmorLayerButton.TabIndex = 15;
            AddArmorLayerButton.Text = "Add";
            ToolTip.SetToolTip(AddArmorLayerButton, "Add selected layer to target\r\narmor configuration.");
            AddArmorLayerButton.UseVisualStyleBackColor = true;
            AddArmorLayerButton.Click += AddArmorLayerButton_Click;
            // 
            // DelArmorLayerButton
            // 
            DelArmorLayerButton.Location = new Point(105, 110);
            DelArmorLayerButton.Name = "DelArmorLayerButton";
            DelArmorLayerButton.Size = new Size(45, 23);
            DelArmorLayerButton.TabIndex = 16;
            DelArmorLayerButton.Text = "Del";
            ToolTip.SetToolTip(DelArmorLayerButton, "Remove most recently-added layer\r\nfrom target armor configuration.");
            DelArmorLayerButton.UseVisualStyleBackColor = true;
            DelArmorLayerButton.Click += DelArmorLayerButton_Click;
            // 
            // TargetArmorLB
            // 
            TargetArmorLB.FormattingEnabled = true;
            TargetArmorLB.ItemHeight = 15;
            TargetArmorLB.Location = new Point(8, 136);
            TargetArmorLB.Name = "TargetArmorLB";
            TargetArmorLB.Size = new Size(142, 244);
            TargetArmorLB.TabIndex = 3;
            TargetArmorLB.TabStop = false;
            ToolTip.SetToolTip(TargetArmorLB, "Target armor configuration.");
            // 
            // TargetArmorLayerDD
            // 
            TargetArmorLayerDD.DropDownStyle = ComboBoxStyle.DropDownList;
            TargetArmorLayerDD.FormattingEnabled = true;
            TargetArmorLayerDD.Location = new Point(8, 84);
            TargetArmorLayerDD.Name = "TargetArmorLayerDD";
            TargetArmorLayerDD.Size = new Size(142, 23);
            TargetArmorLayerDD.TabIndex = 14;
            ToolTip.SetToolTip(TargetArmorLayerDD, "Select an armor layer to add");
            // 
            // FuzeBoxPanel
            // 
            FuzeBoxPanel.BorderStyle = BorderStyle.FixedSingle;
            FuzeBoxPanel.Controls.Add(HollowPointCB);
            FuzeBoxPanel.Controls.Add(FuzeCountLabel);
            FuzeBoxPanel.Controls.Add(FuzeLabel);
            FuzeBoxPanel.Controls.Add(TimeFromImpactFuze);
            FuzeBoxPanel.Controls.Add(LowAltFuzeCB);
            FuzeBoxPanel.Controls.Add(PendepthFuzeCB);
            FuzeBoxPanel.Controls.Add(HighAltFuzeCB);
            FuzeBoxPanel.Controls.Add(InertialFuzeCB);
            FuzeBoxPanel.Controls.Add(TimeFromLaunchFuzeCB);
            FuzeBoxPanel.Location = new Point(202, 184);
            FuzeBoxPanel.Name = "FuzeBoxPanel";
            FuzeBoxPanel.Size = new Size(160, 218);
            FuzeBoxPanel.TabIndex = 10;
            // 
            // FuzeCountLabel
            // 
            FuzeCountLabel.AutoSize = true;
            FuzeCountLabel.Location = new Point(10, 164);
            FuzeCountLabel.Name = "FuzeCountLabel";
            FuzeCountLabel.Size = new Size(64, 15);
            FuzeCountLabel.TabIndex = 10;
            FuzeCountLabel.Text = "FuzeCount";
            // 
            // FuzeLabel
            // 
            FuzeLabel.AutoSize = true;
            FuzeLabel.Location = new Point(53, 10);
            FuzeLabel.Name = "FuzeLabel";
            FuzeLabel.Size = new Size(54, 15);
            FuzeLabel.TabIndex = 0;
            FuzeLabel.Text = "Fuze Box";
            // 
            // FiringPiecePanel
            // 
            FiringPiecePanel.BorderStyle = BorderStyle.FixedSingle;
            FiringPiecePanel.Controls.Add(ImpactAngleUD);
            FiringPiecePanel.Controls.Add(ImpactAngleLabel);
            FiringPiecePanel.Controls.Add(PayloadSecondaryLabel);
            FiringPiecePanel.Controls.Add(PayloadTypeDD);
            FiringPiecePanel.Controls.Add(TotalPerSecUD);
            FiringPiecePanel.Controls.Add(PayloadDamageLabel);
            FiringPiecePanel.Controls.Add(APLabel);
            FiringPiecePanel.Controls.Add(RawKDLabel);
            FiringPiecePanel.Controls.Add(PayloadPerSecLabel);
            FiringPiecePanel.Controls.Add(TotalPerSecLabel);
            FiringPiecePanel.Controls.Add(HardPerSecLabel);
            FiringPiecePanel.Controls.Add(HardPerSecUD);
            FiringPiecePanel.Controls.Add(ReloadTimeLabel);
            FiringPiecePanel.Controls.Add(PrepTimeLabel);
            FiringPiecePanel.Controls.Add(PackingTimeLabel);
            FiringPiecePanel.Controls.Add(MaxCapacityLabel);
            FiringPiecePanel.Controls.Add(CompactorLabel);
            FiringPiecePanel.Controls.Add(CompactorUD);
            FiringPiecePanel.Controls.Add(FiringPieceLabel);
            FiringPiecePanel.Controls.Add(GaugeLabel);
            FiringPiecePanel.Controls.Add(GaugeUD);
            FiringPiecePanel.Location = new Point(12, 12);
            FiringPiecePanel.Name = "FiringPiecePanel";
            FiringPiecePanel.Size = new Size(184, 390);
            FiringPiecePanel.TabIndex = 11;
            // 
            // ImpactAngleLabel
            // 
            ImpactAngleLabel.AutoSize = true;
            ImpactAngleLabel.Location = new Point(8, 272);
            ImpactAngleLabel.Name = "ImpactAngleLabel";
            ImpactAngleLabel.Size = new Size(92, 15);
            ImpactAngleLabel.TabIndex = 23;
            ImpactAngleLabel.Text = "Impact angle (°)";
            // 
            // PayloadSecondaryLabel
            // 
            PayloadSecondaryLabel.AutoSize = true;
            PayloadSecondaryLabel.Location = new Point(8, 360);
            PayloadSecondaryLabel.Name = "PayloadSecondaryLabel";
            PayloadSecondaryLabel.Size = new Size(104, 15);
            PayloadSecondaryLabel.TabIndex = 22;
            PayloadSecondaryLabel.Text = "PayloadSecondary";
            // 
            // PayloadDamageLabel
            // 
            PayloadDamageLabel.AutoSize = true;
            PayloadDamageLabel.Location = new Point(8, 338);
            PayloadDamageLabel.Name = "PayloadDamageLabel";
            PayloadDamageLabel.Size = new Size(93, 15);
            PayloadDamageLabel.TabIndex = 19;
            PayloadDamageLabel.Text = "PayloadDamage";
            // 
            // APLabel
            // 
            APLabel.AutoSize = true;
            APLabel.Location = new Point(8, 294);
            APLabel.Name = "APLabel";
            APLabel.Size = new Size(22, 15);
            APLabel.TabIndex = 18;
            APLabel.Text = "AP";
            // 
            // RawKDLabel
            // 
            RawKDLabel.AutoSize = true;
            RawKDLabel.Location = new Point(8, 250);
            RawKDLabel.Name = "RawKDLabel";
            RawKDLabel.Size = new Size(44, 15);
            RawKDLabel.TabIndex = 17;
            RawKDLabel.Text = "RawKD";
            // 
            // PayloadPerSecLabel
            // 
            PayloadPerSecLabel.AutoSize = true;
            PayloadPerSecLabel.Location = new Point(8, 110);
            PayloadPerSecLabel.Name = "PayloadPerSecLabel";
            PayloadPerSecLabel.Size = new Size(84, 15);
            PayloadPerSecLabel.TabIndex = 16;
            PayloadPerSecLabel.Text = "PayloadPerSec";
            // 
            // HardPerSecLabel
            // 
            HardPerSecLabel.AutoSize = true;
            HardPerSecLabel.Location = new Point(8, 84);
            HardPerSecLabel.Name = "HardPerSecLabel";
            HardPerSecLabel.Size = new Size(93, 15);
            HardPerSecLabel.TabIndex = 14;
            HardPerSecLabel.Text = "Hardener pellets";
            // 
            // ReloadTimeLabel
            // 
            ReloadTimeLabel.AutoSize = true;
            ReloadTimeLabel.Location = new Point(8, 206);
            ReloadTimeLabel.Name = "ReloadTimeLabel";
            ReloadTimeLabel.Size = new Size(69, 15);
            ReloadTimeLabel.TabIndex = 12;
            ReloadTimeLabel.Text = "ReloadTime";
            // 
            // PrepTimeLabel
            // 
            PrepTimeLabel.AutoSize = true;
            PrepTimeLabel.Location = new Point(8, 162);
            PrepTimeLabel.Name = "PrepTimeLabel";
            PrepTimeLabel.Size = new Size(57, 15);
            PrepTimeLabel.TabIndex = 11;
            PrepTimeLabel.Text = "PrepTime";
            // 
            // PackingTimeLabel
            // 
            PackingTimeLabel.AutoSize = true;
            PackingTimeLabel.Location = new Point(8, 184);
            PackingTimeLabel.Name = "PackingTimeLabel";
            PackingTimeLabel.Size = new Size(75, 15);
            PackingTimeLabel.TabIndex = 10;
            PackingTimeLabel.Text = "PackingTime";
            // 
            // MaxCapacityLabel
            // 
            MaxCapacityLabel.AutoSize = true;
            MaxCapacityLabel.Location = new Point(8, 228);
            MaxCapacityLabel.Name = "MaxCapacityLabel";
            MaxCapacityLabel.Size = new Size(76, 15);
            MaxCapacityLabel.TabIndex = 9;
            MaxCapacityLabel.Text = "MaxCapacity";
            // 
            // CompactorLabel
            // 
            CompactorLabel.AutoSize = true;
            CompactorLabel.Location = new Point(8, 136);
            CompactorLabel.Name = "CompactorLabel";
            CompactorLabel.Size = new Size(72, 15);
            CompactorLabel.TabIndex = 8;
            CompactorLabel.Text = "Compactors";
            // 
            // FiringPieceLabel
            // 
            FiringPieceLabel.AutoSize = true;
            FiringPieceLabel.Location = new Point(55, 8);
            FiringPieceLabel.Name = "FiringPieceLabel";
            FiringPieceLabel.Size = new Size(68, 15);
            FiringPieceLabel.TabIndex = 0;
            FiringPieceLabel.Text = "Firing Piece";
            // 
            // DetectionRangeLabel
            // 
            DetectionRangeLabel.AutoSize = true;
            DetectionRangeLabel.Location = new Point(8, 84);
            DetectionRangeLabel.Name = "DetectionRangeLabel";
            DetectionRangeLabel.Size = new Size(91, 15);
            DetectionRangeLabel.TabIndex = 6;
            DetectionRangeLabel.Text = "DetectionRange";
            // 
            // ShellSpeedLabel
            // 
            ShellSpeedLabel.AutoSize = true;
            ShellSpeedLabel.Location = new Point(8, 58);
            ShellSpeedLabel.Name = "ShellSpeedLabel";
            ShellSpeedLabel.Size = new Size(64, 15);
            ShellSpeedLabel.TabIndex = 5;
            ShellSpeedLabel.Text = "ShellSpeed";
            // 
            // BarrelPanel
            // 
            BarrelPanel.BorderStyle = BorderStyle.FixedSingle;
            BarrelPanel.Controls.Add(MaxDpsLabel);
            BarrelPanel.Controls.Add(ShellHealthLabel);
            BarrelPanel.Controls.Add(BarrelPanelLabel);
            BarrelPanel.Controls.Add(SuppressorBarrelCB);
            BarrelPanel.Controls.Add(ShellSpeedLabel);
            BarrelPanel.Controls.Add(DetectionRangeLabel);
            BarrelPanel.Location = new Point(202, 12);
            BarrelPanel.Name = "BarrelPanel";
            BarrelPanel.Size = new Size(160, 166);
            BarrelPanel.TabIndex = 12;
            // 
            // MaxDpsLabel
            // 
            MaxDpsLabel.AutoSize = true;
            MaxDpsLabel.Location = new Point(8, 136);
            MaxDpsLabel.Name = "MaxDpsLabel";
            MaxDpsLabel.Size = new Size(101, 15);
            MaxDpsLabel.TabIndex = 19;
            MaxDpsLabel.Text = "MaxIncomingDps";
            // 
            // ShellHealthLabel
            // 
            ShellHealthLabel.AutoSize = true;
            ShellHealthLabel.Location = new Point(8, 110);
            ShellHealthLabel.Name = "ShellHealthLabel";
            ShellHealthLabel.Size = new Size(67, 15);
            ShellHealthLabel.TabIndex = 18;
            ShellHealthLabel.Text = "ShellHealth";
            // 
            // BarrelPanelLabel
            // 
            BarrelPanelLabel.AutoSize = true;
            BarrelPanelLabel.Location = new Point(60, 10);
            BarrelPanelLabel.Name = "BarrelPanelLabel";
            BarrelPanelLabel.Size = new Size(37, 15);
            BarrelPanelLabel.TabIndex = 17;
            BarrelPanelLabel.Text = "Barrel";
            // 
            // TargetArmorPanel
            // 
            TargetArmorPanel.BorderStyle = BorderStyle.FixedSingle;
            TargetArmorPanel.Controls.Add(ExcessKDLabel);
            TargetArmorPanel.Controls.Add(KDToPenLabel);
            TargetArmorPanel.Controls.Add(TargetArmorLayerDD);
            TargetArmorPanel.Controls.Add(TargetArmorLB);
            TargetArmorPanel.Controls.Add(DelArmorLayerButton);
            TargetArmorPanel.Controls.Add(AddArmorLayerButton);
            TargetArmorPanel.Controls.Add(TargetArmorLabel);
            TargetArmorPanel.Location = new Point(368, 12);
            TargetArmorPanel.Name = "TargetArmorPanel";
            TargetArmorPanel.Size = new Size(160, 390);
            TargetArmorPanel.TabIndex = 13;
            // 
            // ExcessKDLabel
            // 
            ExcessKDLabel.AutoSize = true;
            ExcessKDLabel.Location = new Point(8, 58);
            ExcessKDLabel.Name = "ExcessKDLabel";
            ExcessKDLabel.Size = new Size(56, 15);
            ExcessKDLabel.TabIndex = 21;
            ExcessKDLabel.Text = "ExcessKD";
            // 
            // KDToPenLabel
            // 
            KDToPenLabel.AutoSize = true;
            KDToPenLabel.Location = new Point(8, 32);
            KDToPenLabel.Name = "KDToPenLabel";
            KDToPenLabel.Size = new Size(53, 15);
            KDToPenLabel.TabIndex = 20;
            KDToPenLabel.Text = "KDToPen";
            // 
            // TargetArmorLabel
            // 
            TargetArmorLabel.AutoSize = true;
            TargetArmorLabel.Location = new Point(3, 8);
            TargetArmorLabel.Name = "TargetArmorLabel";
            TargetArmorLabel.Size = new Size(153, 15);
            TargetArmorLabel.TabIndex = 0;
            TargetArmorLabel.Text = "Target Armor Configuration";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 412);
            Controls.Add(TargetArmorPanel);
            Controls.Add(BarrelPanel);
            Controls.Add(FiringPiecePanel);
            Controls.Add(FuzeBoxPanel);
            Name = "InputForm";
            Text = "CramCalcUI";
            ((System.ComponentModel.ISupportInitialize)GaugeUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompactorUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)HardPerSecUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalPerSecUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImpactAngleUD).EndInit();
            FuzeBoxPanel.ResumeLayout(false);
            FuzeBoxPanel.PerformLayout();
            FiringPiecePanel.ResumeLayout(false);
            FiringPiecePanel.PerformLayout();
            BarrelPanel.ResumeLayout(false);
            BarrelPanel.PerformLayout();
            TargetArmorPanel.ResumeLayout(false);
            TargetArmorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown GaugeUD;
        private Label GaugeLabel;
        private ToolTip ToolTip;
        private Label TotalPerSecLabel;
        private CheckBox HighAltFuzeCB;
        private CheckBox LowAltFuzeCB;
        private CheckBox TimeFromLaunchFuzeCB;
        private CheckBox InertialFuzeCB;
        private CheckBox PendepthFuzeCB;
        private CheckBox TimeFromImpactFuze;
        private Panel FuzeBoxPanel;
        private Label FuzeLabel;
        private CheckBox HollowPointCB;
        private Label FuzeCountLabel;
        private Panel FiringPiecePanel;
        private Label FiringPieceLabel;
        private Label DetectionRangeLabel;
        private Label ShellSpeedLabel;
        private CheckBox SuppressorBarrelCB;
        private Label CompactorLabel;
        private NumericUpDown CompactorUD;
        private Label MaxCapacityLabel;
        private Label ReloadTimeLabel;
        private Label PrepTimeLabel;
        private Label PackingTimeLabel;
        private Label PayloadPerSecLabel;
        private Label HardPerSecLabel;
        private NumericUpDown HardPerSecUD;
        private Panel BarrelPanel;
        private Label ShellHealthLabel;
        private Label BarrelPanelLabel;
        private Label PayloadDamageLabel;
        private Label APLabel;
        private Label RawKDLabel;
        private NumericUpDown TotalPerSecUD;
        private ComboBox PayloadTypeDD;
        private Label PayloadSecondaryLabel;
        private Label MaxDpsLabel;
        private NumericUpDown ImpactAngleUD;
        private Label ImpactAngleLabel;
        private Panel TargetArmorPanel;
        private Label TargetArmorLabel;
        private Label KDToPenLabel;
        private ComboBox TargetArmorLayerDD;
        private ListBox TargetArmorLB;
        private Button DelArmorLayerButton;
        private Button AddArmorLayerButton;
        private Label ExcessKDLabel;
    }
}