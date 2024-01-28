namespace RacingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundPB = new System.Windows.Forms.PictureBox();
            this.CarPB = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundSecondPB = new System.Windows.Forms.PictureBox();
            this.enemyFirstPB = new System.Windows.Forms.PictureBox();
            this.enemySecondPB = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.RestartBT = new System.Windows.Forms.Button();
            this.MoneyPB = new System.Windows.Forms.PictureBox();
            this.MoneyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSecondPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyFirstPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySecondPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPB)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPB
            // 
            this.backgroundPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backgroundPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundPB.BackgroundImage")));
            this.backgroundPB.Location = new System.Drawing.Point(0, 0);
            this.backgroundPB.Name = "backgroundPB";
            this.backgroundPB.Size = new System.Drawing.Size(840, 650);
            this.backgroundPB.TabIndex = 0;
            this.backgroundPB.TabStop = false;
            // 
            // CarPB
            // 
            this.CarPB.BackColor = System.Drawing.Color.Transparent;
            this.CarPB.Image = ((System.Drawing.Image)(resources.GetObject("CarPB.Image")));
            this.CarPB.Location = new System.Drawing.Point(427, 510);
            this.CarPB.Name = "CarPB";
            this.CarPB.Size = new System.Drawing.Size(99, 128);
            this.CarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPB.TabIndex = 1;
            this.CarPB.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundSecondPB
            // 
            this.backgroundSecondPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundSecondPB.BackgroundImage")));
            this.backgroundSecondPB.Location = new System.Drawing.Point(0, -650);
            this.backgroundSecondPB.Name = "backgroundSecondPB";
            this.backgroundSecondPB.Size = new System.Drawing.Size(840, 650);
            this.backgroundSecondPB.TabIndex = 2;
            this.backgroundSecondPB.TabStop = false;
            // 
            // enemyFirstPB
            // 
            this.enemyFirstPB.BackColor = System.Drawing.Color.Transparent;
            this.enemyFirstPB.Image = ((System.Drawing.Image)(resources.GetObject("enemyFirstPB.Image")));
            this.enemyFirstPB.Location = new System.Drawing.Point(185, -130);
            this.enemyFirstPB.Name = "enemyFirstPB";
            this.enemyFirstPB.Size = new System.Drawing.Size(101, 128);
            this.enemyFirstPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyFirstPB.TabIndex = 3;
            this.enemyFirstPB.TabStop = false;
            // 
            // enemySecondPB
            // 
            this.enemySecondPB.BackColor = System.Drawing.Color.Transparent;
            this.enemySecondPB.Image = ((System.Drawing.Image)(resources.GetObject("enemySecondPB.Image")));
            this.enemySecondPB.Location = new System.Drawing.Point(525, -400);
            this.enemySecondPB.Name = "enemySecondPB";
            this.enemySecondPB.Size = new System.Drawing.Size(101, 128);
            this.enemySecondPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemySecondPB.TabIndex = 4;
            this.enemySecondPB.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Red;
            this.labelLose.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLose.Location = new System.Drawing.Point(297, 253);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(250, 41);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "Вы проиграли";
            // 
            // RestartBT
            // 
            this.RestartBT.BackColor = System.Drawing.Color.Red;
            this.RestartBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartBT.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartBT.Location = new System.Drawing.Point(323, 308);
            this.RestartBT.Name = "RestartBT";
            this.RestartBT.Size = new System.Drawing.Size(213, 47);
            this.RestartBT.TabIndex = 6;
            this.RestartBT.Text = "Перезапустить";
            this.RestartBT.UseVisualStyleBackColor = false;
            this.RestartBT.Click += new System.EventHandler(this.RestartBT_Click);
            // 
            // MoneyPB
            // 
            this.MoneyPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoneyPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoneyPB.BackgroundImage")));
            this.MoneyPB.Image = ((System.Drawing.Image)(resources.GetObject("MoneyPB.Image")));
            this.MoneyPB.Location = new System.Drawing.Point(435, -550);
            this.MoneyPB.Name = "MoneyPB";
            this.MoneyPB.Size = new System.Drawing.Size(32, 32);
            this.MoneyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoneyPB.TabIndex = 7;
            this.MoneyPB.TabStop = false;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.Color.Red;
            this.MoneyLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MoneyLabel.Location = new System.Drawing.Point(12, 9);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(134, 32);
            this.MoneyLabel.TabIndex = 8;
            this.MoneyLabel.Text = "Монеты: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.MoneyPB);
            this.Controls.Add(this.RestartBT);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemySecondPB);
            this.Controls.Add(this.enemyFirstPB);
            this.Controls.Add(this.CarPB);
            this.Controls.Add(this.backgroundPB);
            this.Controls.Add(this.backgroundSecondPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSecondPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyFirstPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemySecondPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPB;
        private System.Windows.Forms.PictureBox CarPB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox backgroundSecondPB;
        private System.Windows.Forms.PictureBox enemyFirstPB;
        private System.Windows.Forms.PictureBox enemySecondPB;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button RestartBT;
        private System.Windows.Forms.PictureBox MoneyPB;
        private System.Windows.Forms.Label MoneyLabel;
    }
}

