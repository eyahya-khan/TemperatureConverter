namespace TemperatureConverter
{
    partial class TemparatureConvert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFahrenheight = new System.Windows.Forms.TextBox();
            this.txtCelcious = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheight = new System.Windows.Forms.Button();
            this.btnConvertCelcious = new System.Windows.Forms.Button();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(125, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(165, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celcious";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(187, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txtFahrenheight
            // 
            this.txtFahrenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheight.Location = new System.Drawing.Point(278, 91);
            this.txtFahrenheight.Name = "txtFahrenheight";
            this.txtFahrenheight.Size = new System.Drawing.Size(141, 32);
            this.txtFahrenheight.TabIndex = 3;
            this.txtFahrenheight.TextChanged += new System.EventHandler(this.txtFahrenheightChange);
            // 
            // txtCelcious
            // 
            this.txtCelcious.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcious.Location = new System.Drawing.Point(278, 143);
            this.txtCelcious.Name = "txtCelcious";
            this.txtCelcious.Size = new System.Drawing.Size(141, 32);
            this.txtCelcious.TabIndex = 4;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvin.Location = new System.Drawing.Point(278, 203);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(141, 32);
            this.txtKelvin.TabIndex = 5;
            // 
            // btnConvertFahrenheight
            // 
            this.btnConvertFahrenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFahrenheight.Location = new System.Drawing.Point(448, 91);
            this.btnConvertFahrenheight.Name = "btnConvertFahrenheight";
            this.btnConvertFahrenheight.Size = new System.Drawing.Size(110, 32);
            this.btnConvertFahrenheight.TabIndex = 6;
            this.btnConvertFahrenheight.Text = "Convert";
            this.btnConvertFahrenheight.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheight.Click += new System.EventHandler(this.btnConvertFahrenheight_Click);
            // 
            // btnConvertCelcious
            // 
            this.btnConvertCelcious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCelcious.Location = new System.Drawing.Point(448, 143);
            this.btnConvertCelcious.Name = "btnConvertCelcious";
            this.btnConvertCelcious.Size = new System.Drawing.Size(110, 31);
            this.btnConvertCelcious.TabIndex = 7;
            this.btnConvertCelcious.Text = "Convert";
            this.btnConvertCelcious.UseVisualStyleBackColor = true;
            this.btnConvertCelcious.Click += new System.EventHandler(this.btnConvertCelcious_Click);
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertKelvin.Location = new System.Drawing.Point(448, 203);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(110, 32);
            this.btnConvertKelvin.TabIndex = 8;
            this.btnConvertKelvin.Text = "Convert";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // TemparatureConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.btnConvertCelcious);
            this.Controls.Add(this.btnConvertFahrenheight);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelcious);
            this.Controls.Add(this.txtFahrenheight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TemparatureConvert";
            this.Text = "TemparatureConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrenheight;
        private System.Windows.Forms.TextBox txtCelcious;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnConvertFahrenheight;
        private System.Windows.Forms.Button btnConvertCelcious;
        private System.Windows.Forms.Button btnConvertKelvin;
    }
}

