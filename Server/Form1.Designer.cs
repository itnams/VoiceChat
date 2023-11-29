namespace Server
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
            listBoxClients = new ListBox();
            label1 = new Label();
            txtIP = new TextBox();
            btnStartCall = new Button();
            btnStopCall = new Button();
            SuspendLayout();
            // 
            // listBoxClients
            // 
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 25;
            listBoxClients.Location = new Point(12, 161);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(776, 279);
            listBoxClients.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 1;
            label1.Text = "IP:";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(49, 9);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(739, 31);
            txtIP.TabIndex = 2;
            // 
            // btnStartCall
            // 
            btnStartCall.Location = new Point(676, 46);
            btnStartCall.Name = "btnStartCall";
            btnStartCall.Size = new Size(112, 34);
            btnStartCall.TabIndex = 3;
            btnStartCall.Text = "Start Call";
            btnStartCall.UseVisualStyleBackColor = true;
            btnStartCall.Click += btnStartCall_Click;
            // 
            // btnStopCall
            // 
            btnStopCall.Location = new Point(558, 46);
            btnStopCall.Name = "btnStopCall";
            btnStopCall.Size = new Size(112, 34);
            btnStopCall.TabIndex = 4;
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
            Controls.Add(txtIP);
            Controls.Add(label1);
            Controls.Add(listBoxClients);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClients;
        private Label label1;
        private TextBox txtIP;
        private Button btnStartCall;
        private Button btnStopCall;
    }
}
