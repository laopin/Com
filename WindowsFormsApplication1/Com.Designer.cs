namespace Com
{
    partial class Com
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.cboPort = new MetroFramework.Controls.MetroComboBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.btnReceive = new MetroFramework.Controls.MetroButton();
            this.txtReceive = new MetroFramework.Controls.MetroTextBox();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            //this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnOpen.Location = new System.Drawing.Point(229, 87);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOpen.UseMnemonic = false;
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Port:";
            this.Label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.ItemHeight = 23;
            this.cboPort.Location = new System.Drawing.Point(85, 87);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 29);
            this.cboPort.TabIndex = 2;
            this.cboPort.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnClose.Location = new System.Drawing.Point(340, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMessage
            // 
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(85, 135);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(348, 100);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSend.Location = new System.Drawing.Point(340, 253);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 29);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSend.UseMnemonic = false;
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnReceive.Location = new System.Drawing.Point(340, 421);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(93, 29);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "Receive";
            this.btnReceive.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReceive.UseMnemonic = false;
            this.btnReceive.UseSelectable = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtReceive
            // 
            // 
            // 
            // 
            this.txtReceive.CustomButton.Image = null;
            this.txtReceive.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtReceive.CustomButton.Name = "";
            this.txtReceive.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtReceive.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReceive.CustomButton.TabIndex = 1;
            this.txtReceive.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReceive.CustomButton.UseSelectable = true;
            this.txtReceive.CustomButton.Visible = false;
            this.txtReceive.Lines = new string[0];
            this.txtReceive.Location = new System.Drawing.Point(85, 306);
            this.txtReceive.MaxLength = 32767;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.PasswordChar = '\0';
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReceive.SelectedText = "";
            this.txtReceive.SelectionLength = 0;
            this.txtReceive.SelectionStart = 0;
            this.txtReceive.ShortcutsEnabled = true;
            this.txtReceive.Size = new System.Drawing.Size(348, 100);
            this.txtReceive.TabIndex = 3;
            this.txtReceive.UseSelectable = true;
            this.txtReceive.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReceive.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 135);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 19);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Send:";
            this.Label2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 306);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 19);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Receive:";
            this.Label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 464);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Name = "Com";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Com";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Com_FormClosing);
            this.Load += new System.EventHandler(this.Com_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroComboBox cboPort;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroButton btnReceive;
        private MetroFramework.Controls.MetroTextBox txtReceive;
        private MetroFramework.Controls.MetroLabel Label2;
        private MetroFramework.Controls.MetroLabel Label3;
    }
}

