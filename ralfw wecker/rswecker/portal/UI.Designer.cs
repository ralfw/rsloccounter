namespace rswecker.portal
{
    partial class UI
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
            this.txtZeitwert = new System.Windows.Forms.TextBox();
            this.rdWeckzeit = new System.Windows.Forms.RadioButton();
            this.rdRuhezeit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRestzeit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZeitwert
            // 
            this.txtZeitwert.Location = new System.Drawing.Point(29, 33);
            this.txtZeitwert.Name = "txtZeitwert";
            this.txtZeitwert.Size = new System.Drawing.Size(86, 20);
            this.txtZeitwert.TabIndex = 0;
            this.txtZeitwert.Text = "00:00:03";
            // 
            // rdWeckzeit
            // 
            this.rdWeckzeit.AutoSize = true;
            this.rdWeckzeit.Location = new System.Drawing.Point(27, 59);
            this.rdWeckzeit.Name = "rdWeckzeit";
            this.rdWeckzeit.Size = new System.Drawing.Size(70, 17);
            this.rdWeckzeit.TabIndex = 1;
            this.rdWeckzeit.Text = "Weckzeit";
            this.rdWeckzeit.UseVisualStyleBackColor = true;
            // 
            // rdRuhezeit
            // 
            this.rdRuhezeit.AutoSize = true;
            this.rdRuhezeit.Checked = true;
            this.rdRuhezeit.Location = new System.Drawing.Point(29, 84);
            this.rdRuhezeit.Name = "rdRuhezeit";
            this.rdRuhezeit.Size = new System.Drawing.Size(67, 17);
            this.rdRuhezeit.TabIndex = 2;
            this.rdRuhezeit.TabStop = true;
            this.rdRuhezeit.Text = "Ruhezeit";
            this.rdRuhezeit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRestzeit
            // 
            this.lblRestzeit.AutoSize = true;
            this.lblRestzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestzeit.Location = new System.Drawing.Point(25, 141);
            this.lblRestzeit.Name = "lblRestzeit";
            this.lblRestzeit.Size = new System.Drawing.Size(90, 25);
            this.lblRestzeit.TabIndex = 4;
            this.lblRestzeit.Text = "00:00:00";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblRestzeit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdRuhezeit);
            this.Controls.Add(this.rdWeckzeit);
            this.Controls.Add(this.txtZeitwert);
            this.Name = "UI";
            this.Text = "Wecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZeitwert;
        private System.Windows.Forms.RadioButton rdWeckzeit;
        private System.Windows.Forms.RadioButton rdRuhezeit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRestzeit;
    }
}

