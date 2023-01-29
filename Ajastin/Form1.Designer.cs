namespace Ajastin
{
    partial class CountdownForm
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
            this.components = new System.ComponentModel.Container();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekuntitLB = new System.Windows.Forms.Label();
            this.AikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekuntitCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(51, 41);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(88, 25);
            this.MinuutitLB.TabIndex = 0;
            this.MinuutitLB.Text = "Minuutit:";
            // 
            // SekuntitLB
            // 
            this.SekuntitLB.AutoSize = true;
            this.SekuntitLB.Location = new System.Drawing.Point(168, 41);
            this.SekuntitLB.Name = "SekuntitLB";
            this.SekuntitLB.Size = new System.Drawing.Size(84, 25);
            this.SekuntitLB.TabIndex = 1;
            this.SekuntitLB.Text = "Sekuntit:";
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(61, 124);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(191, 86);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(51, 213);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(88, 36);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(168, 213);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(88, 36);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(51, 88);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minuutitCB.Size = new System.Drawing.Size(88, 33);
            this.minuutitCB.TabIndex = 7;
            // 
            // sekuntitCB
            // 
            this.sekuntitCB.FormattingEnabled = true;
            this.sekuntitCB.Location = new System.Drawing.Point(168, 88);
            this.sekuntitCB.Name = "sekuntitCB";
            this.sekuntitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sekuntitCB.Size = new System.Drawing.Size(88, 33);
            this.sekuntitCB.TabIndex = 8;
            // 
            // CountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 283);
            this.Controls.Add(this.sekuntitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SekuntitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CountdownForm";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.CountdownForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MinuutitLB;
        private Label SekuntitLB;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
        private ComboBox minuutitCB;
        private ComboBox sekuntitCB;
    }
}