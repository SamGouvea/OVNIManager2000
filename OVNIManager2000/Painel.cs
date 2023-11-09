using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIManager2000
{
    public partial class Painel : Form
    {
        // Objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDados();
            //Popular o CMB: 
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        // Método para atualizar os dados:
        public void AtualizarDados()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
            btnLigar.Enabled = !ovni.Situacao;
            btnDesligar.Enabled = ovni.Situacao;
            // Habilitar/desabilitar botões de acordo com a situação:
            btnAbduzir.Enabled = ovni.Situacao;
            btnDesabduzir.Enabled = ovni.Situacao;
            btnMudarPlaneta.Enabled = ovni.Situacao;
            cmbPlanetas.Enabled = ovni.Situacao;
            btnOrigem.Enabled = ovni.Situacao;
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Limite máximo de tripulantes atingido!");
            }
            AtualizarDados();

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar() == false)
            {
                MessageBox.Show("A nave já está ligada!");
            }
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {

            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A nave já está desligada!");
            }
            AtualizarDados();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Situacao)
            {
                if (ovni.Abduzir() == false)
                {
                    MessageBox.Show("Abduziu d++!");
                }
                AtualizarDados();
            }
            else
            {
                MessageBox.Show("A Nave está desligada!");
            }
            AtualizarDados();
        }

        private void btnDesabduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir() == false)
            {
                MessageBox.Show("Desabduziu de menos!");
            }
            AtualizarDados();
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem() == false)
            {
                MessageBox.Show("Você já está no planeta de origem!");
            }
            AtualizarDados();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text) == false)
            {
                MessageBox.Show("Não foi possivel mudar de planeta!");
            }
            AtualizarDados();
        }
    }
}
