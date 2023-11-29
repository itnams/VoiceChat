namespace VoiceChat
{
    partial class Form1
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
            btnStartCall = new Button();
            btnStopCall = new Button();
            SuspendLayout();
            // 
            // btnStartCall
            // 
            btnStartCall.Location = new Point(676, 94);
            btnStartCall.Name = "btnStartCall";
            btnStartCall.Size = new Size(112, 34);
            btnStartCall.TabIndex = 0;
            btnStartCall.Text = "Start Call";
            btnStartCall.UseVisualStyleBackColor = true;
            btnStartCall.Click += btnStartCall_Click;
            // 
            // btnStopCall
            // 
            btnStopCall.Location = new Point(558, 94);
            btnStopCall.Name = "btnStopCall";
            btnStopCall.Size = new Size(112, 34);
            btnStopCall.TabIndex = 1;
            btnStopCall.Text = "Stop Call";
            btnStopCall.UseVisualStyleBackColor = true;
            btnStopCall.Click += btnStopCall_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStopCall);
            Controls.Add(btnStartCall);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartCall;
        private Button btnStopCall;
    }
}
