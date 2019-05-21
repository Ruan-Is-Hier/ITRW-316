namespace KeyBoardHook
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHook = new System.Windows.Forms.Button();
            this.btnUnhook = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 289);
            this.textBox1.TabIndex = 0;
            // 
            // btnHook
            // 
            this.btnHook.Location = new System.Drawing.Point(12, 12);
            this.btnHook.Name = "btnHook";
            this.btnHook.Size = new System.Drawing.Size(75, 23);
            this.btnHook.TabIndex = 1;
            this.btnHook.Text = "Hook";
            this.btnHook.UseVisualStyleBackColor = true;
            this.btnHook.Click += new System.EventHandler(this.btnHook_Click);
            // 
            // btnUnhook
            // 
            this.btnUnhook.Location = new System.Drawing.Point(93, 12);
            this.btnUnhook.Name = "btnUnhook";
            this.btnUnhook.Size = new System.Drawing.Size(68, 23);
            this.btnUnhook.TabIndex = 2;
            this.btnUnhook.Text = "Unhook";
            this.btnUnhook.UseVisualStyleBackColor = true;
            this.btnUnhook.Click += new System.EventHandler(this.btnUnhook_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gHook_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnhook);
            this.Controls.Add(this.btnHook);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Keyboard Hook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHook;
        private System.Windows.Forms.Button btnUnhook;
        private System.Windows.Forms.Button btnSave;
    }
}

