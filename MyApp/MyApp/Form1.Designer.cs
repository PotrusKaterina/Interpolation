namespace MyApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMinX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaxX = new System.Windows.Forms.TextBox();
            this.textStep = new System.Windows.Forms.TextBox();
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCoefficients = new System.Windows.Forms.TextBox();
            this.labelCoefficients = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(605, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "graphic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LaGrange";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textMinX
            // 
            this.textMinX.Location = new System.Drawing.Point(688, 39);
            this.textMinX.Name = "textMinX";
            this.textMinX.Size = new System.Drawing.Size(134, 20);
            this.textMinX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "X Range";
            // 
            // textMaxX
            // 
            this.textMaxX.Location = new System.Drawing.Point(688, 78);
            this.textMaxX.Name = "textMaxX";
            this.textMaxX.Size = new System.Drawing.Size(134, 20);
            this.textMaxX.TabIndex = 7;
            this.textMaxX.TextChanged += new System.EventHandler(this.textMaxX_TextChanged);
            // 
            // textStep
            // 
            this.textStep.Location = new System.Drawing.Point(688, 138);
            this.textStep.Name = "textStep";
            this.textStep.Size = new System.Drawing.Size(134, 20);
            this.textStep.TabIndex = 8;
            // 
            // comboBoxFunctions
            // 
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Items.AddRange(new object[] {
            "SinX",
            "CosX",
            "Polinomial"});
            this.comboBoxFunctions.Location = new System.Drawing.Point(647, 201);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(175, 21);
            this.comboBoxFunctions.TabIndex = 9;
            this.comboBoxFunctions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Function";
            // 
            // textCoefficients
            // 
            this.textCoefficients.Location = new System.Drawing.Point(647, 257);
            this.textCoefficients.Multiline = true;
            this.textCoefficients.Name = "textCoefficients";
            this.textCoefficients.Size = new System.Drawing.Size(175, 152);
            this.textCoefficients.TabIndex = 11;
            this.textCoefficients.Visible = false;
            this.textCoefficients.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelCoefficients
            // 
            this.labelCoefficients.AutoSize = true;
            this.labelCoefficients.Location = new System.Drawing.Point(644, 225);
            this.labelCoefficients.Name = "labelCoefficients";
            this.labelCoefficients.Size = new System.Drawing.Size(186, 13);
            this.labelCoefficients.TabIndex = 12;
            this.labelCoefficients.Text = "Coefficients (from 0 till max) (by enters)";
            this.labelCoefficients.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(Each by new line)";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Newtone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCoefficients);
            this.Controls.Add(this.textCoefficients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFunctions);
            this.Controls.Add(this.textStep);
            this.Controls.Add(this.textMaxX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMinX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMinX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaxX;
        private System.Windows.Forms.TextBox textStep;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCoefficients;
        private System.Windows.Forms.Label labelCoefficients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

