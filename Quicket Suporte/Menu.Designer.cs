namespace Quicket_Suporte
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.RichTextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chkNovoTicket = new System.Windows.Forms.CheckBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.cbClienteId = new System.Windows.Forms.ComboBox();
            this.cbClienteNome = new System.Windows.Forms.ComboBox();
            this.cbSenha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id do cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha da conexão:";
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Location = new System.Drawing.Point(12, 166);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(53, 15);
            this.lbAssunto.TabIndex = 0;
            this.lbAssunto.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(13, 184);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(245, 96);
            this.txtAssunto.TabIndex = 5;
            this.txtAssunto.Text = "";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(11, 286);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(245, 34);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // chkNovoTicket
            // 
            this.chkNovoTicket.AutoSize = true;
            this.chkNovoTicket.Checked = true;
            this.chkNovoTicket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNovoTicket.Location = new System.Drawing.Point(12, 100);
            this.chkNovoTicket.Name = "chkNovoTicket";
            this.chkNovoTicket.Size = new System.Drawing.Size(118, 19);
            this.chkNovoTicket.TabIndex = 3;
            this.chkNovoTicket.Text = "Gerar novo Ticket";
            this.chkNovoTicket.UseVisualStyleBackColor = true;
            this.chkNovoTicket.CheckedChanged += new System.EventHandler(this.chkNovoTicket_CheckedChanged);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(11, 122);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(98, 15);
            this.lbNomeCliente.TabIndex = 6;
            this.lbNomeCliente.Text = "Nome do cliente:";
            // 
            // cbClienteId
            // 
            this.cbClienteId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClienteId.FormattingEnabled = true;
            this.cbClienteId.Location = new System.Drawing.Point(13, 28);
            this.cbClienteId.Name = "cbClienteId";
            this.cbClienteId.Size = new System.Drawing.Size(243, 23);
            this.cbClienteId.TabIndex = 1;
            this.cbClienteId.Leave += new System.EventHandler(this.cbClienteId_Leave);
            // 
            // cbClienteNome
            // 
            this.cbClienteNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClienteNome.FormattingEnabled = true;
            this.cbClienteNome.Location = new System.Drawing.Point(13, 140);
            this.cbClienteNome.Name = "cbClienteNome";
            this.cbClienteNome.Size = new System.Drawing.Size(243, 23);
            this.cbClienteNome.TabIndex = 4;
            // 
            // cbSenha
            // 
            this.cbSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSenha.FormattingEnabled = true;
            this.cbSenha.Location = new System.Drawing.Point(13, 71);
            this.cbSenha.Name = "cbSenha";
            this.cbSenha.Size = new System.Drawing.Size(243, 23);
            this.cbSenha.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 328);
            this.Controls.Add(this.cbSenha);
            this.Controls.Add(this.cbClienteNome);
            this.Controls.Add(this.cbClienteId);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.chkNovoTicket);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lbAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.RichTextBox txtAssunto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.CheckBox chkNovoTicket;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.ComboBox cbClienteId;
        private System.Windows.Forms.ComboBox cbClienteNome;
        private System.Windows.Forms.ComboBox cbSenha;
    }
}

