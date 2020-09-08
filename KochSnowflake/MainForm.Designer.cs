namespace KochSnowflake
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
            this.radioButtonOutside = new System.Windows.Forms.RadioButton();
            this.radioButtonInside = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOutside
            // 
            this.radioButtonOutside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOutside.AutoSize = true;
            this.radioButtonOutside.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonOutside.Location = new System.Drawing.Point(39, 122);
            this.radioButtonOutside.Name = "radioButtonOutside";
            this.radioButtonOutside.Size = new System.Drawing.Size(89, 24);
            this.radioButtonOutside.TabIndex = 0;
            this.radioButtonOutside.Text = "Наружу";
            this.radioButtonOutside.UseVisualStyleBackColor = true;
            // 
            // radioButtonInside
            // 
            this.radioButtonInside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonInside.AutoSize = true;
            this.radioButtonInside.Checked = true;
            this.radioButtonInside.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonInside.Location = new System.Drawing.Point(39, 92);
            this.radioButtonInside.Name = "radioButtonInside";
            this.radioButtonInside.Size = new System.Drawing.Size(88, 24);
            this.radioButtonInside.TabIndex = 1;
            this.radioButtonInside.TabStop = true;
            this.radioButtonInside.Text = "Внутрь";
            this.radioButtonInside.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.numericUpDownIterations);
            this.panel.Controls.Add(this.radioButtonInside);
            this.panel.Controls.Add(this.radioButtonOutside);
            this.panel.Location = new System.Drawing.Point(623, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(175, 180);
            this.panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Итерации";
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(38, 53);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDownIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownIterations.TabIndex = 2;
            this.numericUpDownIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР 3 Снежинка Коха";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOutside;
        private System.Windows.Forms.RadioButton radioButtonInside;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
    }
}

