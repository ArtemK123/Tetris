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
            this.startBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gameboard = new System.Windows.Forms.PictureBox();
            this.nextFigureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerLabel.Location = new System.Drawing.Point(101, 6);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(84, 40);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Tetris\r\n";
            // 
            // startBotton
            // 
            this.startBotton.BackColor = System.Drawing.Color.White;
            this.startBotton.Location = new System.Drawing.Point(192, 287);
            this.startBotton.Name = "startBotton";
            this.startBotton.Size = new System.Drawing.Size(80, 23);
            this.startBotton.TabIndex = 2;
            this.startBotton.Text = "New game";
            this.startBotton.UseVisualStyleBackColor = false;
            this.startBotton.Click += new System.EventHandler(this.startBotton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Next Figure";
            // 
            // gameboard
            // 
            this.gameboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameboard.Location = new System.Drawing.Point(13, 42);
            this.gameboard.Name = "gameboard";
            this.gameboard.Size = new System.Drawing.Size(160, 320);
            this.gameboard.TabIndex = 4;
            this.gameboard.TabStop = false;
            // 
            // nextFigureBox
            // 
            this.nextFigureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextFigureBox.Location = new System.Drawing.Point(194, 60);
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
            this.scoreLabel.Location = new System.Drawing.Point(211, 159);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(46, 23);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score";
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.scoreBox.Location = new System.Drawing.Point(217, 182);
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
            this.gameoverLabel.Location = new System.Drawing.Point(190, 231);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(85, 23);
            this.gameoverLabel.TabIndex = 9;
            this.gameoverLabel.Text = "Game over!";
            this.gameoverLabel.Visible = false;
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.beachBackground1;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nextFigureBox);
            this.Controls.Add(this.gameboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBotton);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "TetrisForm";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.TetrisForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TetrisForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TetrisForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextFigureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button startBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gameboard;
        private System.Windows.Forms.PictureBox nextFigureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Label gameoverLabel;
    }
}

