namespace LifeSim
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.numGameSpeed = new System.Windows.Forms.NumericUpDown();
            this.labGameSpeed = new System.Windows.Forms.Label();
            this.bPause = new System.Windows.Forms.Button();
            this.labGenerationNum = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.labSettings = new System.Windows.Forms.Label();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.labPopulationSize = new System.Windows.Forms.Label();
            this.numCellSize = new System.Windows.Forms.NumericUpDown();
            this.labCellSize = new System.Windows.Forms.Label();
            this.gameWorld = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGameSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.gameWorld);
            this.splitContainerMain.Size = new System.Drawing.Size(1240, 617);
            this.splitContainerMain.SplitterDistance = 216;
            this.splitContainerMain.TabIndex = 0;
            // 
            // numGameSpeed
            // 
            this.numGameSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGameSpeed.Location = new System.Drawing.Point(14, 206);
            this.numGameSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGameSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGameSpeed.Name = "numGameSpeed";
            this.numGameSpeed.Size = new System.Drawing.Size(45, 22);
            this.numGameSpeed.TabIndex = 10;
            this.numGameSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGameSpeed.ValueChanged += new System.EventHandler(this.numGameSpeed_Changed);
            // 
            // labGameSpeed
            // 
            this.labGameSpeed.AutoSize = true;
            this.labGameSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labGameSpeed.Location = new System.Drawing.Point(10, 180);
            this.labGameSpeed.Name = "labGameSpeed";
            this.labGameSpeed.Size = new System.Drawing.Size(132, 23);
            this.labGameSpeed.TabIndex = 9;
            this.labGameSpeed.Text = "Скорость игры:";
            // 
            // bPause
            // 
            this.bPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bPause.Enabled = false;
            this.bPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPause.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bPause.Location = new System.Drawing.Point(33, 157);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(150, 60);
            this.bPause.TabIndex = 8;
            this.bPause.Text = "Пауза";
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // labGenerationNum
            // 
            this.labGenerationNum.AutoSize = true;
            this.labGenerationNum.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labGenerationNum.Location = new System.Drawing.Point(10, 30);
            this.labGenerationNum.Name = "labGenerationNum";
            this.labGenerationNum.Size = new System.Drawing.Size(174, 23);
            this.labGenerationNum.TabIndex = 7;
            this.labGenerationNum.Text = "Номер поколения: 0";
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bStop.Enabled = false;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(58, 223);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(100, 60);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Стоп";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.LimeGreen;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bStart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bStart.Location = new System.Drawing.Point(58, 91);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(100, 60);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // labSettings
            // 
            this.labSettings.AutoSize = true;
            this.labSettings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSettings.Location = new System.Drawing.Point(58, 7);
            this.labSettings.Name = "labSettings";
            this.labSettings.Size = new System.Drawing.Size(100, 23);
            this.labSettings.TabIndex = 4;
            this.labSettings.Text = "Настройки:";
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPopulationSize.Location = new System.Drawing.Point(14, 138);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(45, 22);
            this.numPopulationSize.TabIndex = 3;
            this.numPopulationSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labPopulationSize
            // 
            this.labPopulationSize.AutoSize = true;
            this.labPopulationSize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPopulationSize.Location = new System.Drawing.Point(10, 112);
            this.labPopulationSize.Name = "labPopulationSize";
            this.labPopulationSize.Size = new System.Drawing.Size(189, 23);
            this.labPopulationSize.TabIndex = 2;
            this.labPopulationSize.Text = "Плотность популяции:";
            // 
            // numCellSize
            // 
            this.numCellSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCellSize.Location = new System.Drawing.Point(14, 70);
            this.numCellSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCellSize.Name = "numCellSize";
            this.numCellSize.Size = new System.Drawing.Size(45, 22);
            this.numCellSize.TabIndex = 1;
            this.numCellSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labCellSize
            // 
            this.labCellSize.AutoSize = true;
            this.labCellSize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCellSize.Location = new System.Drawing.Point(10, 44);
            this.labCellSize.Name = "labCellSize";
            this.labCellSize.Size = new System.Drawing.Size(132, 23);
            this.labCellSize.TabIndex = 0;
            this.labCellSize.Text = "Размер клетки:";
            // 
            // gameWorld
            // 
            this.gameWorld.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gameWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameWorld.Location = new System.Drawing.Point(0, 0);
            this.gameWorld.Name = "gameWorld";
            this.gameWorld.Size = new System.Drawing.Size(1016, 613);
            this.gameWorld.TabIndex = 0;
            this.gameWorld.TabStop = false;
            this.gameWorld.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gameWorld_MouseMove);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labCellSize);
            this.splitContainer1.Panel1.Controls.Add(this.numGameSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.numCellSize);
            this.splitContainer1.Panel1.Controls.Add(this.labGameSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.labPopulationSize);
            this.splitContainer1.Panel1.Controls.Add(this.labSettings);
            this.splitContainer1.Panel1.Controls.Add(this.numPopulationSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bPause);
            this.splitContainer1.Panel2.Controls.Add(this.bStart);
            this.splitContainer1.Panel2.Controls.Add(this.bStop);
            this.splitContainer1.Panel2.Controls.Add(this.labGenerationNum);
            this.splitContainer1.Size = new System.Drawing.Size(216, 617);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 617);
            this.Controls.Add(this.splitContainerMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Simulation The Game";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGameSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameWorld)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.NumericUpDown numCellSize;
        private System.Windows.Forms.Label labCellSize;
        private System.Windows.Forms.PictureBox gameWorld;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.Label labPopulationSize;
        private System.Windows.Forms.Label labSettings;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labGenerationNum;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Label labGameSpeed;
        private System.Windows.Forms.NumericUpDown numGameSpeed;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

