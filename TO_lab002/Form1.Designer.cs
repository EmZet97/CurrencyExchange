namespace TO_lab002
{
    partial class Waluty
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxToCurrecy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(330, 215);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(153, 21);
            this.comboBoxFromCurrency.TabIndex = 0;
            this.comboBoxFromCurrency.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFromCurrency_SelectedIndexChanged);
            // 
            // comboBoxToCurrecy
            // 
            this.comboBoxToCurrecy.FormattingEnabled = true;
            this.comboBoxToCurrecy.Location = new System.Drawing.Point(513, 215);
            this.comboBoxToCurrecy.Name = "comboBoxToCurrecy";
            this.comboBoxToCurrecy.Size = new System.Drawing.Size(161, 21);
            this.comboBoxToCurrecy.TabIndex = 1;
            this.comboBoxToCurrecy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxToCurrecy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(489, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(204, 215);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(680, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data publikacji: 20.10.2019";
            // 
            // Waluty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(945, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToCurrecy);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Name = "Waluty";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Waluty";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrecy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

