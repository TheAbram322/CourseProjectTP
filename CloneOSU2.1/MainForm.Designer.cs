
namespace CloneOSU2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel_pnl = new System.Windows.Forms.Panel();
            this.nameInfo_lbl = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.rating_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.setup_btn = new System.Windows.Forms.Button();
            this.infoPanel_pnl = new System.Windows.Forms.Panel();
            this.exitInfo_btn = new System.Windows.Forms.Button();
            this.info_rtb = new System.Windows.Forms.RichTextBox();
            this.ratingPanel_pnl = new System.Windows.Forms.Panel();
            this.exitRating_btn = new System.Windows.Forms.Button();
            this.rating_rtb = new System.Windows.Forms.RichTextBox();
            this.setupPanel_pnl = new System.Windows.Forms.Panel();
            this.exitSetup_btn = new System.Windows.Forms.Button();
            this.changeBackground_btn = new System.Windows.Forms.Button();
            this.changeMusic_btn = new System.Windows.Forms.Button();
            this.backgroundPath_tb = new System.Windows.Forms.TextBox();
            this.musicPath_tb = new System.Windows.Forms.TextBox();
            this.backgroundPathInfo_lbl = new System.Windows.Forms.Label();
            this.musicPathInfo_lbl = new System.Windows.Forms.Label();
            this.turnOnOffMusic_btn = new System.Windows.Forms.Button();
            this.musicMode_lbl = new System.Windows.Forms.Label();
            this.musicModeInfo_lbl = new System.Windows.Forms.Label();
            this.mainPanel_pnl.SuspendLayout();
            this.infoPanel_pnl.SuspendLayout();
            this.ratingPanel_pnl.SuspendLayout();
            this.setupPanel_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel_pnl
            // 
            this.mainPanel_pnl.Controls.Add(this.nameInfo_lbl);
            this.mainPanel_pnl.Controls.Add(this.name_tb);
            this.mainPanel_pnl.Controls.Add(this.exit_btn);
            this.mainPanel_pnl.Controls.Add(this.rating_btn);
            this.mainPanel_pnl.Controls.Add(this.start_btn);
            this.mainPanel_pnl.Controls.Add(this.info_btn);
            this.mainPanel_pnl.Controls.Add(this.setup_btn);
            this.mainPanel_pnl.Location = new System.Drawing.Point(14, 12);
            this.mainPanel_pnl.Name = "mainPanel_pnl";
            this.mainPanel_pnl.Size = new System.Drawing.Size(658, 92);
            this.mainPanel_pnl.TabIndex = 0;
            // 
            // nameInfo_lbl
            // 
            this.nameInfo_lbl.AutoSize = true;
            this.nameInfo_lbl.Location = new System.Drawing.Point(198, 12);
            this.nameInfo_lbl.Name = "nameInfo_lbl";
            this.nameInfo_lbl.Size = new System.Drawing.Size(107, 17);
            this.nameInfo_lbl.TabIndex = 6;
            this.nameInfo_lbl.Text = "Выберите имя:";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(320, 9);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(117, 22);
            this.name_tb.TabIndex = 5;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(514, 56);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(135, 30);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // rating_btn
            // 
            this.rating_btn.Location = new System.Drawing.Point(514, 9);
            this.rating_btn.Name = "rating_btn";
            this.rating_btn.Size = new System.Drawing.Size(135, 30);
            this.rating_btn.TabIndex = 3;
            this.rating_btn.Text = "Рейтинг";
            this.rating_btn.UseVisualStyleBackColor = true;
            this.rating_btn.Click += new System.EventHandler(this.rating_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(269, 56);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(125, 30);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Играть";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(10, 56);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(125, 30);
            this.info_btn.TabIndex = 1;
            this.info_btn.Text = "Справка";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // setup_btn
            // 
            this.setup_btn.Location = new System.Drawing.Point(10, 9);
            this.setup_btn.Name = "setup_btn";
            this.setup_btn.Size = new System.Drawing.Size(125, 30);
            this.setup_btn.TabIndex = 0;
            this.setup_btn.Text = "Настройки";
            this.setup_btn.UseVisualStyleBackColor = true;
            this.setup_btn.Click += new System.EventHandler(this.setup_btn_Click);
            // 
            // infoPanel_pnl
            // 
            this.infoPanel_pnl.Controls.Add(this.exitInfo_btn);
            this.infoPanel_pnl.Controls.Add(this.info_rtb);
            this.infoPanel_pnl.Location = new System.Drawing.Point(724, 12);
            this.infoPanel_pnl.Name = "infoPanel_pnl";
            this.infoPanel_pnl.Size = new System.Drawing.Size(399, 295);
            this.infoPanel_pnl.TabIndex = 1;
            this.infoPanel_pnl.Visible = false;
            // 
            // exitInfo_btn
            // 
            this.exitInfo_btn.Location = new System.Drawing.Point(162, 264);
            this.exitInfo_btn.Name = "exitInfo_btn";
            this.exitInfo_btn.Size = new System.Drawing.Size(75, 25);
            this.exitInfo_btn.TabIndex = 1;
            this.exitInfo_btn.Text = "Выход";
            this.exitInfo_btn.UseVisualStyleBackColor = true;
            this.exitInfo_btn.Click += new System.EventHandler(this.exitInfo_btn_Click);
            // 
            // info_rtb
            // 
            this.info_rtb.Location = new System.Drawing.Point(13, 13);
            this.info_rtb.Name = "info_rtb";
            this.info_rtb.ReadOnly = true;
            this.info_rtb.Size = new System.Drawing.Size(375, 245);
            this.info_rtb.TabIndex = 0;
            this.info_rtb.Text = resources.GetString("info_rtb.Text");
            // 
            // ratingPanel_pnl
            // 
            this.ratingPanel_pnl.Controls.Add(this.exitRating_btn);
            this.ratingPanel_pnl.Controls.Add(this.rating_rtb);
            this.ratingPanel_pnl.Location = new System.Drawing.Point(14, 468);
            this.ratingPanel_pnl.Name = "ratingPanel_pnl";
            this.ratingPanel_pnl.Size = new System.Drawing.Size(229, 396);
            this.ratingPanel_pnl.TabIndex = 2;
            this.ratingPanel_pnl.Visible = false;
            // 
            // exitRating_btn
            // 
            this.exitRating_btn.Location = new System.Drawing.Point(77, 360);
            this.exitRating_btn.Name = "exitRating_btn";
            this.exitRating_btn.Size = new System.Drawing.Size(75, 25);
            this.exitRating_btn.TabIndex = 1;
            this.exitRating_btn.Text = "Выход";
            this.exitRating_btn.UseVisualStyleBackColor = true;
            this.exitRating_btn.Click += new System.EventHandler(this.exitRating_btn_Click);
            // 
            // rating_rtb
            // 
            this.rating_rtb.Location = new System.Drawing.Point(4, 4);
            this.rating_rtb.Name = "rating_rtb";
            this.rating_rtb.ReadOnly = true;
            this.rating_rtb.Size = new System.Drawing.Size(222, 350);
            this.rating_rtb.TabIndex = 0;
            this.rating_rtb.Text = "";
            // 
            // setupPanel_pnl
            // 
            this.setupPanel_pnl.Controls.Add(this.exitSetup_btn);
            this.setupPanel_pnl.Controls.Add(this.changeBackground_btn);
            this.setupPanel_pnl.Controls.Add(this.changeMusic_btn);
            this.setupPanel_pnl.Controls.Add(this.backgroundPath_tb);
            this.setupPanel_pnl.Controls.Add(this.musicPath_tb);
            this.setupPanel_pnl.Controls.Add(this.backgroundPathInfo_lbl);
            this.setupPanel_pnl.Controls.Add(this.musicPathInfo_lbl);
            this.setupPanel_pnl.Controls.Add(this.turnOnOffMusic_btn);
            this.setupPanel_pnl.Controls.Add(this.musicMode_lbl);
            this.setupPanel_pnl.Controls.Add(this.musicModeInfo_lbl);
            this.setupPanel_pnl.Location = new System.Drawing.Point(283, 469);
            this.setupPanel_pnl.Name = "setupPanel_pnl";
            this.setupPanel_pnl.Size = new System.Drawing.Size(630, 125);
            this.setupPanel_pnl.TabIndex = 3;
            this.setupPanel_pnl.Visible = false;
            // 
            // exitSetup_btn
            // 
            this.exitSetup_btn.Location = new System.Drawing.Point(273, 96);
            this.exitSetup_btn.Name = "exitSetup_btn";
            this.exitSetup_btn.Size = new System.Drawing.Size(75, 25);
            this.exitSetup_btn.TabIndex = 2;
            this.exitSetup_btn.Text = "Выход";
            this.exitSetup_btn.UseVisualStyleBackColor = true;
            this.exitSetup_btn.Click += new System.EventHandler(this.exitSetup_btn_Click);
            // 
            // changeBackground_btn
            // 
            this.changeBackground_btn.Location = new System.Drawing.Point(545, 67);
            this.changeBackground_btn.Name = "changeBackground_btn";
            this.changeBackground_btn.Size = new System.Drawing.Size(75, 25);
            this.changeBackground_btn.TabIndex = 8;
            this.changeBackground_btn.Text = "Обзор";
            this.changeBackground_btn.UseVisualStyleBackColor = true;
            this.changeBackground_btn.Click += new System.EventHandler(this.changeBackground_btn_Click);
            // 
            // changeMusic_btn
            // 
            this.changeMusic_btn.Location = new System.Drawing.Point(545, 37);
            this.changeMusic_btn.Name = "changeMusic_btn";
            this.changeMusic_btn.Size = new System.Drawing.Size(75, 25);
            this.changeMusic_btn.TabIndex = 7;
            this.changeMusic_btn.Text = "Обзор";
            this.changeMusic_btn.UseVisualStyleBackColor = true;
            this.changeMusic_btn.Click += new System.EventHandler(this.changeMusic_btn_Click);
            // 
            // backgroundPath_tb
            // 
            this.backgroundPath_tb.Location = new System.Drawing.Point(159, 68);
            this.backgroundPath_tb.Name = "backgroundPath_tb";
            this.backgroundPath_tb.ReadOnly = true;
            this.backgroundPath_tb.Size = new System.Drawing.Size(380, 22);
            this.backgroundPath_tb.TabIndex = 6;
            // 
            // musicPath_tb
            // 
            this.musicPath_tb.Location = new System.Drawing.Point(159, 37);
            this.musicPath_tb.Name = "musicPath_tb";
            this.musicPath_tb.ReadOnly = true;
            this.musicPath_tb.Size = new System.Drawing.Size(380, 22);
            this.musicPath_tb.TabIndex = 5;
            // 
            // backgroundPathInfo_lbl
            // 
            this.backgroundPathInfo_lbl.AutoSize = true;
            this.backgroundPathInfo_lbl.Location = new System.Drawing.Point(39, 68);
            this.backgroundPathInfo_lbl.Name = "backgroundPathInfo_lbl";
            this.backgroundPathInfo_lbl.Size = new System.Drawing.Size(109, 17);
            this.backgroundPathInfo_lbl.TabIndex = 4;
            this.backgroundPathInfo_lbl.Text = "Выберите фон:";
            // 
            // musicPathInfo_lbl
            // 
            this.musicPathInfo_lbl.AutoSize = true;
            this.musicPathInfo_lbl.Location = new System.Drawing.Point(4, 37);
            this.musicPathInfo_lbl.Name = "musicPathInfo_lbl";
            this.musicPathInfo_lbl.Size = new System.Drawing.Size(150, 17);
            this.musicPathInfo_lbl.TabIndex = 3;
            this.musicPathInfo_lbl.Text = "Выберите саундтрек:";
            // 
            // turnOnOffMusic_btn
            // 
            this.turnOnOffMusic_btn.Location = new System.Drawing.Point(131, 3);
            this.turnOnOffMusic_btn.Name = "turnOnOffMusic_btn";
            this.turnOnOffMusic_btn.Size = new System.Drawing.Size(75, 25);
            this.turnOnOffMusic_btn.TabIndex = 2;
            this.turnOnOffMusic_btn.Text = "Выкл";
            this.turnOnOffMusic_btn.UseVisualStyleBackColor = true;
            this.turnOnOffMusic_btn.Click += new System.EventHandler(this.turnOnOffMusic_btn_Click);
            // 
            // musicMode_lbl
            // 
            this.musicMode_lbl.AutoSize = true;
            this.musicMode_lbl.Location = new System.Drawing.Point(81, 7);
            this.musicMode_lbl.Name = "musicMode_lbl";
            this.musicMode_lbl.Size = new System.Drawing.Size(32, 17);
            this.musicMode_lbl.TabIndex = 1;
            this.musicMode_lbl.Text = "Вкл";
            // 
            // musicModeInfo_lbl
            // 
            this.musicModeInfo_lbl.AutoSize = true;
            this.musicModeInfo_lbl.Location = new System.Drawing.Point(4, 7);
            this.musicModeInfo_lbl.Name = "musicModeInfo_lbl";
            this.musicModeInfo_lbl.Size = new System.Drawing.Size(62, 17);
            this.musicModeInfo_lbl.TabIndex = 0;
            this.musicModeInfo_lbl.Text = "Музыка:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 117);
            this.Controls.Add(this.setupPanel_pnl);
            this.Controls.Add(this.ratingPanel_pnl);
            this.Controls.Add(this.infoPanel_pnl);
            this.Controls.Add(this.mainPanel_pnl);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainPanel_pnl.ResumeLayout(false);
            this.mainPanel_pnl.PerformLayout();
            this.infoPanel_pnl.ResumeLayout(false);
            this.ratingPanel_pnl.ResumeLayout(false);
            this.setupPanel_pnl.ResumeLayout(false);
            this.setupPanel_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel_pnl;
        private System.Windows.Forms.Panel infoPanel_pnl;
        private System.Windows.Forms.Button exitInfo_btn;
        private System.Windows.Forms.RichTextBox info_rtb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button rating_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button setup_btn;
        private System.Windows.Forms.Panel ratingPanel_pnl;
        private System.Windows.Forms.Button exitRating_btn;
        private System.Windows.Forms.RichTextBox rating_rtb;
        private System.Windows.Forms.Panel setupPanel_pnl;
        private System.Windows.Forms.Button exitSetup_btn;
        private System.Windows.Forms.Button changeBackground_btn;
        private System.Windows.Forms.Button changeMusic_btn;
        private System.Windows.Forms.TextBox backgroundPath_tb;
        private System.Windows.Forms.TextBox musicPath_tb;
        private System.Windows.Forms.Label backgroundPathInfo_lbl;
        private System.Windows.Forms.Label musicPathInfo_lbl;
        private System.Windows.Forms.Button turnOnOffMusic_btn;
        private System.Windows.Forms.Label musicMode_lbl;
        private System.Windows.Forms.Label musicModeInfo_lbl;
        private System.Windows.Forms.Label nameInfo_lbl;
        private System.Windows.Forms.TextBox name_tb;
    }
}

