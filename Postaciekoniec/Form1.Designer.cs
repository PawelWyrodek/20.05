namespace Postaciekoniec
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.PeopleList = new System.Windows.Forms.ListBox();
            this.radioButtonWojownik = new System.Windows.Forms.RadioButton();
            this.radioButtonMag = new System.Windows.Forms.RadioButton();
            this.radioButtonRolnik = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PeopleList
            // 
            this.PeopleList.FormattingEnabled = true;
            this.PeopleList.Location = new System.Drawing.Point(250, 12);
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.Size = new System.Drawing.Size(209, 355);
            this.PeopleList.TabIndex = 1;
            // 
            // radioButtonWojownik
            // 
            this.radioButtonWojownik.AutoSize = true;
            this.radioButtonWojownik.Location = new System.Drawing.Point(12, 74);
            this.radioButtonWojownik.Name = "radioButtonWojownik";
            this.radioButtonWojownik.Size = new System.Drawing.Size(72, 17);
            this.radioButtonWojownik.TabIndex = 2;
            this.radioButtonWojownik.TabStop = true;
            this.radioButtonWojownik.Text = "Wojownik";
            this.radioButtonWojownik.UseVisualStyleBackColor = true;
            this.radioButtonWojownik.CheckedChanged += new System.EventHandler(this.RadioButtonWojownik_CheckedChanged);
            // 
            // radioButtonMag
            // 
            this.radioButtonMag.AutoSize = true;
            this.radioButtonMag.Location = new System.Drawing.Point(90, 74);
            this.radioButtonMag.Name = "radioButtonMag";
            this.radioButtonMag.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMag.TabIndex = 3;
            this.radioButtonMag.TabStop = true;
            this.radioButtonMag.Text = "Mag";
            this.radioButtonMag.UseVisualStyleBackColor = true;
            this.radioButtonMag.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButtonRolnik
            // 
            this.radioButtonRolnik.AutoSize = true;
            this.radioButtonRolnik.Location = new System.Drawing.Point(142, 74);
            this.radioButtonRolnik.Name = "radioButtonRolnik";
            this.radioButtonRolnik.Size = new System.Drawing.Size(55, 17);
            this.radioButtonRolnik.TabIndex = 4;
            this.radioButtonRolnik.TabStop = true;
            this.radioButtonRolnik.Text = "Rolnik";
            this.radioButtonRolnik.UseVisualStyleBackColor = true;
            this.radioButtonRolnik.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Dodaj Postać";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(93, 116);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(104, 20);
            this.textBoxImie.TabIndex = 6;
            this.textBoxImie.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxHP
            // 
            this.textBoxHP.Location = new System.Drawing.Point(93, 142);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(104, 20);
            this.textBoxHP.TabIndex = 6;
            this.textBoxHP.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxHP);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonRolnik);
            this.Controls.Add(this.radioButtonMag);
            this.Controls.Add(this.radioButtonWojownik);
            this.Controls.Add(this.PeopleList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PeopleList;
        private System.Windows.Forms.RadioButton radioButtonWojownik;
        private System.Windows.Forms.RadioButton radioButtonMag;
        private System.Windows.Forms.RadioButton radioButtonRolnik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

