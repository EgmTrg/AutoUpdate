namespace AutoUpdateWithGithub {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button = new System.Windows.Forms.Button();
            this.hasUpdate_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appVersion_label = new System.Windows.Forms.Label();
            this.newVersion_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.button.Location = new System.Drawing.Point(7, 148);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(325, 43);
            this.button.TabIndex = 3;
            this.button.Text = "Indir Ve Kur";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // hasUpdate_label
            // 
            this.hasUpdate_label.AutoSize = true;
            this.hasUpdate_label.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.hasUpdate_label.Location = new System.Drawing.Point(78, 9);
            this.hasUpdate_label.Name = "hasUpdate_label";
            this.hasUpdate_label.Size = new System.Drawing.Size(175, 23);
            this.hasUpdate_label.TabIndex = 4;
            this.hasUpdate_label.Text = "Program Guncel!";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suanki Surum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guncellenecek Surum:";
            // 
            // appVersion_label
            // 
            this.appVersion_label.AutoSize = true;
            this.appVersion_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appVersion_label.Location = new System.Drawing.Point(186, 65);
            this.appVersion_label.Name = "appVersion_label";
            this.appVersion_label.Size = new System.Drawing.Size(88, 18);
            this.appVersion_label.TabIndex = 7;
            this.appVersion_label.Text = "appVersion";
            // 
            // newVersion_label
            // 
            this.newVersion_label.AutoSize = true;
            this.newVersion_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersion_label.Location = new System.Drawing.Point(186, 98);
            this.newVersion_label.Name = "newVersion_label";
            this.newVersion_label.Size = new System.Drawing.Size(88, 18);
            this.newVersion_label.TabIndex = 7;
            this.newVersion_label.Text = "newVersion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 197);
            this.Controls.Add(this.newVersion_label);
            this.Controls.Add(this.appVersion_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hasUpdate_label);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label hasUpdate_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appVersion_label;
        private System.Windows.Forms.Label newVersion_label;
    }
}

