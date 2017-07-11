namespace UDPTool
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFrame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDestAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReception = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxProgram = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxWaitFor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxListenPort = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMulticastAddress = new System.Windows.Forms.TextBox();
            this.textBoxAdapterAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(665, 5);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 35);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxFrame);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.buttonSend);
            this.panel3.Controls.Add(this.textBoxDestPort);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxDestAddress);
            this.panel3.Location = new System.Drawing.Point(41, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 78);
            this.panel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Frame";
            // 
            // textBoxFrame
            // 
            this.textBoxFrame.Location = new System.Drawing.Point(268, 35);
            this.textBoxFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFrame.Name = "textBoxFrame";
            this.textBoxFrame.Size = new System.Drawing.Size(311, 26);
            this.textBoxFrame.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dest. port";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(587, 26);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 35);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Location = new System.Drawing.Point(13, 35);
            this.textBoxDestPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(100, 26);
            this.textBoxDestPort.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dest. address";
            // 
            // textBoxDestAddress
            // 
            this.textBoxDestAddress.Location = new System.Drawing.Point(124, 35);
            this.textBoxDestAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDestAddress.Name = "textBoxDestAddress";
            this.textBoxDestAddress.Size = new System.Drawing.Size(136, 26);
            this.textBoxDestAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reception";
            // 
            // textBoxReception
            // 
            this.textBoxReception.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReception.Location = new System.Drawing.Point(13, 48);
            this.textBoxReception.Multiline = true;
            this.textBoxReception.Name = "textBoxReception";
            this.textBoxReception.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReception.Size = new System.Drawing.Size(764, 109);
            this.textBoxReception.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "(empty = any)";
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(665, 26);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 35);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxProgram);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxWaitFor);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxReception);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 207);
            this.panel2.TabIndex = 12;
            // 
            // textBoxProgram
            // 
            this.textBoxProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProgram.Location = new System.Drawing.Point(494, 165);
            this.textBoxProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxProgram.Name = "textBoxProgram";
            this.textBoxProgram.Size = new System.Drawing.Size(283, 26);
            this.textBoxProgram.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "then execute";
            // 
            // textBoxWaitFor
            // 
            this.textBoxWaitFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWaitFor.Location = new System.Drawing.Point(36, 165);
            this.textBoxWaitFor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWaitFor.Name = "textBoxWaitFor";
            this.textBoxWaitFor.Size = new System.Drawing.Size(342, 26);
            this.textBoxWaitFor.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "If";
            // 
            // textBoxListenPort
            // 
            this.textBoxListenPort.Location = new System.Drawing.Point(13, 35);
            this.textBoxListenPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxListenPort.Name = "textBoxListenPort";
            this.textBoxListenPort.Size = new System.Drawing.Size(100, 26);
            this.textBoxListenPort.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(467, 26);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Listen";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adapter address";
            // 
            // textBoxMulticastAddress
            // 
            this.textBoxMulticastAddress.Location = new System.Drawing.Point(297, 35);
            this.textBoxMulticastAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMulticastAddress.Name = "textBoxMulticastAddress";
            this.textBoxMulticastAddress.Size = new System.Drawing.Size(162, 26);
            this.textBoxMulticastAddress.TabIndex = 5;
            // 
            // textBoxAdapterAddress
            // 
            this.textBoxAdapterAddress.Location = new System.Drawing.Point(124, 35);
            this.textBoxAdapterAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdapterAddress.Name = "textBoxAdapterAddress";
            this.textBoxAdapterAddress.Size = new System.Drawing.Size(162, 26);
            this.textBoxAdapterAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multicast address";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxAuto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.textBoxListenPort);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMulticastAddress);
            this.panel1.Controls.Add(this.textBoxAdapterAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 89);
            this.panel1.TabIndex = 11;
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(591, 32);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(62, 24);
            this.checkBoxAuto.TabIndex = 9;
            this.checkBoxAuto.Text = "Auto";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(833, 474);
            this.Name = "MainForm";
            this.Text = "YT UDP Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDestAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReception;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxListenPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMulticastAddress;
        private System.Windows.Forms.TextBox textBoxAdapterAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxProgram;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxWaitFor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxAuto;
    }
}

