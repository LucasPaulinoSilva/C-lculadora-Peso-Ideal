using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Calculadora_Peso_Ideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesoIDeal_Click(object sender, EventArgs e)
        {
            try 
            {   // Cria variavel de altura de ponto flutuante
                Double Altura = 0, PesoIdeal = 0;
                Altura = double.Parse(txtAltura.Text);

                // Caso seja selecionado o sexo feminino:
                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura - 44.7);
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + PesoIdeal.ToString() + " Kg",
                        "Cálculo Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Caso seja selecionado o sexo masculino:
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + PesoIdeal.ToString() + " Kg",
                        "Cálculo Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Caso não seja selecionado nenhum dos dois sexos:
                else
                {
                    MessageBox.Show("Escolha o sexo!", "Cálculo Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }

            // Caso qualquer outro critério não for inserido:
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados!", "Cálculo Peso Ideal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {   
            // Atribui ação de limpar campos ao botão "Limpar"
            txtNome.Clear();
            txtNome.Focus();
            txtAltura.Clear();
            cmbSexo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {   
            // Atribui ação de fechar ao botão "Sair"
            this.Close();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
                        