namespace GuiTest
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
            this.sourceView = new System.Windows.Forms.TreeView();
            this.btnSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceView
            // 
            this.sourceView.CheckBoxes = true;
            this.sourceView.Location = new System.Drawing.Point(12, 12);
            this.sourceView.Name = "sourceView";
            this.sourceView.Size = new System.Drawing.Size(365, 446);
            this.sourceView.TabIndex = 0;
            this.sourceView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sourceView_AfterSelect);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(383, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Browse";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 480);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.sourceView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView sourceView;
        private System.Windows.Forms.Button btnSource;
    }
}

