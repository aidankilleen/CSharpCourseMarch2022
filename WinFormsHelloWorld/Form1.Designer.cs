
namespace WinFormsHelloWorld
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
            this.btnPressMe = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtCoordinates = new System.Windows.Forms.TextBox();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.dlgColour = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnPressMe
            // 
            this.btnPressMe.Location = new System.Drawing.Point(122, 55);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(123, 39);
            this.btnPressMe.TabIndex = 0;
            this.btnPressMe.Text = "Press Me";
            this.btnPressMe.UseVisualStyleBackColor = true;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(122, 141);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 1;
            this.btnTest2.Text = "Test Button 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(122, 211);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(123, 23);
            this.btnTest3.TabIndex = 2;
            this.btnTest3.Text = "Test Button 3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(392, 75);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(59, 19);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // btnActive
            // 
            this.btnActive.Enabled = false;
            this.btnActive.Location = new System.Drawing.Point(392, 121);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(75, 23);
            this.btnActive.TabIndex = 4;
            this.btnActive.Text = "Activate";
            this.btnActive.UseVisualStyleBackColor = true;
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 15;
            this.lstUsers.Items.AddRange(new object[] {
            "Alice",
            "Bob",
            "Carol",
            "Dan",
            "Eve",
            "Fred",
            "Ger",
            "Harriet"});
            this.lstUsers.Location = new System.Drawing.Point(392, 185);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(120, 94);
            this.lstUsers.TabIndex = 5;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(573, 185);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 6;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(573, 231);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 23);
            this.txtName2.TabIndex = 7;
            // 
            // txtCoordinates
            // 
            this.txtCoordinates.Location = new System.Drawing.Point(31, 446);
            this.txtCoordinates.Name = "txtCoordinates";
            this.txtCoordinates.ReadOnly = true;
            this.txtCoordinates.Size = new System.Drawing.Size(166, 23);
            this.txtCoordinates.TabIndex = 8;
            // 
            // pnlColour
            // 
            this.pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColour.Location = new System.Drawing.Point(392, 367);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(200, 100);
            this.pnlColour.TabIndex = 9;
            this.pnlColour.Click += new System.EventHandler(this.pnlColour_Click);
            this.pnlColour.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColour_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 600);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.txtCoordinates);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnPressMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressMe;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtCoordinates;
        private System.Windows.Forms.Panel pnlColour;
        private System.Windows.Forms.ColorDialog dlgColour;
    }
}

