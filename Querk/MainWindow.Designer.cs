namespace Querk
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lBox = new System.Windows.Forms.ComboBox();
            this.nBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            //this.Resize += new System.EventHandler(this.ImportStatusForm_Resize);
            // 
            // fBox
            // 
            this.fBox.Location = new System.Drawing.Point(12, 27);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(107, 23);
            this.fBox.TabIndex = 0;
            this.fBox.Text = "Load File";
            this.fBox.UseVisualStyleBackColor = true;
            this.fBox.Click += new System.EventHandler(this.fBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From File:";
            // 
            // eBox
            // 
            this.eBox.AutoSize = true;
            this.eBox.Checked = true;
            this.eBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eBox.Location = new System.Drawing.Point(507, 32);
            this.eBox.Name = "eBox";
            this.eBox.Size = new System.Drawing.Size(15, 14);
            this.eBox.TabIndex = 3;
            this.eBox.UseVisualStyleBackColor = true;
            this.eBox.CheckedChanged += new System.EventHandler(this.eBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uppercase Preset:";
            // 
            // uBox
            // 
            this.uBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uBox.FormattingEnabled = true;
            this.uBox.Items.AddRange(new object[] {
            "Use File",
            "None",
            "Blocked",
            "Circled",
            "Runic",
            "Greek",
            "Gothic",
            "Curvy",
            "Lines",
            "Upaccent",
            "Downaccent",
            "Bold Cursive",
            "Bold",
            "Outline"});
            this.uBox.Location = new System.Drawing.Point(125, 29);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(113, 21);
            this.uBox.TabIndex = 5;
            this.uBox.SelectedIndexChanged += new System.EventHandler(this.uBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enabled:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lowercase Preset:";
            // 
            // lBox
            // 
            this.lBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lBox.FormattingEnabled = true;
            this.lBox.Items.AddRange(new object[] {
            "Use File",
            "None",
            "Circled",
            "Greek",
            "Gothic",
            "Cave",
            "Ancient",
            "Accent Ancient",
            "Medieval",
            "Bold Cursive",
            "Cursive",
            "Bold",
            "Outline",
            "Tiny",
            "Upside-Down"});
            this.lBox.Location = new System.Drawing.Point(244, 29);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(113, 21);
            this.lBox.TabIndex = 8;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            // 
            // nBox
            // 
            this.nBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nBox.FormattingEnabled = true;
            this.nBox.Items.AddRange(new object[] {
            "Use File",
            "None",
            "Tiny",
            "Circled",
            "Gypsy",
            "Runic",
            "Magic",
            "Outline",
            "Bold",
            "Bold Curvy",
            "Fancy Dinner"});
            this.nBox.Location = new System.Drawing.Point(363, 29);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(113, 21);
            this.nBox.TabIndex = 9;
            this.nBox.SelectedIndexChanged += new System.EventHandler(this.nBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number Preset:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info; //Shows the info icon so the user doesn't think there is an error.
            this.notifyIcon.BalloonTipText = "To make your text more querky.";
            this.notifyIcon.BalloonTipTitle = "Querk Key";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon"))); //The tray icon to use
            this.notifyIcon.Text = "Querk Key";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 58);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Querk Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox eBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lBox;
        private System.Windows.Forms.ComboBox nBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

