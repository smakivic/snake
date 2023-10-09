namespace zmija
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
            this.start_button = new System.Windows.Forms.Button();
            this.pic_canvas = new System.Windows.Forms.PictureBox();
            this.txt_score = new System.Windows.Forms.Label();
            this.game_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.SkyBlue;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.ForeColor = System.Drawing.Color.Black;
            this.start_button.Location = new System.Drawing.Point(779, 162);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(132, 90);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pic_canvas
            // 
            this.pic_canvas.BackColor = System.Drawing.Color.White;
            this.pic_canvas.Location = new System.Drawing.Point(12, 12);
            this.pic_canvas.Name = "pic_canvas";
            this.pic_canvas.Size = new System.Drawing.Size(725, 850);
            this.pic_canvas.TabIndex = 1;
            this.pic_canvas.TabStop = false;
            this.pic_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_canvas_Paint);
            // 
            // txt_score
            // 
            this.txt_score.AutoSize = true;
            this.txt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(17, 34);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(86, 25);
            this.txt_score.TabIndex = 2;
            this.txt_score.Text = "Score: 0";
            this.txt_score.Click += new System.EventHandler(this.txt_score_Click);
            // 
            // game_Timer
            // 
            this.game_Timer.Tick += new System.EventHandler(this.game_Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.txt_score);
            this.panel1.Location = new System.Drawing.Point(779, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 90);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(937, 908);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_canvas);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Zmija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox pic_canvas;
        private System.Windows.Forms.Label txt_score;
        private System.Windows.Forms.Timer game_Timer;
        private System.Windows.Forms.Panel panel1;
    }
}

