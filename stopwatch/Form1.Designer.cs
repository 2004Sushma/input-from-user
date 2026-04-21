namespace stopwatch
{
    partial class StopWatch
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
            components = new System.ComponentModel.Container();
            btnstart = new Button();
            btnstop = new Button();
            btnresume = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnstart
            // 
            btnstart.Location = new Point(158, 403);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(196, 96);
            btnstart.TabIndex = 0;
            btnstart.Text = "START";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += button1_Click;
            // 
            // btnstop
            // 
            btnstop.Location = new Point(509, 403);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(196, 96);
            btnstop.TabIndex = 1;
            btnstop.Text = "STOP";
            btnstop.UseVisualStyleBackColor = true;
            btnstop.Click += button2_Click;
            // 
            // btnresume
            // 
            btnresume.Location = new Point(838, 403);
            btnresume.Name = "btnresume";
            btnresume.Size = new Size(196, 96);
            btnresume.TabIndex = 2;
            btnresume.Text = "RESUME";
            btnresume.UseVisualStyleBackColor = true;
            btnresume.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(555, 201);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "00:00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1182, 753);
            Controls.Add(label1);
            Controls.Add(btnresume);
            Controls.Add(btnstop);
            Controls.Add(btnstart);
            Name = "StopWatch";
            Text = "form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnstart;
        private Button btnstop;
        private Button btnresume;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
