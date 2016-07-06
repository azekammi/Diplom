namespace Diplom_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioRungeKutti = new System.Windows.Forms.RadioButton();
            this.radioXoyn = new System.Windows.Forms.RadioButton();
            this.radioEilerPeres = new System.Windows.Forms.RadioButton();
            this.radioModifEiler = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioPravixPram = new System.Windows.Forms.RadioButton();
            this.radioSrednixPram = new System.Windows.Forms.RadioButton();
            this.radioLevixPram = new System.Windows.Forms.RadioButton();
            this.radioTrapec = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioKonechRazn = new System.Windows.Forms.RadioButton();
            this.radioPontrGalerk = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1Approx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2Approx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3Approx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(829, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 100);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Column2,
            this.Column1,
            this.Column3,
            this.x2Real,
            this.x3Real,
            this.x1Approx,
            this.x2Approx,
            this.x3Approx});
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 224);
            this.dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить данные";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Задача";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Функции";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioRungeKutti);
            this.panel1.Controls.Add(this.radioXoyn);
            this.panel1.Controls.Add(this.radioEilerPeres);
            this.panel1.Controls.Add(this.radioModifEiler);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(104, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 127);
            this.panel1.TabIndex = 13;
            // 
            // radioRungeKutti
            // 
            this.radioRungeKutti.AutoSize = true;
            this.radioRungeKutti.Location = new System.Drawing.Point(11, 97);
            this.radioRungeKutti.Name = "radioRungeKutti";
            this.radioRungeKutti.Size = new System.Drawing.Size(135, 17);
            this.radioRungeKutti.TabIndex = 4;
            this.radioRungeKutti.Text = "Метод Рунге-Кутты IV";
            this.radioRungeKutti.UseVisualStyleBackColor = true;
            // 
            // radioXoyn
            // 
            this.radioXoyn.AutoSize = true;
            this.radioXoyn.Location = new System.Drawing.Point(11, 74);
            this.radioXoyn.Name = "radioXoyn";
            this.radioXoyn.Size = new System.Drawing.Size(91, 17);
            this.radioXoyn.TabIndex = 3;
            this.radioXoyn.Text = "Метод Хойна";
            this.radioXoyn.UseVisualStyleBackColor = true;
            // 
            // radioEilerPeres
            // 
            this.radioEilerPeres.AutoSize = true;
            this.radioEilerPeres.Location = new System.Drawing.Point(11, 51);
            this.radioEilerPeres.Name = "radioEilerPeres";
            this.radioEilerPeres.Size = new System.Drawing.Size(169, 17);
            this.radioEilerPeres.TabIndex = 2;
            this.radioEilerPeres.Text = "Метод Эйлера с пересчетом";
            this.radioEilerPeres.UseVisualStyleBackColor = true;
            // 
            // radioModifEiler
            // 
            this.radioModifEiler.AutoSize = true;
            this.radioModifEiler.Checked = true;
            this.radioModifEiler.Location = new System.Drawing.Point(11, 28);
            this.radioModifEiler.Name = "radioModifEiler";
            this.radioModifEiler.Size = new System.Drawing.Size(202, 17);
            this.radioModifEiler.TabIndex = 1;
            this.radioModifEiler.TabStop = true;
            this.radioModifEiler.Text = "Модифицированный метод Эйлера";
            this.radioModifEiler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метод для решения системы";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioPravixPram);
            this.panel2.Controls.Add(this.radioSrednixPram);
            this.panel2.Controls.Add(this.radioLevixPram);
            this.panel2.Controls.Add(this.radioTrapec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(350, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 127);
            this.panel2.TabIndex = 14;
            // 
            // radioPravixPram
            // 
            this.radioPravixPram.AutoSize = true;
            this.radioPravixPram.Location = new System.Drawing.Point(14, 97);
            this.radioPravixPram.Name = "radioPravixPram";
            this.radioPravixPram.Size = new System.Drawing.Size(190, 17);
            this.radioPravixPram.TabIndex = 4;
            this.radioPravixPram.Text = "Метод правых прямоугольников";
            this.radioPravixPram.UseVisualStyleBackColor = true;
            // 
            // radioSrednixPram
            // 
            this.radioSrednixPram.AutoSize = true;
            this.radioSrednixPram.Location = new System.Drawing.Point(14, 74);
            this.radioSrednixPram.Name = "radioSrednixPram";
            this.radioSrednixPram.Size = new System.Drawing.Size(194, 17);
            this.radioSrednixPram.TabIndex = 3;
            this.radioSrednixPram.Text = "Метод средних прямоугольников";
            this.radioSrednixPram.UseVisualStyleBackColor = true;
            // 
            // radioLevixPram
            // 
            this.radioLevixPram.AutoSize = true;
            this.radioLevixPram.Location = new System.Drawing.Point(14, 51);
            this.radioLevixPram.Name = "radioLevixPram";
            this.radioLevixPram.Size = new System.Drawing.Size(185, 17);
            this.radioLevixPram.TabIndex = 2;
            this.radioLevixPram.Text = "Метод левый прямоугольников";
            this.radioLevixPram.UseVisualStyleBackColor = true;
            // 
            // radioTrapec
            // 
            this.radioTrapec.AutoSize = true;
            this.radioTrapec.Checked = true;
            this.radioTrapec.Location = new System.Drawing.Point(14, 28);
            this.radioTrapec.Name = "radioTrapec";
            this.radioTrapec.Size = new System.Drawing.Size(107, 17);
            this.radioTrapec.TabIndex = 1;
            this.radioTrapec.TabStop = true;
            this.radioTrapec.Text = "Метод трапеций";
            this.radioTrapec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Метод для решения интеграла";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioKonechRazn);
            this.panel3.Controls.Add(this.radioPontrGalerk);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(595, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 127);
            this.panel3.TabIndex = 15;
            // 
            // radioKonechRazn
            // 
            this.radioKonechRazn.AutoSize = true;
            this.radioKonechRazn.Location = new System.Drawing.Point(21, 51);
            this.radioKonechRazn.Name = "radioKonechRazn";
            this.radioKonechRazn.Size = new System.Drawing.Size(164, 17);
            this.radioKonechRazn.TabIndex = 2;
            this.radioKonechRazn.Text = "Метод конечных разностей";
            this.radioKonechRazn.UseVisualStyleBackColor = true;
            // 
            // radioPontrGalerk
            // 
            this.radioPontrGalerk.AutoSize = true;
            this.radioPontrGalerk.Checked = true;
            this.radioPontrGalerk.Location = new System.Drawing.Point(21, 28);
            this.radioPontrGalerk.Name = "radioPontrGalerk";
            this.radioPontrGalerk.Size = new System.Drawing.Size(177, 17);
            this.radioPontrGalerk.TabIndex = 1;
            this.radioPontrGalerk.TabStop = true;
            this.radioPontrGalerk.Text = "Метод Понтрягина-Галеркина";
            this.radioPontrGalerk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Метод для нахождения градиента";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(129, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Сохранить в файл";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "uReal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "uApprox";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "x1Real";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // x2Real
            // 
            this.x2Real.HeaderText = "x2Real";
            this.x2Real.Name = "x2Real";
            this.x2Real.ReadOnly = true;
            // 
            // x3Real
            // 
            this.x3Real.HeaderText = "x3Real";
            this.x3Real.Name = "x3Real";
            this.x3Real.ReadOnly = true;
            // 
            // x1Approx
            // 
            this.x1Approx.HeaderText = "x1Approx";
            this.x1Approx.Name = "x1Approx";
            this.x1Approx.ReadOnly = true;
            // 
            // x2Approx
            // 
            this.x2Approx.HeaderText = "x2Approx";
            this.x2Approx.Name = "x2Approx";
            this.x2Approx.ReadOnly = true;
            // 
            // x3Approx
            // 
            this.x3Approx.HeaderText = "x3Approx";
            this.x3Approx.Name = "x3Approx";
            this.x3Approx.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 415);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioRungeKutti;
        private System.Windows.Forms.RadioButton radioXoyn;
        private System.Windows.Forms.RadioButton radioEilerPeres;
        private System.Windows.Forms.RadioButton radioModifEiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioPravixPram;
        private System.Windows.Forms.RadioButton radioSrednixPram;
        private System.Windows.Forms.RadioButton radioLevixPram;
        private System.Windows.Forms.RadioButton radioTrapec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioKonechRazn;
        private System.Windows.Forms.RadioButton radioPontrGalerk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2Real;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3Real;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1Approx;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2Approx;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3Approx;
    }
}

