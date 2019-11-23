namespace Loja.WindownsForms
{
    partial class VeiculoForm
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
            this.components = new System.ComponentModel.Container();
            this.Placa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.observacaoGroupBox = new System.Windows.Forms.GroupBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.veiculoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.observacaoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Location = new System.Drawing.Point(13, 13);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(34, 13);
            this.Placa.TabIndex = 2;
            this.Placa.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Câmbio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Combustível";
            // 
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(53, 121);
            this.anoMaskedTextBox.Mask = "0000";
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.anoMaskedTextBox.TabIndex = 3;
            this.anoMaskedTextBox.Tag = "*";
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(295, 48);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustivelComboBox.TabIndex = 6;
            this.combustivelComboBox.Tag = "*";
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(295, 85);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(121, 21);
            this.cambioComboBox.TabIndex = 7;
            this.cambioComboBox.Tag = "*";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(53, 10);
            this.placaMaskedTextBox.Mask = ">LLL<-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.placaMaskedTextBox.TabIndex = 0;
            this.placaMaskedTextBox.Tag = "*";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(53, 52);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(121, 21);
            this.marcaComboBox.TabIndex = 1;
            this.marcaComboBox.Tag = "*";
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(53, 84);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(121, 21);
            this.modeloComboBox.TabIndex = 2;
            this.modeloComboBox.Tag = "*";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(446, 32);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(85, 50);
            this.gravarButton.TabIndex = 8;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(537, 31);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(92, 51);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            // 
            // observacaoGroupBox
            // 
            this.observacaoGroupBox.Controls.Add(this.observacaoTextBox);
            this.observacaoGroupBox.Location = new System.Drawing.Point(13, 177);
            this.observacaoGroupBox.Name = "observacaoGroupBox";
            this.observacaoGroupBox.Size = new System.Drawing.Size(642, 128);
            this.observacaoGroupBox.TabIndex = 4;
            this.observacaoGroupBox.TabStop = false;
            this.observacaoGroupBox.Text = "Observação (300)";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Location = new System.Drawing.Point(7, 20);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(629, 102);
            this.observacaoTextBox.TabIndex = 0;
            // 
            // corComboBox
            // 
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(295, 10);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(121, 21);
            this.corComboBox.TabIndex = 5;
            this.corComboBox.Tag = "*";
            // 
            // veiculoErrorProvider
            // 
            this.veiculoErrorProvider.ContainerControl = this;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 317);
            this.Controls.Add(this.observacaoGroupBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.corComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.anoMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Placa);
            this.Name = "VeiculoForm";
            this.Text = "Cadrastro de Veículos";
            this.Load += new System.EventHandler(this.VeiculoForm_Load);
            this.observacaoGroupBox.ResumeLayout(false);
            this.observacaoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.GroupBox observacaoGroupBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.ErrorProvider veiculoErrorProvider;
    }
}

