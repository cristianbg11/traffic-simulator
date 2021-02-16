namespace TSMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.Turn_timer = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.cmbxVehSelectSouth = new System.Windows.Forms.ComboBox();
            this.cmbxVehSelectWest = new System.Windows.Forms.ComboBox();
            this.cmbxVehSelectNorth = new System.Windows.Forms.ComboBox();
            this.cmbxVehSelectEast = new System.Windows.Forms.ComboBox();
            this.SouthCar3 = new System.Windows.Forms.PictureBox();
            this.SouthCar2 = new System.Windows.Forms.PictureBox();
            this.SouthCar1 = new System.Windows.Forms.PictureBox();
            this.WestCar3 = new System.Windows.Forms.PictureBox();
            this.WestCar2 = new System.Windows.Forms.PictureBox();
            this.WestCar1 = new System.Windows.Forms.PictureBox();
            this.NorthCar3 = new System.Windows.Forms.PictureBox();
            this.NorthCar2 = new System.Windows.Forms.PictureBox();
            this.NorthCar1 = new System.Windows.Forms.PictureBox();
            this.EastCar3 = new System.Windows.Forms.PictureBox();
            this.EastCar2 = new System.Windows.Forms.PictureBox();
            this.EastCar1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.EastovalShapeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.EastovalShapeYellow = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.EastovalShapeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.WesttovalShapeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.WesttovalShapeYellow = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.WesttovalShapeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.NorthtovalShapeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.NorthtovalShapeYellow = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.NorthtovalShapeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SouthtovalShapeGreen = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SouthtovalShapeYellow = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SouthtovalShapeRed = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // Turn_timer
            // 
            this.Turn_timer.Enabled = true;
            this.Turn_timer.Interval = 1000;
            this.Turn_timer.Tick += new System.EventHandler(this.Turn_timer_Tick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // cmbxVehSelectSouth
            // 
            this.cmbxVehSelectSouth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehSelectSouth.FormattingEnabled = true;
            this.cmbxVehSelectSouth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbxVehSelectSouth.Location = new System.Drawing.Point(299, 355);
            this.cmbxVehSelectSouth.Name = "cmbxVehSelectSouth";
            this.cmbxVehSelectSouth.Size = new System.Drawing.Size(51, 21);
            this.cmbxVehSelectSouth.TabIndex = 73;
            this.cmbxVehSelectSouth.SelectedIndexChanged += new System.EventHandler(this.cmbxVehSelectSouth_SelectedIndexChanged);
            // 
            // cmbxVehSelectWest
            // 
            this.cmbxVehSelectWest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehSelectWest.FormattingEnabled = true;
            this.cmbxVehSelectWest.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbxVehSelectWest.Location = new System.Drawing.Point(632, 345);
            this.cmbxVehSelectWest.Name = "cmbxVehSelectWest";
            this.cmbxVehSelectWest.Size = new System.Drawing.Size(51, 21);
            this.cmbxVehSelectWest.TabIndex = 72;
            this.cmbxVehSelectWest.SelectedIndexChanged += new System.EventHandler(this.cmbxVehSelectWest_SelectedIndexChanged);
            // 
            // cmbxVehSelectNorth
            // 
            this.cmbxVehSelectNorth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehSelectNorth.FormattingEnabled = true;
            this.cmbxVehSelectNorth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbxVehSelectNorth.Location = new System.Drawing.Point(552, 135);
            this.cmbxVehSelectNorth.Name = "cmbxVehSelectNorth";
            this.cmbxVehSelectNorth.Size = new System.Drawing.Size(51, 21);
            this.cmbxVehSelectNorth.TabIndex = 71;
            this.cmbxVehSelectNorth.SelectedIndexChanged += new System.EventHandler(this.cmbxVehSelectNorth_SelectedIndexChanged);
            // 
            // cmbxVehSelectEast
            // 
            this.cmbxVehSelectEast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehSelectEast.FormattingEnabled = true;
            this.cmbxVehSelectEast.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbxVehSelectEast.Location = new System.Drawing.Point(275, 197);
            this.cmbxVehSelectEast.Name = "cmbxVehSelectEast";
            this.cmbxVehSelectEast.Size = new System.Drawing.Size(51, 21);
            this.cmbxVehSelectEast.TabIndex = 70;
            this.cmbxVehSelectEast.SelectedIndexChanged += new System.EventHandler(this.cmbxVehSelectEast_SelectedIndexChanged);
            // 
            // SouthCar3
            // 
            this.SouthCar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SouthCar3.BackgroundImage")));
            this.SouthCar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SouthCar3.Location = new System.Drawing.Point(370, 517);
            this.SouthCar3.Name = "SouthCar3";
            this.SouthCar3.Size = new System.Drawing.Size(22, 50);
            this.SouthCar3.TabIndex = 68;
            this.SouthCar3.TabStop = false;
            this.SouthCar3.Visible = false;
            // 
            // SouthCar2
            // 
            this.SouthCar2.BackgroundImage = global::TSMS.Properties.Resources.up;
            this.SouthCar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SouthCar2.Location = new System.Drawing.Point(370, 462);
            this.SouthCar2.Name = "SouthCar2";
            this.SouthCar2.Size = new System.Drawing.Size(22, 50);
            this.SouthCar2.TabIndex = 67;
            this.SouthCar2.TabStop = false;
            this.SouthCar2.Visible = false;
            // 
            // SouthCar1
            // 
            this.SouthCar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SouthCar1.BackgroundImage")));
            this.SouthCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SouthCar1.Location = new System.Drawing.Point(370, 406);
            this.SouthCar1.Name = "SouthCar1";
            this.SouthCar1.Size = new System.Drawing.Size(22, 50);
            this.SouthCar1.TabIndex = 66;
            this.SouthCar1.TabStop = false;
            this.SouthCar1.Visible = false;
            // 
            // WestCar3
            // 
            this.WestCar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WestCar3.BackgroundImage")));
            this.WestCar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WestCar3.Location = new System.Drawing.Point(796, 312);
            this.WestCar3.Name = "WestCar3";
            this.WestCar3.Size = new System.Drawing.Size(54, 18);
            this.WestCar3.TabIndex = 64;
            this.WestCar3.TabStop = false;
            this.WestCar3.Visible = false;
            // 
            // WestCar2
            // 
            this.WestCar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WestCar2.BackgroundImage")));
            this.WestCar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WestCar2.Location = new System.Drawing.Point(736, 312);
            this.WestCar2.Name = "WestCar2";
            this.WestCar2.Size = new System.Drawing.Size(54, 18);
            this.WestCar2.TabIndex = 63;
            this.WestCar2.TabStop = false;
            this.WestCar2.Visible = false;
            // 
            // WestCar1
            // 
            this.WestCar1.BackgroundImage = global::TSMS.Properties.Resources.Left_Way;
            this.WestCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WestCar1.Location = new System.Drawing.Point(670, 312);
            this.WestCar1.Name = "WestCar1";
            this.WestCar1.Size = new System.Drawing.Size(54, 18);
            this.WestCar1.TabIndex = 62;
            this.WestCar1.TabStop = false;
            this.WestCar1.Visible = false;
            // 
            // NorthCar3
            // 
            this.NorthCar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NorthCar3.BackgroundImage")));
            this.NorthCar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NorthCar3.Location = new System.Drawing.Point(508, -11);
            this.NorthCar3.Name = "NorthCar3";
            this.NorthCar3.Size = new System.Drawing.Size(24, 49);
            this.NorthCar3.TabIndex = 60;
            this.NorthCar3.TabStop = false;
            this.NorthCar3.Visible = false;
            // 
            // NorthCar2
            // 
            this.NorthCar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NorthCar2.BackgroundImage")));
            this.NorthCar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NorthCar2.Location = new System.Drawing.Point(508, 47);
            this.NorthCar2.Name = "NorthCar2";
            this.NorthCar2.Size = new System.Drawing.Size(24, 49);
            this.NorthCar2.TabIndex = 59;
            this.NorthCar2.TabStop = false;
            this.NorthCar2.Visible = false;
            // 
            // NorthCar1
            // 
            this.NorthCar1.BackgroundImage = global::TSMS.Properties.Resources.Down;
            this.NorthCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NorthCar1.Location = new System.Drawing.Point(510, 100);
            this.NorthCar1.Name = "NorthCar1";
            this.NorthCar1.Size = new System.Drawing.Size(24, 49);
            this.NorthCar1.TabIndex = 58;
            this.NorthCar1.TabStop = false;
            this.NorthCar1.Visible = false;
            // 
            // EastCar3
            // 
            this.EastCar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EastCar3.BackgroundImage")));
            this.EastCar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EastCar3.Location = new System.Drawing.Point(46, 229);
            this.EastCar3.Name = "EastCar3";
            this.EastCar3.Size = new System.Drawing.Size(56, 19);
            this.EastCar3.TabIndex = 56;
            this.EastCar3.TabStop = false;
            this.EastCar3.Visible = false;
            // 
            // EastCar2
            // 
            this.EastCar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EastCar2.BackgroundImage")));
            this.EastCar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EastCar2.Location = new System.Drawing.Point(110, 229);
            this.EastCar2.Name = "EastCar2";
            this.EastCar2.Size = new System.Drawing.Size(56, 19);
            this.EastCar2.TabIndex = 55;
            this.EastCar2.TabStop = false;
            this.EastCar2.Visible = false;
            // 
            // EastCar1
            // 
            this.EastCar1.BackgroundImage = global::TSMS.Properties.Resources.Right;
            this.EastCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EastCar1.Location = new System.Drawing.Point(170, 229);
            this.EastCar1.Name = "EastCar1";
            this.EastCar1.Size = new System.Drawing.Size(56, 19);
            this.EastCar1.TabIndex = 54;
            this.EastCar1.TabStop = false;
            this.EastCar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(33, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 53;
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Green;
            this.BtnStart.Location = new System.Drawing.Point(69, 121);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(82, 47);
            this.BtnStart.TabIndex = 52;
            this.BtnStart.Text = "Iniciar";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 48;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 49;
            this.label4.Text = "0";
            // 
            // EastovalShapeRed
            // 
            this.EastovalShapeRed.BackColor = System.Drawing.Color.Red;
            this.EastovalShapeRed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.EastovalShapeRed.Location = new System.Drawing.Point(3, 36);
            this.EastovalShapeRed.Name = "EastovalShapeRed";
            this.EastovalShapeRed.Size = new System.Drawing.Size(15, 16);
            this.EastovalShapeRed.Visible = false;
            // 
            // EastovalShapeYellow
            // 
            this.EastovalShapeYellow.BackColor = System.Drawing.Color.Yellow;
            this.EastovalShapeYellow.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.EastovalShapeYellow.Location = new System.Drawing.Point(3, 19);
            this.EastovalShapeYellow.Name = "EastovalShapeYellow";
            this.EastovalShapeYellow.Size = new System.Drawing.Size(15, 16);
            this.EastovalShapeYellow.Visible = false;
            // 
            // EastovalShapeGreen
            // 
            this.EastovalShapeGreen.BackColor = System.Drawing.Color.Green;
            this.EastovalShapeGreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.EastovalShapeGreen.Location = new System.Drawing.Point(3, 2);
            this.EastovalShapeGreen.Name = "EastovalShapeGreen";
            this.EastovalShapeGreen.Size = new System.Drawing.Size(15, 16);
            this.EastovalShapeGreen.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(277, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(31, 86);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.EastovalShapeGreen,
            this.EastovalShapeYellow,
            this.EastovalShapeRed});
            this.shapeContainer2.Size = new System.Drawing.Size(25, 67);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.Location = new System.Drawing.Point(595, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(31, 86);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.WesttovalShapeGreen,
            this.WesttovalShapeYellow,
            this.WesttovalShapeRed});
            this.shapeContainer1.Size = new System.Drawing.Size(25, 67);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // WesttovalShapeGreen
            // 
            this.WesttovalShapeGreen.BackColor = System.Drawing.Color.Green;
            this.WesttovalShapeGreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.WesttovalShapeGreen.Location = new System.Drawing.Point(3, 35);
            this.WesttovalShapeGreen.Name = "WesttovalShapeGreen";
            this.WesttovalShapeGreen.Size = new System.Drawing.Size(15, 16);
            this.WesttovalShapeGreen.Visible = false;
            // 
            // WesttovalShapeYellow
            // 
            this.WesttovalShapeYellow.BackColor = System.Drawing.Color.Yellow;
            this.WesttovalShapeYellow.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.WesttovalShapeYellow.Location = new System.Drawing.Point(3, 19);
            this.WesttovalShapeYellow.Name = "WesttovalShapeYellow";
            this.WesttovalShapeYellow.Size = new System.Drawing.Size(15, 16);
            this.WesttovalShapeYellow.Visible = false;
            // 
            // WesttovalShapeRed
            // 
            this.WesttovalShapeRed.BackColor = System.Drawing.Color.Red;
            this.WesttovalShapeRed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.WesttovalShapeRed.Location = new System.Drawing.Point(3, 3);
            this.WesttovalShapeRed.Name = "WesttovalShapeRed";
            this.WesttovalShapeRed.Size = new System.Drawing.Size(15, 16);
            this.WesttovalShapeRed.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.shapeContainer3);
            this.groupBox3.Location = new System.Drawing.Point(471, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(69, 39);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.NorthtovalShapeGreen,
            this.NorthtovalShapeYellow,
            this.NorthtovalShapeRed});
            this.shapeContainer3.Size = new System.Drawing.Size(63, 20);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // NorthtovalShapeGreen
            // 
            this.NorthtovalShapeGreen.BackColor = System.Drawing.Color.Green;
            this.NorthtovalShapeGreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.NorthtovalShapeGreen.Location = new System.Drawing.Point(34, 0);
            this.NorthtovalShapeGreen.Name = "NorthtovalShapeGreen";
            this.NorthtovalShapeGreen.Size = new System.Drawing.Size(15, 16);
            this.NorthtovalShapeGreen.Visible = false;
            // 
            // NorthtovalShapeYellow
            // 
            this.NorthtovalShapeYellow.BackColor = System.Drawing.Color.Yellow;
            this.NorthtovalShapeYellow.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.NorthtovalShapeYellow.Location = new System.Drawing.Point(19, 0);
            this.NorthtovalShapeYellow.Name = "NorthtovalShapeYellow";
            this.NorthtovalShapeYellow.Size = new System.Drawing.Size(15, 16);
            this.NorthtovalShapeYellow.Visible = false;
            // 
            // NorthtovalShapeRed
            // 
            this.NorthtovalShapeRed.BackColor = System.Drawing.Color.Red;
            this.NorthtovalShapeRed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.NorthtovalShapeRed.Location = new System.Drawing.Point(3, 0);
            this.NorthtovalShapeRed.Name = "NorthtovalShapeRed";
            this.NorthtovalShapeRed.Size = new System.Drawing.Size(15, 16);
            this.NorthtovalShapeRed.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.shapeContainer4);
            this.groupBox4.Location = new System.Drawing.Point(380, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(69, 39);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SouthtovalShapeGreen,
            this.SouthtovalShapeYellow,
            this.SouthtovalShapeRed});
            this.shapeContainer4.Size = new System.Drawing.Size(63, 20);
            this.shapeContainer4.TabIndex = 0;
            this.shapeContainer4.TabStop = false;
            // 
            // SouthtovalShapeGreen
            // 
            this.SouthtovalShapeGreen.BackColor = System.Drawing.Color.Green;
            this.SouthtovalShapeGreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.SouthtovalShapeGreen.Location = new System.Drawing.Point(4, 0);
            this.SouthtovalShapeGreen.Name = "SouthtovalShapeGreen";
            this.SouthtovalShapeGreen.Size = new System.Drawing.Size(15, 16);
            this.SouthtovalShapeGreen.Visible = false;
            // 
            // SouthtovalShapeYellow
            // 
            this.SouthtovalShapeYellow.BackColor = System.Drawing.Color.Yellow;
            this.SouthtovalShapeYellow.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.SouthtovalShapeYellow.Location = new System.Drawing.Point(19, 0);
            this.SouthtovalShapeYellow.Name = "SouthtovalShapeYellow";
            this.SouthtovalShapeYellow.Size = new System.Drawing.Size(15, 16);
            this.SouthtovalShapeYellow.Visible = false;
            // 
            // SouthtovalShapeRed
            // 
            this.SouthtovalShapeRed.BackColor = System.Drawing.Color.Red;
            this.SouthtovalShapeRed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.SouthtovalShapeRed.Location = new System.Drawing.Point(34, 0);
            this.SouthtovalShapeRed.Name = "SouthtovalShapeRed";
            this.SouthtovalShapeRed.Size = new System.Drawing.Size(15, 16);
            this.SouthtovalShapeRed.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(105, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(123, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 84;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Yellow;
            this.BtnReset.Location = new System.Drawing.Point(169, 121);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(82, 47);
            this.BtnReset.TabIndex = 52;
            this.BtnReset.Text = "Reset Trafic";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TSMS.Properties.Resources.Main_cross_road_with_lights;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 593);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbxVehSelectSouth);
            this.Controls.Add(this.cmbxVehSelectWest);
            this.Controls.Add(this.cmbxVehSelectNorth);
            this.Controls.Add(this.cmbxVehSelectEast);
            this.Controls.Add(this.SouthCar3);
            this.Controls.Add(this.SouthCar2);
            this.Controls.Add(this.SouthCar1);
            this.Controls.Add(this.WestCar3);
            this.Controls.Add(this.WestCar2);
            this.Controls.Add(this.WestCar1);
            this.Controls.Add(this.NorthCar3);
            this.Controls.Add(this.NorthCar2);
            this.Controls.Add(this.NorthCar1);
            this.Controls.Add(this.EastCar3);
            this.Controls.Add(this.EastCar2);
            this.Controls.Add(this.EastCar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastCar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Turn_timer;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ComboBox cmbxVehSelectSouth;
        private System.Windows.Forms.ComboBox cmbxVehSelectWest;
        private System.Windows.Forms.ComboBox cmbxVehSelectNorth;
        private System.Windows.Forms.ComboBox cmbxVehSelectEast;
        private System.Windows.Forms.PictureBox SouthCar3;
        private System.Windows.Forms.PictureBox SouthCar2;
        private System.Windows.Forms.PictureBox SouthCar1;
        private System.Windows.Forms.PictureBox WestCar3;
        private System.Windows.Forms.PictureBox WestCar2;
        private System.Windows.Forms.PictureBox WestCar1;
        private System.Windows.Forms.PictureBox NorthCar3;
        private System.Windows.Forms.PictureBox NorthCar2;
        private System.Windows.Forms.PictureBox NorthCar1;
        private System.Windows.Forms.PictureBox EastCar3;
        private System.Windows.Forms.PictureBox EastCar2;
        private System.Windows.Forms.PictureBox EastCar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape EastovalShapeRed;
        private Microsoft.VisualBasic.PowerPacks.OvalShape EastovalShapeYellow;
        private Microsoft.VisualBasic.PowerPacks.OvalShape EastovalShapeGreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape WesttovalShapeGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape WesttovalShapeYellow;
        private Microsoft.VisualBasic.PowerPacks.OvalShape WesttovalShapeRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape NorthtovalShapeGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape NorthtovalShapeYellow;
        private Microsoft.VisualBasic.PowerPacks.OvalShape NorthtovalShapeRed;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SouthtovalShapeGreen;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SouthtovalShapeYellow;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SouthtovalShapeRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReset;
    }
}

