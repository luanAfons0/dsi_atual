
namespace CalcularVendas
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picBoxPagamento = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cboPag = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lvlPreco = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.picBoxPagamento);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCalc);
            this.splitContainer1.Panel2.Controls.Add(this.cboPag);
            this.splitContainer1.Panel2.Controls.Add(this.txtPreco);
            this.splitContainer1.Panel2.Controls.Add(this.txtQtde);
            this.splitContainer1.Panel2.Controls.Add(this.lblPagamento);
            this.splitContainer1.Panel2.Controls.Add(this.lvlPreco);
            this.splitContainer1.Panel2.Controls.Add(this.lblQtde);
            this.splitContainer1.Size = new System.Drawing.Size(800, 369);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // picBoxPagamento
            // 
            this.picBoxPagamento.Location = new System.Drawing.Point(32, 224);
            this.picBoxPagamento.Name = "picBoxPagamento";
            this.picBoxPagamento.Size = new System.Drawing.Size(173, 122);
            this.picBoxPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPagamento.TabIndex = 1;
            this.picBoxPagamento.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcularVendas.Properties.Resources.carrinho;
            this.pictureBox1.Location = new System.Drawing.Point(32, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCalc.Location = new System.Drawing.Point(354, 290);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 41);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cboPag
            // 
            this.cboPag.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboPag.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPag.ForeColor = System.Drawing.SystemColors.Window;
            this.cboPag.FormattingEnabled = true;
            this.cboPag.Items.AddRange(new object[] {
            "Selecione",
            "Crédito ",
            "Debito",
            "Dinheiro",
            "Parcela 2 vezes"});
            this.cboPag.Location = new System.Drawing.Point(341, 224);
            this.cboPag.Name = "cboPag";
            this.cboPag.Size = new System.Drawing.Size(152, 36);
            this.cboPag.TabIndex = 6;
            this.cboPag.SelectedIndexChanged += new System.EventHandler(this.cboPag_SelectedIndexChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPreco.Location = new System.Drawing.Point(341, 158);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 34);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtde.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQtde.Location = new System.Drawing.Point(341, 93);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(152, 34);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(5, 214);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(330, 46);
            this.lblPagamento.TabIndex = 2;
            this.lblPagamento.Text = "Tipo de pagamento :";
            // 
            // lvlPreco
            // 
            this.lvlPreco.AutoSize = true;
            this.lvlPreco.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlPreco.Location = new System.Drawing.Point(214, 148);
            this.lvlPreco.Name = "lvlPreco";
            this.lvlPreco.Size = new System.Drawing.Size(121, 46);
            this.lvlPreco.TabIndex = 1;
            this.lvlPreco.Text = "Preço :";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtde.Location = new System.Drawing.Point(123, 93);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(212, 46);
            this.lblQtde.TabIndex = 0;
            this.lblQtde.Text = "Quantidade :";
            this.lblQtde.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(611, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 46);
            this.lblTotal.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Image = global::CalcularVendas.Properties.Resources.editar;
            this.button2.Location = new System.Drawing.Point(91, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 51);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CalcularVendas.Properties.Resources.fechar;
            this.button1.Location = new System.Drawing.Point(32, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "FModel";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lvlPreco;
        private System.Windows.Forms.ComboBox cboPag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox picBoxPagamento;
    }
}