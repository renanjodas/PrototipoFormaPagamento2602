namespace Forma_Pagamento
{
	partial class FormPagamento
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
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblValorDaCompra = new System.Windows.Forms.Label();
			this.lblValorAPagar = new System.Windows.Forms.Label();
			this.gbxPagamento = new System.Windows.Forms.GroupBox();
			this.rbnAVista = new System.Windows.Forms.RadioButton();
			this.rbnAPrazo = new System.Windows.Forms.RadioButton();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtValorCompra = new System.Windows.Forms.TextBox();
			this.txtValorPagar = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnGerarTxt = new System.Windows.Forms.Button();
			this.gbxPagamento.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(31, 30);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(39, 13);
			this.lblCliente.TabIndex = 0;
			this.lblCliente.Text = "Cliente";
			// 
			// lblValorDaCompra
			// 
			this.lblValorDaCompra.AutoSize = true;
			this.lblValorDaCompra.Location = new System.Drawing.Point(31, 159);
			this.lblValorDaCompra.Name = "lblValorDaCompra";
			this.lblValorDaCompra.Size = new System.Drawing.Size(84, 13);
			this.lblValorDaCompra.TabIndex = 1;
			this.lblValorDaCompra.Text = "Valor da compra";
			// 
			// lblValorAPagar
			// 
			this.lblValorAPagar.AutoSize = true;
			this.lblValorAPagar.Location = new System.Drawing.Point(31, 204);
			this.lblValorAPagar.Name = "lblValorAPagar";
			this.lblValorAPagar.Size = new System.Drawing.Size(70, 13);
			this.lblValorAPagar.TabIndex = 2;
			this.lblValorAPagar.Text = "Valor à pagar";
			// 
			// gbxPagamento
			// 
			this.gbxPagamento.Controls.Add(this.rbnAPrazo);
			this.gbxPagamento.Controls.Add(this.rbnAVista);
			this.gbxPagamento.Location = new System.Drawing.Point(34, 69);
			this.gbxPagamento.Name = "gbxPagamento";
			this.gbxPagamento.Size = new System.Drawing.Size(217, 67);
			this.gbxPagamento.TabIndex = 3;
			this.gbxPagamento.TabStop = false;
			this.gbxPagamento.Text = "Pagamento";
			// 
			// rbnAVista
			// 
			this.rbnAVista.AutoSize = true;
			this.rbnAVista.Location = new System.Drawing.Point(18, 31);
			this.rbnAVista.Name = "rbnAVista";
			this.rbnAVista.Size = new System.Drawing.Size(57, 17);
			this.rbnAVista.TabIndex = 0;
			this.rbnAVista.TabStop = true;
			this.rbnAVista.Text = "à Vista";
			this.rbnAVista.UseVisualStyleBackColor = true;
			// 
			// rbnAPrazo
			// 
			this.rbnAPrazo.AutoSize = true;
			this.rbnAPrazo.Location = new System.Drawing.Point(110, 31);
			this.rbnAPrazo.Name = "rbnAPrazo";
			this.rbnAPrazo.Size = new System.Drawing.Size(61, 17);
			this.rbnAPrazo.TabIndex = 1;
			this.rbnAPrazo.TabStop = true;
			this.rbnAPrazo.Text = "à Prazo";
			this.rbnAPrazo.UseVisualStyleBackColor = true;
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(76, 27);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(175, 20);
			this.txtCliente.TabIndex = 4;
			// 
			// txtValorCompra
			// 
			this.txtValorCompra.Location = new System.Drawing.Point(121, 156);
			this.txtValorCompra.Name = "txtValorCompra";
			this.txtValorCompra.Size = new System.Drawing.Size(130, 20);
			this.txtValorCompra.TabIndex = 5;
			// 
			// txtValorPagar
			// 
			this.txtValorPagar.BackColor = System.Drawing.Color.Yellow;
			this.txtValorPagar.Location = new System.Drawing.Point(121, 201);
			this.txtValorPagar.Name = "txtValorPagar";
			this.txtValorPagar.ReadOnly = true;
			this.txtValorPagar.Size = new System.Drawing.Size(130, 20);
			this.txtValorPagar.TabIndex = 6;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(98, 244);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(107, 23);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnGerarTxt
			// 
			this.btnGerarTxt.Location = new System.Drawing.Point(98, 285);
			this.btnGerarTxt.Name = "btnGerarTxt";
			this.btnGerarTxt.Size = new System.Drawing.Size(107, 23);
			this.btnGerarTxt.TabIndex = 8;
			this.btnGerarTxt.Text = "Gerar txt";
			this.btnGerarTxt.UseVisualStyleBackColor = true;
			this.btnGerarTxt.Click += new System.EventHandler(this.btnGerarTxt_Click);
			// 
			// FormPagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 320);
			this.Controls.Add(this.btnGerarTxt);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtValorPagar);
			this.Controls.Add(this.txtValorCompra);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.gbxPagamento);
			this.Controls.Add(this.lblValorAPagar);
			this.Controls.Add(this.lblValorDaCompra);
			this.Controls.Add(this.lblCliente);
			this.Name = "FormPagamento";
			this.Text = "Forma de Pagamento";
			this.gbxPagamento.ResumeLayout(false);
			this.gbxPagamento.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblValorDaCompra;
		private System.Windows.Forms.Label lblValorAPagar;
		private System.Windows.Forms.GroupBox gbxPagamento;
		private System.Windows.Forms.RadioButton rbnAPrazo;
		private System.Windows.Forms.RadioButton rbnAVista;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.TextBox txtValorCompra;
		private System.Windows.Forms.TextBox txtValorPagar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnGerarTxt;
	}
}