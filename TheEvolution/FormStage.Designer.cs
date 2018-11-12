namespace TheEvolution {
    partial class FormStage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelTip = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.picBoxTargetInMap = new System.Windows.Forms.PictureBox();
            this.picBoxMap = new System.Windows.Forms.PictureBox();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelWall = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelControl = new System.Windows.Forms.Label();
            this.labelGoal = new System.Windows.Forms.Label();
            this.helpVirus = new System.Windows.Forms.PictureBox();
            this.helpShocker = new System.Windows.Forms.PictureBox();
            this.helpCompetitor = new System.Windows.Forms.PictureBox();
            this.helpPredator = new System.Windows.Forms.PictureBox();
            this.helpTracker = new System.Windows.Forms.PictureBox();
            this.helpFood1 = new System.Windows.Forms.PictureBox();
            this.helpPlantWall = new System.Windows.Forms.PictureBox();
            this.helpFood2 = new System.Windows.Forms.PictureBox();
            this.helpControl = new System.Windows.Forms.PictureBox();
            this.helpGoal = new System.Windows.Forms.PictureBox();
            this.picBoxGif = new System.Windows.Forms.PictureBox();
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            this.picBoxPause = new System.Windows.Forms.PictureBox();
            this.picBoxRestart = new System.Windows.Forms.PictureBox();
            this.picBoxEatBar = new System.Windows.Forms.PictureBox();
            this.picBoxEat = new System.Windows.Forms.PictureBox();
            this.picBoxHp = new System.Windows.Forms.PictureBox();
            this.picBoxHpBar = new System.Windows.Forms.PictureBox();
            this.picBoxPauseGif = new System.Windows.Forms.PictureBox();
            this.picBoxStage = new System.Windows.Forms.PictureBox();
            this.picBoxEvolveEffect = new System.Windows.Forms.PictureBox();
            this.timerEvolve = new System.Windows.Forms.Timer(this.components);
            this.panelTip.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTargetInMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).BeginInit();
            this.panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpShocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpCompetitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPredator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpFood1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPlantWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpFood2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEatBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPauseGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEvolveEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTip.Controls.Add(this.picBoxPauseGif);
            this.panelTip.Location = new System.Drawing.Point(529, 116);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(210, 149);
            this.panelTip.TabIndex = 5;
            this.panelTip.Visible = false;
            this.panelTip.Click += new System.EventHandler(this.panelTip_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Black;
            this.panelStatus.Controls.Add(this.picBoxEatBar);
            this.panelStatus.Controls.Add(this.picBoxEat);
            this.panelStatus.Controls.Add(this.picBoxHp);
            this.panelStatus.Controls.Add(this.picBoxHpBar);
            this.panelStatus.Location = new System.Drawing.Point(15, 24);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(572, 62);
            this.panelStatus.TabIndex = 6;
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Black;
            this.panelSetting.Controls.Add(this.picBoxHelp);
            this.panelSetting.Controls.Add(this.picBoxPause);
            this.panelSetting.Controls.Add(this.picBoxRestart);
            this.panelSetting.Location = new System.Drawing.Point(792, 16);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(232, 62);
            this.panelSetting.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Aqua;
            this.labelTime.Location = new System.Drawing.Point(613, 26);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 65);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            this.labelTime.Visible = false;
            // 
            // picBoxTargetInMap
            // 
            this.picBoxTargetInMap.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTargetInMap.Image = global::TheEvolution.Properties.Resources.ItemLocation;
            this.picBoxTargetInMap.Location = new System.Drawing.Point(31, 417);
            this.picBoxTargetInMap.Name = "picBoxTargetInMap";
            this.picBoxTargetInMap.Size = new System.Drawing.Size(38, 37);
            this.picBoxTargetInMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTargetInMap.TabIndex = 12;
            this.picBoxTargetInMap.TabStop = false;
            // 
            // picBoxMap
            // 
            this.picBoxMap.Image = global::TheEvolution.Properties.Resources.Map5;
            this.picBoxMap.Location = new System.Drawing.Point(15, 404);
            this.picBoxMap.Name = "picBoxMap";
            this.picBoxMap.Size = new System.Drawing.Size(173, 185);
            this.picBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMap.TabIndex = 11;
            this.picBoxMap.TabStop = false;
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.Silver;
            this.panelHelp.BackgroundImage = global::TheEvolution.Properties.Resources.TutorialPanel;
            this.panelHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHelp.Controls.Add(this.labelEnemy);
            this.panelHelp.Controls.Add(this.labelWall);
            this.panelHelp.Controls.Add(this.labelFood);
            this.panelHelp.Controls.Add(this.labelControl);
            this.panelHelp.Controls.Add(this.labelGoal);
            this.panelHelp.Controls.Add(this.helpVirus);
            this.panelHelp.Controls.Add(this.helpShocker);
            this.panelHelp.Controls.Add(this.helpCompetitor);
            this.panelHelp.Controls.Add(this.helpPredator);
            this.panelHelp.Controls.Add(this.helpTracker);
            this.panelHelp.Controls.Add(this.helpFood1);
            this.panelHelp.Controls.Add(this.helpPlantWall);
            this.panelHelp.Controls.Add(this.helpFood2);
            this.panelHelp.Controls.Add(this.helpControl);
            this.panelHelp.Controls.Add(this.helpGoal);
            this.panelHelp.Controls.Add(this.picBoxGif);
            this.panelHelp.Location = new System.Drawing.Point(792, 116);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(432, 501);
            this.panelHelp.TabIndex = 10;
            this.panelHelp.Visible = false;
            this.panelHelp.Click += new System.EventHandler(this.panelHelp_Click);
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemy.Location = new System.Drawing.Point(240, 459);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(108, 32);
            this.labelEnemy.TabIndex = 15;
            this.labelEnemy.Text = "Enemy";
            // 
            // labelWall
            // 
            this.labelWall.AutoSize = true;
            this.labelWall.BackColor = System.Drawing.Color.Transparent;
            this.labelWall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWall.Location = new System.Drawing.Point(240, 413);
            this.labelWall.Name = "labelWall";
            this.labelWall.Size = new System.Drawing.Size(74, 32);
            this.labelWall.TabIndex = 14;
            this.labelWall.Text = "Wall";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.BackColor = System.Drawing.Color.Transparent;
            this.labelFood.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(240, 360);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(84, 32);
            this.labelFood.TabIndex = 13;
            this.labelFood.Text = "Food";
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.BackColor = System.Drawing.Color.Transparent;
            this.labelControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl.Location = new System.Drawing.Point(240, 306);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(117, 32);
            this.labelControl.TabIndex = 12;
            this.labelControl.Text = "Control";
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.BackColor = System.Drawing.Color.Transparent;
            this.labelGoal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoal.ForeColor = System.Drawing.Color.Red;
            this.labelGoal.Location = new System.Drawing.Point(240, 262);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(79, 32);
            this.labelGoal.TabIndex = 11;
            this.labelGoal.Text = "Goal";
            // 
            // helpVirus
            // 
            this.helpVirus.BackColor = System.Drawing.Color.Black;
            this.helpVirus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpVirus.Image = global::TheEvolution.Properties.Resources.IconVirus;
            this.helpVirus.Location = new System.Drawing.Point(92, 306);
            this.helpVirus.Name = "helpVirus";
            this.helpVirus.Size = new System.Drawing.Size(58, 50);
            this.helpVirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpVirus.TabIndex = 10;
            this.helpVirus.TabStop = false;
            this.helpVirus.Click += new System.EventHandler(this.helpVirus_Click);
            // 
            // helpShocker
            // 
            this.helpShocker.BackColor = System.Drawing.Color.Black;
            this.helpShocker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpShocker.Image = global::TheEvolution.Properties.Resources.IconShocker;
            this.helpShocker.Location = new System.Drawing.Point(17, 306);
            this.helpShocker.Name = "helpShocker";
            this.helpShocker.Size = new System.Drawing.Size(58, 50);
            this.helpShocker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpShocker.TabIndex = 9;
            this.helpShocker.TabStop = false;
            this.helpShocker.Click += new System.EventHandler(this.helpShocker_Click);
            // 
            // helpCompetitor
            // 
            this.helpCompetitor.BackColor = System.Drawing.Color.Black;
            this.helpCompetitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpCompetitor.Image = global::TheEvolution.Properties.Resources.IconCompetitor;
            this.helpCompetitor.Location = new System.Drawing.Point(92, 250);
            this.helpCompetitor.Name = "helpCompetitor";
            this.helpCompetitor.Size = new System.Drawing.Size(58, 50);
            this.helpCompetitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpCompetitor.TabIndex = 8;
            this.helpCompetitor.TabStop = false;
            this.helpCompetitor.Click += new System.EventHandler(this.helpCompetitor_Click);
            // 
            // helpPredator
            // 
            this.helpPredator.BackColor = System.Drawing.Color.Black;
            this.helpPredator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpPredator.Image = global::TheEvolution.Properties.Resources.IconPredator;
            this.helpPredator.Location = new System.Drawing.Point(17, 250);
            this.helpPredator.Name = "helpPredator";
            this.helpPredator.Size = new System.Drawing.Size(58, 50);
            this.helpPredator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPredator.TabIndex = 7;
            this.helpPredator.TabStop = false;
            this.helpPredator.Click += new System.EventHandler(this.helpPredator_Click);
            // 
            // helpTracker
            // 
            this.helpTracker.BackColor = System.Drawing.Color.Black;
            this.helpTracker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpTracker.Image = global::TheEvolution.Properties.Resources.IconTracker;
            this.helpTracker.Location = new System.Drawing.Point(156, 250);
            this.helpTracker.Name = "helpTracker";
            this.helpTracker.Size = new System.Drawing.Size(58, 50);
            this.helpTracker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpTracker.TabIndex = 6;
            this.helpTracker.TabStop = false;
            this.helpTracker.Click += new System.EventHandler(this.helpTracker_Click);
            // 
            // helpFood1
            // 
            this.helpFood1.BackColor = System.Drawing.Color.Black;
            this.helpFood1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpFood1.Image = global::TheEvolution.Properties.Resources.IconAlgae;
            this.helpFood1.Location = new System.Drawing.Point(17, 138);
            this.helpFood1.Name = "helpFood1";
            this.helpFood1.Size = new System.Drawing.Size(58, 50);
            this.helpFood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpFood1.TabIndex = 5;
            this.helpFood1.TabStop = false;
            this.helpFood1.Click += new System.EventHandler(this.helpFood1_Click);
            // 
            // helpPlantWall
            // 
            this.helpPlantWall.BackColor = System.Drawing.Color.Black;
            this.helpPlantWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpPlantWall.Image = global::TheEvolution.Properties.Resources.IconPlantWall;
            this.helpPlantWall.Location = new System.Drawing.Point(17, 194);
            this.helpPlantWall.Name = "helpPlantWall";
            this.helpPlantWall.Size = new System.Drawing.Size(58, 50);
            this.helpPlantWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPlantWall.TabIndex = 4;
            this.helpPlantWall.TabStop = false;
            this.helpPlantWall.Click += new System.EventHandler(this.helpPlantWall_Click);
            // 
            // helpFood2
            // 
            this.helpFood2.BackColor = System.Drawing.Color.Black;
            this.helpFood2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpFood2.Image = global::TheEvolution.Properties.Resources.IconCharophyta;
            this.helpFood2.Location = new System.Drawing.Point(81, 138);
            this.helpFood2.Name = "helpFood2";
            this.helpFood2.Size = new System.Drawing.Size(58, 50);
            this.helpFood2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpFood2.TabIndex = 3;
            this.helpFood2.TabStop = false;
            this.helpFood2.Click += new System.EventHandler(this.helpFood2_Click);
            // 
            // helpControl
            // 
            this.helpControl.BackColor = System.Drawing.Color.Black;
            this.helpControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpControl.Image = global::TheEvolution.Properties.Resources.IconControl;
            this.helpControl.Location = new System.Drawing.Point(17, 68);
            this.helpControl.Name = "helpControl";
            this.helpControl.Size = new System.Drawing.Size(58, 50);
            this.helpControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpControl.TabIndex = 2;
            this.helpControl.TabStop = false;
            this.helpControl.Click += new System.EventHandler(this.helpControl_Click);
            // 
            // helpGoal
            // 
            this.helpGoal.BackColor = System.Drawing.Color.Black;
            this.helpGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpGoal.Image = global::TheEvolution.Properties.Resources.IconGoal;
            this.helpGoal.Location = new System.Drawing.Point(17, 12);
            this.helpGoal.Name = "helpGoal";
            this.helpGoal.Size = new System.Drawing.Size(58, 50);
            this.helpGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpGoal.TabIndex = 1;
            this.helpGoal.TabStop = false;
            this.helpGoal.Click += new System.EventHandler(this.helpGoal_Click);
            // 
            // picBoxGif
            // 
            this.picBoxGif.BackColor = System.Drawing.Color.Black;
            this.picBoxGif.Image = global::TheEvolution.Properties.Resources.Evolution;
            this.picBoxGif.Location = new System.Drawing.Point(157, 38);
            this.picBoxGif.Name = "picBoxGif";
            this.picBoxGif.Size = new System.Drawing.Size(272, 206);
            this.picBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGif.TabIndex = 0;
            this.picBoxGif.TabStop = false;
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxHelp.Image = global::TheEvolution.Properties.Resources.IconHlep;
            this.picBoxHelp.Location = new System.Drawing.Point(31, 4);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(50, 52);
            this.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHelp.TabIndex = 10;
            this.picBoxHelp.TabStop = false;
            this.picBoxHelp.Click += new System.EventHandler(this.picBoxHelp_Click);
            // 
            // picBoxPause
            // 
            this.picBoxPause.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxPause.Image = global::TheEvolution.Properties.Resources.IconPause;
            this.picBoxPause.Location = new System.Drawing.Point(104, 3);
            this.picBoxPause.Name = "picBoxPause";
            this.picBoxPause.Size = new System.Drawing.Size(50, 52);
            this.picBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPause.TabIndex = 4;
            this.picBoxPause.TabStop = false;
            this.picBoxPause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // picBoxRestart
            // 
            this.picBoxRestart.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxRestart.Image = global::TheEvolution.Properties.Resources.IconRestart;
            this.picBoxRestart.Location = new System.Drawing.Point(172, 0);
            this.picBoxRestart.Name = "picBoxRestart";
            this.picBoxRestart.Size = new System.Drawing.Size(46, 56);
            this.picBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRestart.TabIndex = 3;
            this.picBoxRestart.TabStop = false;
            this.picBoxRestart.Click += new System.EventHandler(this.picBoxRestart_Click);
            // 
            // picBoxEatBar
            // 
            this.picBoxEatBar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEatBar.Image = global::TheEvolution.Properties.Resources.Progressbar0;
            this.picBoxEatBar.Location = new System.Drawing.Point(400, 20);
            this.picBoxEatBar.Name = "picBoxEatBar";
            this.picBoxEatBar.Size = new System.Drawing.Size(129, 34);
            this.picBoxEatBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEatBar.TabIndex = 8;
            this.picBoxEatBar.TabStop = false;
            // 
            // picBoxEat
            // 
            this.picBoxEat.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEat.Image = global::TheEvolution.Properties.Resources.IconEat;
            this.picBoxEat.Location = new System.Drawing.Point(284, 8);
            this.picBoxEat.Name = "picBoxEat";
            this.picBoxEat.Size = new System.Drawing.Size(96, 56);
            this.picBoxEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEat.TabIndex = 7;
            this.picBoxEat.TabStop = false;
            // 
            // picBoxHp
            // 
            this.picBoxHp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHp.Image = global::TheEvolution.Properties.Resources.IconHP;
            this.picBoxHp.Location = new System.Drawing.Point(16, 4);
            this.picBoxHp.Name = "picBoxHp";
            this.picBoxHp.Size = new System.Drawing.Size(76, 50);
            this.picBoxHp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHp.TabIndex = 5;
            this.picBoxHp.TabStop = false;
            // 
            // picBoxHpBar
            // 
            this.picBoxHpBar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHpBar.Image = global::TheEvolution.Properties.Resources.Bloodbar5;
            this.picBoxHpBar.Location = new System.Drawing.Point(100, 20);
            this.picBoxHpBar.Name = "picBoxHpBar";
            this.picBoxHpBar.Size = new System.Drawing.Size(158, 34);
            this.picBoxHpBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHpBar.TabIndex = 6;
            this.picBoxHpBar.TabStop = false;
            // 
            // picBoxPauseGif
            // 
            this.picBoxPauseGif.BackColor = System.Drawing.SystemColors.ControlText;
            this.picBoxPauseGif.Image = global::TheEvolution.Properties.Resources.Pausegif;
            this.picBoxPauseGif.Location = new System.Drawing.Point(50, 68);
            this.picBoxPauseGif.Name = "picBoxPauseGif";
            this.picBoxPauseGif.Size = new System.Drawing.Size(100, 50);
            this.picBoxPauseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPauseGif.TabIndex = 13;
            this.picBoxPauseGif.TabStop = false;
            this.picBoxPauseGif.Visible = false;
            // 
            // picBoxStage
            // 
            this.picBoxStage.Location = new System.Drawing.Point(12, 103);
            this.picBoxStage.Name = "picBoxStage";
            this.picBoxStage.Size = new System.Drawing.Size(440, 278);
            this.picBoxStage.TabIndex = 2;
            this.picBoxStage.TabStop = false;
            // 
            // picBoxEvolveEffect
            // 
            this.picBoxEvolveEffect.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEvolveEffect.Image = global::TheEvolution.Properties.Resources.EvolveEffect;
            this.picBoxEvolveEffect.Location = new System.Drawing.Point(50, 154);
            this.picBoxEvolveEffect.Name = "picBoxEvolveEffect";
            this.picBoxEvolveEffect.Size = new System.Drawing.Size(57, 50);
            this.picBoxEvolveEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEvolveEffect.TabIndex = 13;
            this.picBoxEvolveEffect.TabStop = false;
            this.picBoxEvolveEffect.Visible = false;
            // 
            // timerEvolve
            // 
            this.timerEvolve.Interval = 2000;
            this.timerEvolve.Tick += new System.EventHandler(this.timerEvolve_Tick);
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1288, 665);
            this.Controls.Add(this.picBoxEvolveEffect);
            this.Controls.Add(this.picBoxTargetInMap);
            this.Controls.Add(this.picBoxMap);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.picBoxStage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStage";
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStage_KeyDown);
            this.panelTip.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTargetInMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMap)).EndInit();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpShocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpCompetitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPredator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpFood1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPlantWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpFood2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEatBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPauseGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEvolveEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox picBoxStage;
        private System.Windows.Forms.PictureBox picBoxRestart;
        private System.Windows.Forms.PictureBox picBoxPause;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.PictureBox picBoxEatBar;
        private System.Windows.Forms.PictureBox picBoxHpBar;
        private System.Windows.Forms.Panel panelSetting;
        internal System.Windows.Forms.PictureBox picBoxEat;
        internal System.Windows.Forms.PictureBox picBoxHp;
        internal System.Windows.Forms.Panel panelStatus;
        internal System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox picBoxHelp;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.PictureBox picBoxGif;
        private System.Windows.Forms.PictureBox helpVirus;
        private System.Windows.Forms.PictureBox helpShocker;
        private System.Windows.Forms.PictureBox helpCompetitor;
        private System.Windows.Forms.PictureBox helpPredator;
        private System.Windows.Forms.PictureBox helpTracker;
        private System.Windows.Forms.PictureBox helpFood1;
        private System.Windows.Forms.PictureBox helpPlantWall;
        private System.Windows.Forms.PictureBox helpFood2;
        private System.Windows.Forms.PictureBox helpControl;
        private System.Windows.Forms.PictureBox helpGoal;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelWall;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelControl;
        internal System.Windows.Forms.PictureBox picBoxMap;
        private System.Windows.Forms.PictureBox picBoxTargetInMap;
        private System.Windows.Forms.PictureBox picBoxPauseGif;
        private System.Windows.Forms.PictureBox picBoxEvolveEffect;
        private System.Windows.Forms.Timer timerEvolve;
    }
}