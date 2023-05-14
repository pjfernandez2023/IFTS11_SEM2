namespace WinFormsApp1_Clase20220823
{
    partial class MiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1_resta = new System.Windows.Forms.TextBox();
            this.textBox1_multi = new System.Windows.Forms.TextBox();
            this.textBox1_div = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1_resta = new System.Windows.Forms.Label();
            this.label2_Resta = new System.Windows.Forms.Label();
            this.button2_resta = new System.Windows.Forms.Button();
            this.labelsignoresta = new System.Windows.Forms.Label();
            this.button1_resta = new System.Windows.Forms.Button();
            this.textBox2_resta = new System.Windows.Forms.TextBox();
            this.textBoxresultado_resta = new System.Windows.Forms.TextBox();
            this.button2_limpia_multi = new System.Windows.Forms.Button();
            this.labelsigno_multi = new System.Windows.Forms.Label();
            this.button1_multi = new System.Windows.Forms.Button();
            this.textBox2_multi = new System.Windows.Forms.TextBox();
            this.textBox3_resultado_multi = new System.Windows.Forms.TextBox();
            this.label2_muti = new System.Windows.Forms.Label();
            this.label1_multi = new System.Windows.Forms.Label();
            this.button2_limpia_div = new System.Windows.Forms.Button();
            this.labelsigno_div = new System.Windows.Forms.Label();
            this.button1_div = new System.Windows.Forms.Button();
            this.textBox2_div = new System.Windows.Forms.TextBox();
            this.textBox3_div = new System.Windows.Forms.TextBox();
            this.label2_div = new System.Windows.Forms.Label();
            this.label1_div = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumero1.Location = new System.Drawing.Point(35, 39);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(66, 14);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumero2.Location = new System.Drawing.Point(173, 39);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(66, 14);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(346, 58);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 23);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(173, 58);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero1.Location = new System.Drawing.Point(35, 58);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 23);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            this.txtNumero1.MouseHover += new System.EventHandler(this.txtNumero1_MouseHover);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResultado.Location = new System.Drawing.Point(287, 58);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(40, 23);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(35, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 14);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cargue dos números a sumar y presione el botón igual \"=\"";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(346, 39);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 14);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuma.Location = new System.Drawing.Point(141, 58);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(26, 23);
            this.lblSuma.TabIndex = 8;
            this.lblSuma.Text = "+";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "TituloToolTip";
            // 
            // textBox1_resta
            // 
            this.textBox1_resta.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1_resta.Location = new System.Drawing.Point(35, 107);
            this.textBox1_resta.Name = "textBox1_resta";
            this.textBox1_resta.Size = new System.Drawing.Size(100, 23);
            this.textBox1_resta.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBox1_resta, "Valor Del primer número a sumar");
            this.textBox1_resta.TextChanged += new System.EventHandler(this.textBox1_resta_TextChanged);
            // 
            // textBox1_multi
            // 
            this.textBox1_multi.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1_multi.Location = new System.Drawing.Point(35, 154);
            this.textBox1_multi.Name = "textBox1_multi";
            this.textBox1_multi.Size = new System.Drawing.Size(100, 23);
            this.textBox1_multi.TabIndex = 20;
            this.toolTip1.SetToolTip(this.textBox1_multi, "Valor Del primer número a sumar");
            this.textBox1_multi.TextChanged += new System.EventHandler(this.textBox1_multi_TextChanged);
            // 
            // textBox1_div
            // 
            this.textBox1_div.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1_div.Location = new System.Drawing.Point(35, 204);
            this.textBox1_div.Name = "textBox1_div";
            this.textBox1_div.Size = new System.Drawing.Size(100, 23);
            this.textBox1_div.TabIndex = 28;
            this.toolTip1.SetToolTip(this.textBox1_div, "Valor Del primer número a sumar");
            this.textBox1_div.TextChanged += new System.EventHandler(this.textBox1_div_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(463, 58);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "CE";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1_resta
            // 
            this.label1_resta.AutoSize = true;
            this.label1_resta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_resta.Location = new System.Drawing.Point(34, 88);
            this.label1_resta.Name = "label1_resta";
            this.label1_resta.Size = new System.Drawing.Size(68, 16);
            this.label1_resta.TabIndex = 10;
            this.label1_resta.Text = "Numero 1";
            this.label1_resta.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2_Resta
            // 
            this.label2_Resta.AutoSize = true;
            this.label2_Resta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_Resta.Location = new System.Drawing.Point(173, 88);
            this.label2_Resta.Name = "label2_Resta";
            this.label2_Resta.Size = new System.Drawing.Size(68, 16);
            this.label2_Resta.TabIndex = 11;
            this.label2_Resta.Text = "Numero 2";
            this.label2_Resta.UseMnemonic = false;
            // 
            // button2_resta
            // 
            this.button2_resta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_resta.Location = new System.Drawing.Point(463, 107);
            this.button2_resta.Name = "button2_resta";
            this.button2_resta.Size = new System.Drawing.Size(40, 23);
            this.button2_resta.TabIndex = 17;
            this.button2_resta.Text = "CE";
            this.button2_resta.UseVisualStyleBackColor = true;
            this.button2_resta.Click += new System.EventHandler(this.button2_resta_Click);
            // 
            // labelsignoresta
            // 
            this.labelsignoresta.AutoSize = true;
            this.labelsignoresta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsignoresta.Location = new System.Drawing.Point(141, 107);
            this.labelsignoresta.Name = "labelsignoresta";
            this.labelsignoresta.Size = new System.Drawing.Size(18, 23);
            this.labelsignoresta.TabIndex = 16;
            this.labelsignoresta.Text = "-";
            // 
            // button1_resta
            // 
            this.button1_resta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_resta.Location = new System.Drawing.Point(287, 107);
            this.button1_resta.Name = "button1_resta";
            this.button1_resta.Size = new System.Drawing.Size(40, 23);
            this.button1_resta.TabIndex = 14;
            this.button1_resta.Text = "=";
            this.button1_resta.UseVisualStyleBackColor = true;
            this.button1_resta.Click += new System.EventHandler(this.button1_resta_Click);
            // 
            // textBox2_resta
            // 
            this.textBox2_resta.Location = new System.Drawing.Point(173, 107);
            this.textBox2_resta.Name = "textBox2_resta";
            this.textBox2_resta.Size = new System.Drawing.Size(100, 23);
            this.textBox2_resta.TabIndex = 13;
            this.textBox2_resta.TextChanged += new System.EventHandler(this.textBox2_resta_TextChanged);
            // 
            // textBoxresultado_resta
            // 
            this.textBoxresultado_resta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBoxresultado_resta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxresultado_resta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxresultado_resta.Enabled = false;
            this.textBoxresultado_resta.Location = new System.Drawing.Point(346, 107);
            this.textBoxresultado_resta.Name = "textBoxresultado_resta";
            this.textBoxresultado_resta.Size = new System.Drawing.Size(100, 23);
            this.textBoxresultado_resta.TabIndex = 15;
            this.textBoxresultado_resta.TextChanged += new System.EventHandler(this.textBoxresultado_resta_TextChanged);
            // 
            // button2_limpia_multi
            // 
            this.button2_limpia_multi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_limpia_multi.Location = new System.Drawing.Point(463, 154);
            this.button2_limpia_multi.Name = "button2_limpia_multi";
            this.button2_limpia_multi.Size = new System.Drawing.Size(40, 23);
            this.button2_limpia_multi.TabIndex = 25;
            this.button2_limpia_multi.Text = "CE";
            this.button2_limpia_multi.UseVisualStyleBackColor = true;
            this.button2_limpia_multi.Click += new System.EventHandler(this.button2_limpia_multi_Click);
            // 
            // labelsigno_multi
            // 
            this.labelsigno_multi.AutoSize = true;
            this.labelsigno_multi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsigno_multi.Location = new System.Drawing.Point(141, 154);
            this.labelsigno_multi.Name = "labelsigno_multi";
            this.labelsigno_multi.Size = new System.Drawing.Size(21, 23);
            this.labelsigno_multi.TabIndex = 24;
            this.labelsigno_multi.Text = "x";
            // 
            // button1_multi
            // 
            this.button1_multi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_multi.Location = new System.Drawing.Point(287, 154);
            this.button1_multi.Name = "button1_multi";
            this.button1_multi.Size = new System.Drawing.Size(40, 23);
            this.button1_multi.TabIndex = 22;
            this.button1_multi.Text = "=";
            this.button1_multi.UseVisualStyleBackColor = true;
            this.button1_multi.Click += new System.EventHandler(this.button1_multi_Click);
            // 
            // textBox2_multi
            // 
            this.textBox2_multi.Location = new System.Drawing.Point(173, 154);
            this.textBox2_multi.Name = "textBox2_multi";
            this.textBox2_multi.Size = new System.Drawing.Size(100, 23);
            this.textBox2_multi.TabIndex = 21;
            this.textBox2_multi.TextChanged += new System.EventHandler(this.textBox2_multi_TextChanged);
            // 
            // textBox3_resultado_multi
            // 
            this.textBox3_resultado_multi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox3_resultado_multi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3_resultado_multi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3_resultado_multi.Enabled = false;
            this.textBox3_resultado_multi.Location = new System.Drawing.Point(346, 154);
            this.textBox3_resultado_multi.Name = "textBox3_resultado_multi";
            this.textBox3_resultado_multi.Size = new System.Drawing.Size(100, 23);
            this.textBox3_resultado_multi.TabIndex = 23;
            // 
            // label2_muti
            // 
            this.label2_muti.AutoSize = true;
            this.label2_muti.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_muti.Location = new System.Drawing.Point(173, 135);
            this.label2_muti.Name = "label2_muti";
            this.label2_muti.Size = new System.Drawing.Size(68, 16);
            this.label2_muti.TabIndex = 19;
            this.label2_muti.Text = "Numero 2";
            this.label2_muti.UseMnemonic = false;
            // 
            // label1_multi
            // 
            this.label1_multi.AutoSize = true;
            this.label1_multi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_multi.Location = new System.Drawing.Point(34, 135);
            this.label1_multi.Name = "label1_multi";
            this.label1_multi.Size = new System.Drawing.Size(68, 16);
            this.label1_multi.TabIndex = 18;
            this.label1_multi.Text = "Numero 1";
            // 
            // button2_limpia_div
            // 
            this.button2_limpia_div.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_limpia_div.Location = new System.Drawing.Point(463, 204);
            this.button2_limpia_div.Name = "button2_limpia_div";
            this.button2_limpia_div.Size = new System.Drawing.Size(40, 23);
            this.button2_limpia_div.TabIndex = 33;
            this.button2_limpia_div.Text = "CE";
            this.button2_limpia_div.UseVisualStyleBackColor = true;
            this.button2_limpia_div.Click += new System.EventHandler(this.button2_limpia_div_Click);
            // 
            // labelsigno_div
            // 
            this.labelsigno_div.AutoSize = true;
            this.labelsigno_div.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsigno_div.Location = new System.Drawing.Point(141, 204);
            this.labelsigno_div.Name = "labelsigno_div";
            this.labelsigno_div.Size = new System.Drawing.Size(21, 23);
            this.labelsigno_div.TabIndex = 32;
            this.labelsigno_div.Text = "/";
            // 
            // button1_div
            // 
            this.button1_div.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_div.Location = new System.Drawing.Point(287, 204);
            this.button1_div.Name = "button1_div";
            this.button1_div.Size = new System.Drawing.Size(40, 23);
            this.button1_div.TabIndex = 30;
            this.button1_div.Text = "=";
            this.button1_div.UseVisualStyleBackColor = true;
            this.button1_div.Click += new System.EventHandler(this.button1_div_Click);
            // 
            // textBox2_div
            // 
            this.textBox2_div.Location = new System.Drawing.Point(173, 204);
            this.textBox2_div.Name = "textBox2_div";
            this.textBox2_div.Size = new System.Drawing.Size(100, 23);
            this.textBox2_div.TabIndex = 29;
            this.textBox2_div.TextChanged += new System.EventHandler(this.textBox2_div_TextChanged);
            // 
            // textBox3_div
            // 
            this.textBox3_div.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox3_div.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3_div.Enabled = false;
            this.textBox3_div.Location = new System.Drawing.Point(346, 204);
            this.textBox3_div.Name = "textBox3_div";
            this.textBox3_div.Size = new System.Drawing.Size(100, 23);
            this.textBox3_div.TabIndex = 31;
            // 
            // label2_div
            // 
            this.label2_div.AutoSize = true;
            this.label2_div.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_div.Location = new System.Drawing.Point(173, 185);
            this.label2_div.Name = "label2_div";
            this.label2_div.Size = new System.Drawing.Size(68, 16);
            this.label2_div.TabIndex = 27;
            this.label2_div.Text = "Numero 2";
            this.label2_div.UseMnemonic = false;
            // 
            // label1_div
            // 
            this.label1_div.AutoSize = true;
            this.label1_div.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_div.Location = new System.Drawing.Point(34, 185);
            this.label1_div.Name = "label1_div";
            this.label1_div.Size = new System.Drawing.Size(68, 16);
            this.label1_div.TabIndex = 26;
            this.label1_div.Text = "Numero 1";
            // 
            // MiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 239);
            this.Controls.Add(this.button2_limpia_div);
            this.Controls.Add(this.labelsigno_div);
            this.Controls.Add(this.button1_div);
            this.Controls.Add(this.textBox2_div);
            this.Controls.Add(this.textBox3_div);
            this.Controls.Add(this.textBox1_div);
            this.Controls.Add(this.label2_div);
            this.Controls.Add(this.label1_div);
            this.Controls.Add(this.button2_limpia_multi);
            this.Controls.Add(this.labelsigno_multi);
            this.Controls.Add(this.button1_multi);
            this.Controls.Add(this.textBox2_multi);
            this.Controls.Add(this.textBox3_resultado_multi);
            this.Controls.Add(this.textBox1_multi);
            this.Controls.Add(this.label2_muti);
            this.Controls.Add(this.label1_multi);
            this.Controls.Add(this.button2_resta);
            this.Controls.Add(this.labelsignoresta);
            this.Controls.Add(this.button1_resta);
            this.Controls.Add(this.textBox2_resta);
            this.Controls.Add(this.textBoxresultado_resta);
            this.Controls.Add(this.textBox1_resta);
            this.Controls.Add(this.label2_Resta);
            this.Controls.Add(this.label1_resta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MiForm";
            this.Text = "Formulario Hola Mundo";
            this.toolTip1.SetToolTip(this, "False");
            this.Load += new System.EventHandler(this.MiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1_resta;
        private System.Windows.Forms.Label label2_Resta;
        private System.Windows.Forms.Button button2_resta;
        private System.Windows.Forms.Label labelsignoresta;
        private System.Windows.Forms.Button button1_resta;
        private System.Windows.Forms.TextBox textBox2_resta;
        private System.Windows.Forms.TextBox textBoxresultado_resta;
        private System.Windows.Forms.TextBox textBox1_resta;
        private System.Windows.Forms.Button button2_limpia_multi;
        private System.Windows.Forms.Label labelsigno_multi;
        private System.Windows.Forms.Button button1_multi;
        private System.Windows.Forms.TextBox textBox2_multi;
        private System.Windows.Forms.TextBox textBox3_resultado_multi;
        private System.Windows.Forms.TextBox textBox1_multi;
        private System.Windows.Forms.Label label2_muti;
        private System.Windows.Forms.Label label1_multi;
        private System.Windows.Forms.Button button2_limpia_div;
        private System.Windows.Forms.Label labelsigno_div;
        private System.Windows.Forms.Button button1_div;
        private System.Windows.Forms.TextBox textBox2_div;
        private System.Windows.Forms.TextBox textBox3_div;
        private System.Windows.Forms.TextBox textBox1_div;
        private System.Windows.Forms.Label label2_div;
        private System.Windows.Forms.Label label1_div;
    }
}
