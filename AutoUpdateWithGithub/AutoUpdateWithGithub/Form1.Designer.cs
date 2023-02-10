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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateVersion_label = new System.Windows.Forms.Label();
            this.currentVersion_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.Button();
            this.hasUpdate_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suanki Surum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guncel Surum:";
            // 
            // updateVersion_label
            // 
            this.updateVersion_label.AutoSize = true;
            this.updateVersion_label.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.updateVersion_label.Location = new System.Drawing.Point(124, 67);
            this.updateVersion_label.Name = "updateVersion_label";
            this.updateVersion_label.Size = new System.Drawing.Size(112, 18);
            this.updateVersion_label.TabIndex = 1;
            this.updateVersion_label.Text = "Guncel Surum:";
            // 
            // currentVersion_label
            // 
            this.currentVersion_label.AutoSize = true;
            this.currentVersion_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersion_label.Location = new System.Drawing.Point(124, 34);
            this.currentVersion_label.Name = "currentVersion_label";
            this.currentVersion_label.Size = new System.Drawing.Size(112, 18);
            this.currentVersion_label.TabIndex = 0;
            this.currentVersion_label.Text = "Suanki Surum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updateVersion_label);
            this.groupBox1.Controls.Add(this.currentVersion_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.button.Location = new System.Drawing.Point(7, 148);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(246, 43);
            this.button.TabIndex = 3;
            this.button.Text = "Indir Ve Kur";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // hasUpdate_label
            // 
            this.hasUpdate_label.AutoSize = true;
            this.hasUpdate_label.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.hasUpdate_label.Location = new System.Drawing.Point(35, 9);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 197);
            this.Controls.Add(this.hasUpdate_label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label updateVersion_label;
        private System.Windows.Forms.Label currentVersion_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label hasUpdate_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

