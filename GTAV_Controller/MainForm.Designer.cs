namespace GTAV_Controller;

partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BtnClearSession = new System.Windows.Forms.Button();
			this.LblProcessInfo = new System.Windows.Forms.Label();
			this.PanelHeader = new System.Windows.Forms.Panel();
			this.LblMinimize = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.LblClouse = new System.Windows.Forms.Label();
			this.PBUkraineIcon = new System.Windows.Forms.PictureBox();
			this.BtnKillPrrocess = new System.Windows.Forms.Button();
			this.BtnDisableNetwork = new System.Windows.Forms.Button();
			this.PanelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBUkraineIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnClearSession
			// 
			this.BtnClearSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
			this.BtnClearSession.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnClearSession.FlatAppearance.BorderSize = 0;
			this.BtnClearSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
			this.BtnClearSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnClearSession.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnClearSession.ForeColor = System.Drawing.Color.White;
			this.BtnClearSession.Location = new System.Drawing.Point(55, 123);
			this.BtnClearSession.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.BtnClearSession.Name = "BtnClearSession";
			this.BtnClearSession.Size = new System.Drawing.Size(250, 50);
			this.BtnClearSession.TabIndex = 0;
			this.BtnClearSession.Text = "CLEAR SESSION";
			this.BtnClearSession.UseVisualStyleBackColor = false;
			this.BtnClearSession.Click += new System.EventHandler(this.BtnClearSession_Click);
			// 
			// LblProcessInfo
			// 
			this.LblProcessInfo.AutoSize = true;
			this.LblProcessInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.LblProcessInfo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LblProcessInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
			this.LblProcessInfo.Location = new System.Drawing.Point(52, 67);
			this.LblProcessInfo.Margin = new System.Windows.Forms.Padding(0, 50, 0, 25);
			this.LblProcessInfo.Name = "LblProcessInfo";
			this.LblProcessInfo.Size = new System.Drawing.Size(220, 28);
			this.LblProcessInfo.TabIndex = 1;
			this.LblProcessInfo.Text = "GAME NOT STARTED";
			// 
			// PanelHeader
			// 
			this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
			this.PanelHeader.Controls.Add(this.LblMinimize);
			this.PanelHeader.Controls.Add(this.label1);
			this.PanelHeader.Controls.Add(this.LblClouse);
			this.PanelHeader.Location = new System.Drawing.Point(0, 0);
			this.PanelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
			this.PanelHeader.Name = "PanelHeader";
			this.PanelHeader.Size = new System.Drawing.Size(360, 40);
			this.PanelHeader.TabIndex = 3;
			this.PanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// LblMinimize
			// 
			this.LblMinimize.AutoSize = true;
			this.LblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LblMinimize.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
			this.LblMinimize.Location = new System.Drawing.Point(302, 5);
			this.LblMinimize.Name = "LblMinimize";
			this.LblMinimize.Size = new System.Drawing.Size(21, 29);
			this.LblMinimize.TabIndex = 2;
			this.LblMinimize.Text = "-";
			this.LblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "GTAV CONTROLLER";
			// 
			// LblClouse
			// 
			this.LblClouse.AutoSize = true;
			this.LblClouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
			this.LblClouse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LblClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LblClouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblClouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(114)))));
			this.LblClouse.Location = new System.Drawing.Point(325, 9);
			this.LblClouse.Margin = new System.Windows.Forms.Padding(0);
			this.LblClouse.Name = "LblClouse";
			this.LblClouse.Size = new System.Drawing.Size(32, 21);
			this.LblClouse.TabIndex = 0;
			this.LblClouse.Text = "✖";
			this.LblClouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblClouse.Click += new System.EventHandler(this.LblClouse_Click);
			// 
			// PBUkraineIcon
			// 
			this.PBUkraineIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PBUkraineIcon.Image = global::GTAV_Controller.Properties.Resources.ukraine;
			this.PBUkraineIcon.Location = new System.Drawing.Point(155, 303);
			this.PBUkraineIcon.Margin = new System.Windows.Forms.Padding(7, 1, 0, 0);
			this.PBUkraineIcon.Name = "PBUkraineIcon";
			this.PBUkraineIcon.Size = new System.Drawing.Size(50, 50);
			this.PBUkraineIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.PBUkraineIcon.TabIndex = 6;
			this.PBUkraineIcon.TabStop = false;
			// 
			// BtnKillPrrocess
			// 
			this.BtnKillPrrocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
			this.BtnKillPrrocess.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnKillPrrocess.FlatAppearance.BorderSize = 0;
			this.BtnKillPrrocess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
			this.BtnKillPrrocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnKillPrrocess.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnKillPrrocess.ForeColor = System.Drawing.Color.White;
			this.BtnKillPrrocess.Location = new System.Drawing.Point(55, 243);
			this.BtnKillPrrocess.Margin = new System.Windows.Forms.Padding(0);
			this.BtnKillPrrocess.Name = "BtnKillPrrocess";
			this.BtnKillPrrocess.Size = new System.Drawing.Size(250, 50);
			this.BtnKillPrrocess.TabIndex = 4;
			this.BtnKillPrrocess.Text = "CLOSE GAME";
			this.BtnKillPrrocess.UseVisualStyleBackColor = false;
			this.BtnKillPrrocess.Click += new System.EventHandler(this.BtnKillPrrocess_Click);
			// 
			// BtnDisableNetwork
			// 
			this.BtnDisableNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
			this.BtnDisableNetwork.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnDisableNetwork.FlatAppearance.BorderSize = 0;
			this.BtnDisableNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
			this.BtnDisableNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDisableNetwork.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnDisableNetwork.ForeColor = System.Drawing.Color.White;
			this.BtnDisableNetwork.Location = new System.Drawing.Point(55, 183);
			this.BtnDisableNetwork.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.BtnDisableNetwork.Name = "BtnDisableNetwork";
			this.BtnDisableNetwork.Size = new System.Drawing.Size(250, 50);
			this.BtnDisableNetwork.TabIndex = 5;
			this.BtnDisableNetwork.Text = "DISABLE NETWORK";
			this.BtnDisableNetwork.UseVisualStyleBackColor = false;
			this.BtnDisableNetwork.Click += new System.EventHandler(this.BtnDisableNetwork_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(360, 365);
			this.Controls.Add(this.PBUkraineIcon);
			this.Controls.Add(this.BtnDisableNetwork);
			this.Controls.Add(this.BtnKillPrrocess);
			this.Controls.Add(this.PanelHeader);
			this.Controls.Add(this.LblProcessInfo);
			this.Controls.Add(this.BtnClearSession);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Opacity = 0.98D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GTAV Controller";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseHover += new System.EventHandler(this.MainForm_Load);
			this.PanelHeader.ResumeLayout(false);
			this.PanelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBUkraineIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

	#endregion

	private Button BtnClearSession;
	private Label LblProcessInfo;
	private Panel PanelHeader;
	private Button BtnKillPrrocess;
	private Label LblClouse;
	private Label label1;
	private Label LblMinimize;
	private Button BtnDisableNetwork;
	private PictureBox PBUkraineIcon;
}
