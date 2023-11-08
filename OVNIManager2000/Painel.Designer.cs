namespace OVNIManager2000
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btbAddTripulante = new System.Windows.Forms.Button();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(12, 12);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(210, 126);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 23);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(68, 19);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 47);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(78, 19);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 74);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(84, 19);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(12, 144);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(210, 31);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(12, 181);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(210, 29);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btbAddTripulante
            // 
            this.btbAddTripulante.Location = new System.Drawing.Point(228, 24);
            this.btbAddTripulante.Name = "btbAddTripulante";
            this.btbAddTripulante.Size = new System.Drawing.Size(210, 24);
            this.btbAddTripulante.TabIndex = 3;
            this.btbAddTripulante.Text = "Adicionar Tripulante";
            this.btbAddTripulante.UseVisualStyleBackColor = true;
            this.btbAddTripulante.Click += new System.EventHandler(this.btbAddTripulante_Click);
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.Location = new System.Drawing.Point(228, 54);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(210, 24);
            this.btnRemoverTripulante.TabIndex = 4;
            this.btnRemoverTripulante.Text = "Remover Tripulante ";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Location = new System.Drawing.Point(228, 84);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(210, 24);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Location = new System.Drawing.Point(228, 114);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(210, 24);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnOrigem
            // 
            this.btnOrigem.Location = new System.Drawing.Point(228, 144);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(210, 24);
            this.btnOrigem.TabIndex = 7;
            this.btnOrigem.Text = "Retornar a Origem";
            this.btnOrigem.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(7, 102);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(62, 19);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(228, 174);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(107, 37);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(341, 171);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(97, 39);
            this.btnMudarPlaneta.TabIndex = 9;
            this.btnMudarPlaneta.Text = "Mudar";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 221);
            this.Controls.Add(this.btnMudarPlaneta);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnOrigem);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemoverTripulante);
            this.Controls.Add(this.btbAddTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Name = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btbAddTripulante;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnMudarPlaneta;
    }
}