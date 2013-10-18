namespace Physics_Simulator_2D
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.option_Trace = new System.Windows.Forms.CheckBox();
            this.option_PlayPause = new System.Windows.Forms.Button();
            this.option_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 573);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // option_Trace
            // 
            this.option_Trace.AutoSize = true;
            this.option_Trace.Location = new System.Drawing.Point(1045, 12);
            this.option_Trace.Name = "option_Trace";
            this.option_Trace.Size = new System.Drawing.Size(67, 21);
            this.option_Trace.TabIndex = 1;
            this.option_Trace.Text = "Trace";
            this.option_Trace.UseVisualStyleBackColor = true;
            // 
            // option_PlayPause
            // 
            this.option_PlayPause.Location = new System.Drawing.Point(12, 10);
            this.option_PlayPause.Name = "option_PlayPause";
            this.option_PlayPause.Size = new System.Drawing.Size(42, 23);
            this.option_PlayPause.TabIndex = 2;
            this.option_PlayPause.Text = "| |";
            this.option_PlayPause.UseVisualStyleBackColor = true;
            this.option_PlayPause.Click += new System.EventHandler(this.option_PlayPause_Click);
            // 
            // option_Clear
            // 
            this.option_Clear.Location = new System.Drawing.Point(60, 10);
            this.option_Clear.Name = "option_Clear";
            this.option_Clear.Size = new System.Drawing.Size(75, 23);
            this.option_Clear.TabIndex = 3;
            this.option_Clear.Text = "Clear";
            this.option_Clear.UseVisualStyleBackColor = true;
            this.option_Clear.Click += new System.EventHandler(this.option_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 624);
            this.Controls.Add(this.option_Clear);
            this.Controls.Add(this.option_PlayPause);
            this.Controls.Add(this.option_Trace);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Physics Simulator (2D)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox option_Trace;
        private System.Windows.Forms.Button option_PlayPause;
        private System.Windows.Forms.Button option_Clear;
    }
}

