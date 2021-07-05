
namespace CloneOSU2
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pause_btn = new System.Windows.Forms.Button();
            this.exitGame_btn = new System.Windows.Forms.Button();
            this.scoreInfo_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.playerInfo_lbl = new System.Windows.Forms.Label();
            this.playerName_lbl = new System.Windows.Forms.Label();
            this.main_tmr = new System.Windows.Forms.Timer(this.components);
            this.redBackground_tmr = new System.Windows.Forms.Timer(this.components);
            this.commonCirclesAdd_tmr = new System.Windows.Forms.Timer(this.components);
            this.bombCirclesAdd_tmr = new System.Windows.Forms.Timer(this.components);
            this.healthCirclesAdd_tmr = new System.Windows.Forms.Timer(this.components);
            this.healthPointsInfo_lbl = new System.Windows.Forms.Label();
            this.healthPoints_lbl = new System.Windows.Forms.Label();
            this.paramsChange_tmr = new System.Windows.Forms.Timer(this.components);
            this.circlesChange_tmr = new System.Windows.Forms.Timer(this.components);
            this.moveCircles_tmr = new System.Windows.Forms.Timer(this.components);
            this.changeDirectionCircles_tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(13, 10);
            this.pause_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(95, 25);
            this.pause_btn.TabIndex = 0;
            this.pause_btn.Text = "Пауза";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // exitGame_btn
            // 
            this.exitGame_btn.Location = new System.Drawing.Point(113, 10);
            this.exitGame_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitGame_btn.Name = "exitGame_btn";
            this.exitGame_btn.Size = new System.Drawing.Size(95, 25);
            this.exitGame_btn.TabIndex = 1;
            this.exitGame_btn.Text = "Выход";
            this.exitGame_btn.UseVisualStyleBackColor = true;
            this.exitGame_btn.Click += new System.EventHandler(this.exitGame_btn_Click);
            // 
            // scoreInfo_lbl
            // 
            this.scoreInfo_lbl.AutoSize = true;
            this.scoreInfo_lbl.Location = new System.Drawing.Point(713, 14);
            this.scoreInfo_lbl.Name = "scoreInfo_lbl";
            this.scoreInfo_lbl.Size = new System.Drawing.Size(132, 17);
            this.scoreInfo_lbl.TabIndex = 2;
            this.scoreInfo_lbl.Text = "Количество очков:";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Enabled = false;
            this.score_lbl.Location = new System.Drawing.Point(902, 14);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(16, 17);
            this.score_lbl.TabIndex = 3;
            this.score_lbl.Text = "0";
            // 
            // playerInfo_lbl
            // 
            this.playerInfo_lbl.AutoSize = true;
            this.playerInfo_lbl.Location = new System.Drawing.Point(300, 14);
            this.playerInfo_lbl.Name = "playerInfo_lbl";
            this.playerInfo_lbl.Size = new System.Drawing.Size(50, 17);
            this.playerInfo_lbl.TabIndex = 4;
            this.playerInfo_lbl.Text = "Игрок:";
            // 
            // playerName_lbl
            // 
            this.playerName_lbl.AutoSize = true;
            this.playerName_lbl.Location = new System.Drawing.Point(360, 14);
            this.playerName_lbl.Name = "playerName_lbl";
            this.playerName_lbl.Size = new System.Drawing.Size(48, 17);
            this.playerName_lbl.TabIndex = 7;
            this.playerName_lbl.Text = "Player";
            // 
            // main_tmr
            // 
            this.main_tmr.Enabled = true;
            this.main_tmr.Interval = 10;
            this.main_tmr.Tick += new System.EventHandler(this.main_tmr_Tick);
            // 
            // redBackground_tmr
            // 
            this.redBackground_tmr.Interval = 250;
            this.redBackground_tmr.Tick += new System.EventHandler(this.redBackground_tmr_Tick);
            // 
            // commonCirclesAdd_tmr
            // 
            this.commonCirclesAdd_tmr.Interval = 1500;
            this.commonCirclesAdd_tmr.Tick += new System.EventHandler(this.commonCirclesAdd_tmr_Tick);
            // 
            // bombCirclesAdd_tmr
            // 
            this.bombCirclesAdd_tmr.Interval = 2500;
            this.bombCirclesAdd_tmr.Tick += new System.EventHandler(this.bombCirclesAdd_tmr_Tick);
            // 
            // healthCirclesAdd_tmr
            // 
            this.healthCirclesAdd_tmr.Interval = 5000;
            this.healthCirclesAdd_tmr.Tick += new System.EventHandler(this.healthCirclesAdd_tmr_Tick);
            // 
            // healthPointsInfo_lbl
            // 
            this.healthPointsInfo_lbl.AutoSize = true;
            this.healthPointsInfo_lbl.Location = new System.Drawing.Point(559, 14);
            this.healthPointsInfo_lbl.Name = "healthPointsInfo_lbl";
            this.healthPointsInfo_lbl.Size = new System.Drawing.Size(56, 17);
            this.healthPointsInfo_lbl.TabIndex = 8;
            this.healthPointsInfo_lbl.Text = "Жизни:";
            // 
            // healthPoints_lbl
            // 
            this.healthPoints_lbl.AutoSize = true;
            this.healthPoints_lbl.Location = new System.Drawing.Point(646, 14);
            this.healthPoints_lbl.Name = "healthPoints_lbl";
            this.healthPoints_lbl.Size = new System.Drawing.Size(16, 17);
            this.healthPoints_lbl.TabIndex = 9;
            this.healthPoints_lbl.Text = "3";
            // 
            // paramsChange_tmr
            // 
            this.paramsChange_tmr.Interval = 12000;
            this.paramsChange_tmr.Tick += new System.EventHandler(this.paramsChange_tmr_Tick);
            // 
            // circlesChange_tmr
            // 
            this.circlesChange_tmr.Interval = 200;
            this.circlesChange_tmr.Tick += new System.EventHandler(this.circlesChange_tmr_Tick);
            // 
            // moveCircles_tmr
            // 
            this.moveCircles_tmr.Enabled = true;
            this.moveCircles_tmr.Interval = 50;
            this.moveCircles_tmr.Tick += new System.EventHandler(this.moveCircles_tmr_Tick);
            // 
            // changeDirectionCircles_tmr
            // 
            this.changeDirectionCircles_tmr.Enabled = true;
            this.changeDirectionCircles_tmr.Interval = 500;
            this.changeDirectionCircles_tmr.Tick += new System.EventHandler(this.changeDirectionCircles_tmr_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1170, 657);
            this.Controls.Add(this.healthPoints_lbl);
            this.Controls.Add(this.healthPointsInfo_lbl);
            this.Controls.Add(this.playerName_lbl);
            this.Controls.Add(this.playerInfo_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.scoreInfo_lbl);
            this.Controls.Add(this.exitGame_btn);
            this.Controls.Add(this.pause_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Попытайтесь набрать наибольшее количество очков!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button exitGame_btn;
        private System.Windows.Forms.Label scoreInfo_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label playerInfo_lbl;
        private System.Windows.Forms.Label playerName_lbl;
        private System.Windows.Forms.Timer main_tmr;
        private System.Windows.Forms.Timer redBackground_tmr;
        private System.Windows.Forms.Timer commonCirclesAdd_tmr;
        private System.Windows.Forms.Timer bombCirclesAdd_tmr;
        private System.Windows.Forms.Timer healthCirclesAdd_tmr;
        private System.Windows.Forms.Label healthPointsInfo_lbl;
        private System.Windows.Forms.Label healthPoints_lbl;
        private System.Windows.Forms.Timer paramsChange_tmr;
        private System.Windows.Forms.Timer circlesChange_tmr;
        private System.Windows.Forms.Timer moveCircles_tmr;
        private System.Windows.Forms.Timer changeDirectionCircles_tmr;
    }
}