using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometragem_de_prova
{
    public partial class Form1 : Form
    {
        Timer cronometro;
        int hora, minuto, segundo, decima;
        bool acao = false;
        int posicao;
        List<string> CONCORRENTES;

        // =====================================================================
        public Form1()
        {
            InitializeComponent();
            cronometro = new Timer();
            cronometro.Interval = 100;
            cronometro.Tick += Cronometro_Tick;
            cronometro.Enabled = false;

            //Concorrentes
            CONCORRENTES = new List<string>()
            {
                "Joao", "Carlos", "Antonio","Mario", "Fernando", "Savio", "Douglas","José","Valter","Marcos","Rafael","Pedro"
            };

        }

        private void cmd_stop_Click(object sender, EventArgs e)
        {
            cronometro.Enabled = false;
        }

      

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            //Executado sempre que o intervalo é alcançado

            decima++;
            if (decima == 10)
            {
                decima = 0;
                segundo++;
                if (segundo == 60)
                {
                    segundo = 0;
                    minuto++;
                    if(minuto == 60)
                    {
                        minuto = 0;
                        hora++;
                    }
                }
            }

            label_cronometro.Text = hora.ToString("00") +
                                        ":" + minuto.ToString("00") +
                                        ":" + segundo.ToString("00") +
                                        "." + decima.ToString();
        }

        private void cmd_start_Click(object sender, EventArgs e)
        {
            //Iniciar a prova
            posicao = 1;
            lista_concorrentes.Items.Clear();
            lista_classificacao.Items.Clear();
            lista_concorrentes.Items.AddRange(CONCORRENTES.ToArray());

            hora = minuto = segundo = decima = 0;
            acao = true;

            label_cronometro.Text = hora.ToString("00") +
                                        ":" + minuto.ToString("00") +
                                        ":" + segundo.ToString("00") +
                                        "." + decima.ToString();
            cronometro.Enabled = true;

        }


        // ====================================================================================================
        private void lista_concorrentes_DoubleClick(object sender, EventArgs e)
        {
            if (!acao) return;
            if (lista_concorrentes.SelectedIndex == -1) return;

            lista_classificacao.Items.Add(
                posicao.ToString() + "° - " +
                lista_concorrentes.Text + " " +
                "[" +
                hora.ToString("00") + ":" + minuto.ToString("00") + ":" + segundo.ToString("00") + "." + decima.ToString() +
            "]"
            );

            lista_concorrentes.Items.RemoveAt(lista_concorrentes.SelectedIndex);
            posicao++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
