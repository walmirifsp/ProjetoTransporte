using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTransporte
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();        
        public Form1()
        {            
            InitializeComponent();
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label11.Text = "";
        }

        //Adiciona Veiculo
        private void button1_Click(object sender, EventArgs e)
        {
            controller.addVeiculo(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            MessageBox.Show("Veículo adicionado");
            atualiza();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.addPassageiro();
            MessageBox.Show("Passageiro adicionado");
            controller.viagem(false);
            atualiza();
        }

        public void atualiza()
        {
            dataGridView1.DataSource = controller.Veiculos.Lveiculos.ToList();
            dataGridView2.DataSource = controller.Passageiros.LsPassageiros.ToList();
            dataGridView3.DataSource = controller.Viagens.LViagens.ToList();

            label1.Text = "Motorista : "+controller.Veiculo.Nome;
            label2.Text = "Placa : "+controller.Veiculo.Placa;
            label3.Text = "Lotação : "+controller.Veiculo.Lotacao.ToString();
            label4.Text = "Assentos restantes : "+(controller.Veiculo.Lotacao - controller.Passageiros.LsPassageiros.Count()).ToString();
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = controller.returnNome(textBox4.Text);
            label9.Text = controller.returnNumViagens(textBox4.Text);
            label10.Text = controller.returnLucro(textBox4.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.viagem(true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(controller.Viagens.LViagens.Count()!=0)
            {
                DateTime proxViagem = controller.Viagens.LViagens.Last().Data.AddMinutes(30);
                label11.Text = "Hora para a próxima viagem : " + proxViagem.ToShortTimeString();
            }            
        }
    }
}
