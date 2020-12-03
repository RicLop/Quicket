namespace Quicket.Presentation
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
            this.lbClienteId = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbAssunto = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtAssunto = new System.Windows.Forms.RichTextBox();
            this.chkNovoTicket = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbClienteId
            // 
            this.lbClienteId.AutoSize = true;
            this.lbClienteId.Location = new System.Drawing.Point(12, 9);
            this.lbClienteId.Name = "lbClienteId";
            this.lbClienteId.Size = new System.Drawing.Size(76, 15);
            this.lbClienteId.TabIndex = 0;
            this.lbClienteId.Text = "ID do cliente:";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(12, 27);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(222, 23);
            this.txtClienteId.TabIndex = 1;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(12, 53);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(106, 15);
            this.lbSenha.TabIndex = 0;
            this.lbSenha.Text = "Senha da conexão:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 71);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(222, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // lbAssunto
            // 
            this.lbAssunto.AutoSize = true;
            this.lbAssunto.Location = new System.Drawing.Point(11, 123);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(53, 15);
            this.lbAssunto.TabIndex = 0;
            this.lbAssunto.Text = "Assunto:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 262);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(220, 39);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(11, 141);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(221, 96);
            this.txtAssunto.TabIndex = 4;
            this.txtAssunto.Text = "";
            // 
            // chkNovoTicket
            // 
            this.chkNovoTicket.AutoSize = true;
            this.chkNovoTicket.Checked = true;
            this.chkNovoTicket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNovoTicket.Location = new System.Drawing.Point(13, 101);
            this.chkNovoTicket.Name = "chkNovoTicket";
            this.chkNovoTicket.Size = new System.Drawing.Size(116, 19);
            this.chkNovoTicket.TabIndex = 4;
            this.chkNovoTicket.Text = "Gerar novo ticket";
            this.chkNovoTicket.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 313);
            this.Controls.Add(this.chkNovoTicket);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lbAssunto);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.lbClienteId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Quicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClienteId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbAssunto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.RichTextBox txtAssunto;
        private System.Windows.Forms.CheckBox chkNovoTicket;
    }
}

