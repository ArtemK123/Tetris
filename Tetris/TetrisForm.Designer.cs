namespace Tetris
{
    partial class TetrisForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nextFigureLabel = new System.Windows.Forms.Label();
            this.boardBox = new System.Windows.Forms.PictureBox();
            this.nextFigureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.focusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerLabel.Location = new System.Drawing.Point(107, 2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(84, 40);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Tetris\r\n";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.CausesValidation = false;
            this.startButton.Location = new System.Drawing.Point(195, 278);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 23);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Text = "Нова гра";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nextFigureLabel
            // 
            this.nextFigureLabel.AutoSize = true;
            this.nextFigureLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextFigureLabel.Font = new System.Drawing.Font("Segoe Print", 8.75F);
            this.nextFigureLabel.Location = new System.Drawing.Point(169, 41);
            this.nextFigureLabel.Name = "nextFigureLabel";
            this.nextFigureLabel.Size = new System.Drawing.Size(121, 21);
            this.nextFigureLabel.TabIndex = 3;
            this.nextFigureLabel.Text = "Наступна фігура";
            // 
            // boardBox
            // 
            this.boardBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.boardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardBox.Location = new System.Drawing.Point(13, 42);
            this.boardBox.Name = "boardBox";
            this.boardBox.Size = new System.Drawing.Size(160, 320);
            this.boardBox.TabIndex = 4;
            this.boardBox.TabStop = false;
            // 
            // nextFigureBox
            // 
            this.nextFigureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextFigureBox.Location = new System.Drawing.Point(201, 64);
            this.nextFigureBox.Name = "nextFigureBox";
            this.nextFigureBox.Size = new System.Drawing.Size(64, 64);
            this.nextFigureBox.TabIndex = 5;
            this.nextFigureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 225;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.scoreLabel.Location = new System.Drawing.Point(208, 158);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(64, 23);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Рахунок";
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.scoreBox.Location = new System.Drawing.Point(232, 181);
            this.scoreBox.MinimumSize = new System.Drawing.Size(40, 0);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(40, 16);
            this.scoreBox.TabIndex = 8;
            this.scoreBox.Text = "0";
            this.scoreBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverLabel.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.gameoverLabel.Location = new System.Drawing.Point(190, 238);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(85, 23);
            this.gameoverLabel.TabIndex = 9;
            this.gameoverLabel.Text = "Game over!";
            this.gameoverLabel.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(195, 336);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(80, 23);
            this.helpButton.TabIndex = 11;
            this.helpButton.TabStop = false;
            this.helpButton.Text = "Довідка";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.CausesValidation = false;
            this.pauseButton.Location = new System.Drawing.Point(195, 307);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(80, 23);
            this.pauseButton.TabIndex = 12;
            this.pauseButton.TabStop = false;
            this.pauseButton.Text = "Пауза";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // focusLabel
            // 
            this.focusLabel.AutoSize = true;
            this.focusLabel.Location = new System.Drawing.Point(221, 206);
            this.focusLabel.Name = "focusLabel";
            this.focusLabel.Size = new System.Drawing.Size(0, 13);
            this.focusLabel.TabIndex = 13;
            this.focusLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.focusLabel_PreviewKeyDown);
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.beachBackground1;
            this.ClientSize = new System.Drawing.Size(289, 381);
            this.Controls.Add(this.focusLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nextFigureBox);
            this.Controls.Add(this.boardBox);
            this.Controls.Add(this.nextFigureLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "TetrisForm";
            this.Text = "Tetris";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TetrisForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.boardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label nextFigureLabel;
        private System.Windows.Forms.PictureBox boardBox;
        private System.Windows.Forms.PictureBox nextFigureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label focusLabel;
    }
}

