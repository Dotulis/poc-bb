namespace Poc_Banco_do_brasil
{
    partial class Form1
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
            btnObterToken = new Button();
            btnEmitirBoleto = new Button();
            textBox1 = new TextBox();
            lblConvenio = new Label();
            lblCarteira = new Label();
            txtCobranca = new TextBox();
            lblToken = new Label();
            txtToken = new TextBox();
            lblVariacaoCarteira = new Label();
            txtVariacaoCarteira = new TextBox();
            lblCodigoModalidade = new Label();
            txtCodigoModalidade = new TextBox();
            lblDataEmissao = new Label();
            txtDataEmissao = new TextBox();
            lblDataVencimento = new Label();
            txtDataVencimento = new TextBox();
            lblValorOriginal = new Label();
            txtValorOriginal = new TextBox();
            lblCodigoAceite = new Label();
            txtCodigoAceite = new TextBox();
            lblTipoTitulo = new Label();
            txtTipoTitulo = new TextBox();
            lblDescricaoTipoTitulo = new Label();
            txtDescricaoTipoTitulo = new TextBox();
            lblIndicadorRecebimentoParcial = new Label();
            txtIndicadorRecebimentoParcial = new TextBox();
            lblNumeroBeneficiario = new Label();
            txtNumeroBeneficiario = new TextBox();
            lblNumeroBoleto = new Label();
            txtNumeroBoleto = new TextBox();
            lblPagador = new Label();
            txtPagador = new TextBox();
            lblInscricao = new Label();
            txtInscricao = new TextBox();
            txtJsonResponse = new TextBox();
            SuspendLayout();
            // 
            // btnObterToken
            // 
            btnObterToken.Location = new Point(90, 567);
            btnObterToken.Name = "btnObterToken";
            btnObterToken.Size = new Size(193, 43);
            btnObterToken.TabIndex = 0;
            btnObterToken.Text = "Obter Token";
            btnObterToken.UseVisualStyleBackColor = true;
            btnObterToken.Click += btnObterToken_Click;
            // 
            // btnEmitirBoleto
            // 
            btnEmitirBoleto.Location = new Point(409, 549);
            btnEmitirBoleto.Name = "btnEmitirBoleto";
            btnEmitirBoleto.Size = new Size(191, 61);
            btnEmitirBoleto.TabIndex = 1;
            btnEmitirBoleto.Text = "Emitir Boleto";
            btnEmitirBoleto.UseVisualStyleBackColor = true;
            btnEmitirBoleto.Click += btnEmitirBoleto_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(12, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblConvenio
            // 
            lblConvenio.AutoSize = true;
            lblConvenio.Location = new Point(12, 4);
            lblConvenio.Name = "lblConvenio";
            lblConvenio.Size = new Size(176, 15);
            lblConvenio.TabIndex = 3;
            lblConvenio.Text = "Informe o número do convênio:";
            lblConvenio.Click += lblConvenio_Click;
            // 
            // lblCarteira
            // 
            lblCarteira.AutoSize = true;
            lblCarteira.Location = new Point(12, 53);
            lblCarteira.Name = "lblCarteira";
            lblCarteira.Size = new Size(237, 15);
            lblCarteira.TabIndex = 5;
            lblCarteira.Text = "Informar o número da carteira de cobrança:";
            lblCarteira.TextAlign = ContentAlignment.TopCenter;
            lblCarteira.Click += lblCarteira_Click;
            // 
            // txtCobranca
            // 
            txtCobranca.BackColor = SystemColors.MenuBar;
            txtCobranca.Location = new Point(12, 71);
            txtCobranca.Name = "txtCobranca";
            txtCobranca.Size = new Size(359, 23);
            txtCobranca.TabIndex = 4;
            txtCobranca.TextChanged += txtCobranca_TextChanged;
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Location = new Point(15, 502);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(95, 15);
            lblToken.TabIndex = 7;
            lblToken.Text = "Token adquirido:";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(15, 526);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(359, 23);
            txtToken.TabIndex = 6;
            txtToken.TextChanged += txtToken_TextChanged;
            // 
            // lblVariacaoCarteira
            // 
            lblVariacaoCarteira.AutoSize = true;
            lblVariacaoCarteira.Location = new Point(12, 104);
            lblVariacaoCarteira.Name = "lblVariacaoCarteira";
            lblVariacaoCarteira.Size = new Size(300, 15);
            lblVariacaoCarteira.TabIndex = 9;
            lblVariacaoCarteira.Text = "Informar o número da variação da carteira de cobrança:";
            lblVariacaoCarteira.TextAlign = ContentAlignment.TopCenter;
            lblVariacaoCarteira.Click += lblVariacaoCarteira_Click;
            // 
            // txtVariacaoCarteira
            // 
            txtVariacaoCarteira.BackColor = SystemColors.MenuBar;
            txtVariacaoCarteira.Location = new Point(12, 122);
            txtVariacaoCarteira.Name = "txtVariacaoCarteira";
            txtVariacaoCarteira.Size = new Size(359, 23);
            txtVariacaoCarteira.TabIndex = 8;
            txtVariacaoCarteira.TextChanged += txtVariacaoCarteira_TextChanged;
            // 
            // lblCodigoModalidade
            // 
            lblCodigoModalidade.AutoSize = true;
            lblCodigoModalidade.Location = new Point(12, 158);
            lblCodigoModalidade.Name = "lblCodigoModalidade";
            lblCodigoModalidade.Size = new Size(188, 15);
            lblCodigoModalidade.TabIndex = 11;
            lblCodigoModalidade.Text = "Informar o código da modalidade:";
            lblCodigoModalidade.TextAlign = ContentAlignment.TopCenter;
            lblCodigoModalidade.Click += lblCodigoModalidade_Click;
            // 
            // txtCodigoModalidade
            // 
            txtCodigoModalidade.BackColor = SystemColors.MenuBar;
            txtCodigoModalidade.Location = new Point(12, 176);
            txtCodigoModalidade.Name = "txtCodigoModalidade";
            txtCodigoModalidade.Size = new Size(359, 23);
            txtCodigoModalidade.TabIndex = 10;
            txtCodigoModalidade.TextChanged += txtCodigoModalidade_TextChanged;
            // 
            // lblDataEmissao
            // 
            lblDataEmissao.AutoSize = true;
            lblDataEmissao.Location = new Point(12, 215);
            lblDataEmissao.Name = "lblDataEmissao";
            lblDataEmissao.Size = new Size(153, 15);
            lblDataEmissao.TabIndex = 13;
            lblDataEmissao.Text = "Informar a data de emissão:";
            lblDataEmissao.TextAlign = ContentAlignment.TopCenter;
            lblDataEmissao.Click += lblDataEmissao_Click;
            // 
            // txtDataEmissao
            // 
            txtDataEmissao.BackColor = SystemColors.MenuBar;
            txtDataEmissao.Location = new Point(12, 233);
            txtDataEmissao.Name = "txtDataEmissao";
            txtDataEmissao.Size = new Size(359, 23);
            txtDataEmissao.TabIndex = 12;
            txtDataEmissao.TextChanged += txtDataEmissao_TextChanged;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(12, 267);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(173, 15);
            lblDataVencimento.TabIndex = 15;
            lblDataVencimento.Text = "Informar a data de vencimento:";
            lblDataVencimento.TextAlign = ContentAlignment.TopCenter;
            lblDataVencimento.Click += lblDataVencimento_Click;
            // 
            // txtDataVencimento
            // 
            txtDataVencimento.BackColor = SystemColors.MenuBar;
            txtDataVencimento.Location = new Point(12, 285);
            txtDataVencimento.Name = "txtDataVencimento";
            txtDataVencimento.Size = new Size(359, 23);
            txtDataVencimento.TabIndex = 14;
            txtDataVencimento.TextChanged += txtDataVencimento_TextChanged;
            // 
            // lblValorOriginal
            // 
            lblValorOriginal.AutoSize = true;
            lblValorOriginal.Location = new Point(12, 322);
            lblValorOriginal.Name = "lblValorOriginal";
            lblValorOriginal.Size = new Size(247, 15);
            lblValorOriginal.TabIndex = 17;
            lblValorOriginal.Text = "Informar o valor original do boleto (em reais):";
            lblValorOriginal.TextAlign = ContentAlignment.TopRight;
            lblValorOriginal.Click += lblValorOriginal_Click;
            // 
            // txtValorOriginal
            // 
            txtValorOriginal.BackColor = SystemColors.MenuBar;
            txtValorOriginal.Location = new Point(12, 340);
            txtValorOriginal.Name = "txtValorOriginal";
            txtValorOriginal.Size = new Size(359, 23);
            txtValorOriginal.TabIndex = 16;
            txtValorOriginal.TextChanged += txtValorOriginal_TextChanged;
            // 
            // lblCodigoAceite
            // 
            lblCodigoAceite.AutoSize = true;
            lblCodigoAceite.Location = new Point(12, 379);
            lblCodigoAceite.Name = "lblCodigoAceite";
            lblCodigoAceite.Size = new Size(193, 15);
            lblCodigoAceite.TabIndex = 19;
            lblCodigoAceite.Text = "Informar o valor de aceite (A ou N):";
            lblCodigoAceite.TextAlign = ContentAlignment.TopRight;
            lblCodigoAceite.Click += lblCodigoAceite_Click;
            // 
            // txtCodigoAceite
            // 
            txtCodigoAceite.BackColor = SystemColors.MenuBar;
            txtCodigoAceite.Location = new Point(12, 397);
            txtCodigoAceite.Name = "txtCodigoAceite";
            txtCodigoAceite.Size = new Size(359, 23);
            txtCodigoAceite.TabIndex = 18;
            txtCodigoAceite.TextChanged += txtCodigoAceite_TextChanged;
            // 
            // lblTipoTitulo
            // 
            lblTipoTitulo.AutoSize = true;
            lblTipoTitulo.Location = new Point(12, 437);
            lblTipoTitulo.Name = "lblTipoTitulo";
            lblTipoTitulo.Size = new Size(228, 15);
            lblTipoTitulo.TabIndex = 21;
            lblTipoTitulo.Text = "Informar o código do boleto de cobrança:";
            lblTipoTitulo.TextAlign = ContentAlignment.TopRight;
            lblTipoTitulo.Click += lblTipoTitulo_Click;
            // 
            // txtTipoTitulo
            // 
            txtTipoTitulo.BackColor = SystemColors.MenuBar;
            txtTipoTitulo.Location = new Point(12, 455);
            txtTipoTitulo.Name = "txtTipoTitulo";
            txtTipoTitulo.Size = new Size(359, 23);
            txtTipoTitulo.TabIndex = 20;
            // 
            // lblDescricaoTipoTitulo
            // 
            lblDescricaoTipoTitulo.AutoSize = true;
            lblDescricaoTipoTitulo.Location = new Point(419, 4);
            lblDescricaoTipoTitulo.Name = "lblDescricaoTipoTitulo";
            lblDescricaoTipoTitulo.Size = new Size(391, 15);
            lblDescricaoTipoTitulo.TabIndex = 23;
            lblDescricaoTipoTitulo.Text = "Informar a codigo de identificação de autorização do pagamento parcial:";
            lblDescricaoTipoTitulo.TextAlign = ContentAlignment.TopRight;
            lblDescricaoTipoTitulo.Click += lblDescricaoTipoTitulo_Click;
            // 
            // txtDescricaoTipoTitulo
            // 
            txtDescricaoTipoTitulo.BackColor = SystemColors.MenuBar;
            txtDescricaoTipoTitulo.Location = new Point(419, 22);
            txtDescricaoTipoTitulo.Name = "txtDescricaoTipoTitulo";
            txtDescricaoTipoTitulo.Size = new Size(359, 23);
            txtDescricaoTipoTitulo.TabIndex = 22;
            // 
            // lblIndicadorRecebimentoParcial
            // 
            lblIndicadorRecebimentoParcial.AutoSize = true;
            lblIndicadorRecebimentoParcial.Location = new Point(419, 61);
            lblIndicadorRecebimentoParcial.Name = "lblIndicadorRecebimentoParcial";
            lblIndicadorRecebimentoParcial.Size = new Size(405, 15);
            lblIndicadorRecebimentoParcial.TabIndex = 25;
            lblIndicadorRecebimentoParcial.Text = "Informar o indicador de identificação de autorização do pagamento parcial:";
            lblIndicadorRecebimentoParcial.TextAlign = ContentAlignment.TopRight;
            lblIndicadorRecebimentoParcial.Click += lblIndicadorRecebimentoParcial_Click;
            // 
            // txtIndicadorRecebimentoParcial
            // 
            txtIndicadorRecebimentoParcial.BackColor = SystemColors.MenuBar;
            txtIndicadorRecebimentoParcial.Location = new Point(419, 79);
            txtIndicadorRecebimentoParcial.Name = "txtIndicadorRecebimentoParcial";
            txtIndicadorRecebimentoParcial.Size = new Size(359, 23);
            txtIndicadorRecebimentoParcial.TabIndex = 24;
            // 
            // lblNumeroBeneficiario
            // 
            lblNumeroBeneficiario.AutoSize = true;
            lblNumeroBeneficiario.Location = new Point(419, 113);
            lblNumeroBeneficiario.Name = "lblNumeroBeneficiario";
            lblNumeroBeneficiario.Size = new Size(193, 15);
            lblNumeroBeneficiario.TabIndex = 27;
            lblNumeroBeneficiario.Text = "Informar o número do beneficiario:";
            lblNumeroBeneficiario.TextAlign = ContentAlignment.TopRight;
            lblNumeroBeneficiario.Click += lblNumeroBeneficiario_Click;
            // 
            // txtNumeroBeneficiario
            // 
            txtNumeroBeneficiario.BackColor = SystemColors.MenuBar;
            txtNumeroBeneficiario.Location = new Point(419, 131);
            txtNumeroBeneficiario.Name = "txtNumeroBeneficiario";
            txtNumeroBeneficiario.Size = new Size(359, 23);
            txtNumeroBeneficiario.TabIndex = 26;
            // 
            // lblNumeroBoleto
            // 
            lblNumeroBoleto.AutoSize = true;
            lblNumeroBoleto.Location = new Point(419, 168);
            lblNumeroBoleto.Name = "lblNumeroBoleto";
            lblNumeroBoleto.Size = new Size(165, 15);
            lblNumeroBoleto.TabIndex = 29;
            lblNumeroBoleto.Text = "Informar o número do boleto:";
            lblNumeroBoleto.TextAlign = ContentAlignment.TopRight;
            lblNumeroBoleto.Click += lblNumeroBoleto_Click;
            // 
            // txtNumeroBoleto
            // 
            txtNumeroBoleto.BackColor = SystemColors.MenuBar;
            txtNumeroBoleto.Location = new Point(419, 186);
            txtNumeroBoleto.Name = "txtNumeroBoleto";
            txtNumeroBoleto.Size = new Size(359, 23);
            txtNumeroBoleto.TabIndex = 28;
            // 
            // lblPagador
            // 
            lblPagador.AutoSize = true;
            lblPagador.Location = new Point(419, 222);
            lblPagador.Name = "lblPagador";
            lblPagador.Size = new Size(175, 15);
            lblPagador.TabIndex = 31;
            lblPagador.Text = "Informar o número do pagador:";
            lblPagador.TextAlign = ContentAlignment.TopRight;
            lblPagador.Click += lblPagador_Click;
            // 
            // txtPagador
            // 
            txtPagador.BackColor = SystemColors.MenuBar;
            txtPagador.Location = new Point(419, 240);
            txtPagador.Name = "txtPagador";
            txtPagador.Size = new Size(359, 23);
            txtPagador.TabIndex = 30;
            // 
            // lblInscricao
            // 
            lblInscricao.AutoSize = true;
            lblInscricao.Location = new Point(419, 273);
            lblInscricao.Name = "lblInscricao";
            lblInscricao.Size = new Size(286, 15);
            lblInscricao.TabIndex = 33;
            lblInscricao.Text = "Informar a inscrição do pagador (1 - fisica/2-juridica)";
            lblInscricao.TextAlign = ContentAlignment.TopRight;
            lblInscricao.Click += lblInscricao_Click;
            // 
            // txtInscricao
            // 
            txtInscricao.BackColor = SystemColors.MenuBar;
            txtInscricao.Location = new Point(419, 291);
            txtInscricao.Name = "txtInscricao";
            txtInscricao.Size = new Size(359, 23);
            txtInscricao.TabIndex = 32;
            // 
            // txtJsonResponse
            // 
            txtJsonResponse.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJsonResponse.Location = new Point(419, 340);
            txtJsonResponse.Multiline = true;
            txtJsonResponse.Name = "txtJsonResponse";
            txtJsonResponse.ScrollBars = ScrollBars.Vertical;
            txtJsonResponse.Size = new Size(359, 191);
            txtJsonResponse.TabIndex = 34;
            txtJsonResponse.WordWrap = false;
            txtJsonResponse.TextChanged += txtJsonResponse_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 641);
            Controls.Add(txtJsonResponse);
            Controls.Add(lblInscricao);
            Controls.Add(txtInscricao);
            Controls.Add(lblPagador);
            Controls.Add(txtPagador);
            Controls.Add(lblNumeroBoleto);
            Controls.Add(txtNumeroBoleto);
            Controls.Add(lblNumeroBeneficiario);
            Controls.Add(txtNumeroBeneficiario);
            Controls.Add(lblIndicadorRecebimentoParcial);
            Controls.Add(txtIndicadorRecebimentoParcial);
            Controls.Add(lblDescricaoTipoTitulo);
            Controls.Add(txtDescricaoTipoTitulo);
            Controls.Add(lblTipoTitulo);
            Controls.Add(txtTipoTitulo);
            Controls.Add(lblCodigoAceite);
            Controls.Add(txtCodigoAceite);
            Controls.Add(lblValorOriginal);
            Controls.Add(txtValorOriginal);
            Controls.Add(lblDataVencimento);
            Controls.Add(txtDataVencimento);
            Controls.Add(lblDataEmissao);
            Controls.Add(txtDataEmissao);
            Controls.Add(lblCodigoModalidade);
            Controls.Add(txtCodigoModalidade);
            Controls.Add(lblVariacaoCarteira);
            Controls.Add(txtVariacaoCarteira);
            Controls.Add(lblToken);
            Controls.Add(txtToken);
            Controls.Add(lblCarteira);
            Controls.Add(txtCobranca);
            Controls.Add(lblConvenio);
            Controls.Add(textBox1);
            Controls.Add(btnEmitirBoleto);
            Controls.Add(btnObterToken);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.DimGray;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObterToken;
        private Button btnEmitirBoleto;
        private TextBox textBox1;
        private Label lblConvenio;
        private Label lblCarteira;
        private TextBox txtCobranca;
        private Label lblToken;
        private TextBox txtToken;
        private Label lblVariacaoCarteira;
        private TextBox txtVariacaoCarteira;
        private Label lblCodigoModalidade;
        private TextBox txtCodigoModalidade;
        private Label lblDataEmissao;
        private TextBox txtDataEmissao;
        private Label lblDataVencimento;
        private TextBox txtDataVencimento;
        private Label lblValorOriginal;
        private TextBox txtValorOriginal;
        private Label lblCodigoAceite;
        private TextBox txtCodigoAceite;
        private Label lblTipoTitulo;
        private TextBox txtTipoTitulo;
        private Label lblDescricaoTipoTitulo;
        private TextBox txtDescricaoTipoTitulo;
        private Label lblIndicadorRecebimentoParcial;
        private TextBox txtIndicadorRecebimentoParcial;
        private Label lblNumeroBeneficiario;
        private TextBox txtNumeroBeneficiario;
        private Label lblNumeroBoleto;
        private TextBox txtNumeroBoleto;
        private Label lblPagador;
        private TextBox txtPagador;
        private Label lblInscricao;
        private TextBox txtInscricao;
        private TextBox txtJsonResponse;
    }
}
