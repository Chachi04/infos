
namespace BrigadaNovDom
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
            this.FloorType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kartina = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Loss = new System.Windows.Forms.TextBox();
            this.FinalPrice = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kartina)).BeginInit();
            this.SuspendLayout();
            // 
            // FloorType
            // 
            this.FloorType.FormattingEnabled = true;
            this.FloorType.Items.AddRange(new object[] {
            "Паркет Африкански дъб - 196 лв.",
            "Паркет Африкански дъб Тундра - 196 лв.",
            "Паркет Мербау - 170 лв.",
            "Паркет Парен бук Универсал - 122 лв.",
            "Паркет Ясен - 158 лв."});
            this.FloorType.Location = new System.Drawing.Point(86, 46);
            this.FloorType.Name = "FloorType";
            this.FloorType.Size = new System.Drawing.Size(139, 24);
            this.FloorType.TabIndex = 0;
            this.FloorType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид под";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Под";
            // 
            // Kartina
            // 
            this.Kartina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kartina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kartina.Location = new System.Drawing.Point(187, 85);
            this.Kartina.Name = "Kartina";
            this.Kartina.Size = new System.Drawing.Size(210, 60);
            this.Kartina.TabIndex = 3;
            this.Kartina.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "y: ";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(87, 87);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(68, 22);
            this.X.TabIndex = 6;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(87, 125);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(68, 22);
            this.Y.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Загуба (%)";
            // 
            // Loss
            // 
            this.Loss.Location = new System.Drawing.Point(329, 46);
            this.Loss.Name = "Loss";
            this.Loss.Size = new System.Drawing.Size(68, 22);
            this.Loss.TabIndex = 9;
            // 
            // FinalPrice
            // 
            this.FinalPrice.AutoSize = true;
            this.FinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FinalPrice.Location = new System.Drawing.Point(198, 163);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(125, 20);
            this.FinalPrice.TabIndex = 10;
            this.FinalPrice.Text = "Крайна цена: ";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(65, 163);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(97, 23);
            this.calc.TabIndex = 11;
            this.calc.Text = "Присметни";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 197);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.FinalPrice);
            this.Controls.Add(this.Loss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kartina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FloorType);
            this.Name = "Form1";
            this.Text = "Бригада Нов Дом";
            ((System.ComponentModel.ISupportInitialize)(this.Kartina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FloorType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Kartina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Loss;
        private System.Windows.Forms.Label FinalPrice;
        private System.Windows.Forms.Button calc;
    }
}

