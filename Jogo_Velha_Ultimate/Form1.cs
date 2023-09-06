using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Jogo_Velha_Ultimate
{
    public partial class Form1 : Form
    {
        String vezJogador = "X";
        int numJogadas = 0;
        String nomeBotao;
        Panel nomeLabel;
        String[] resultCampo = new string[10];
        String winner = "";
        int numJogosFeitos = 0;
        bool acabouJogo = false;
        

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < resultCampo.Length; i++)
            {
                resultCampo[i] = "";
            }
        }

        //SETOR CÁLCULO DO JOGO (vez do jogador, quantas jogadas)
        public void TrocaJogada()
        {
            if (vezJogador == "X") vezJogador = "O";
            else vezJogador = "X";
            numJogadas++;
            Tvalorcount.Text = Convert.ToString(numJogadas);
            Tvezjogador.Text = vezJogador;
        }

        public void FuncaoBotao(object sender, EventArgs e)
        {
            //Identifica qual o botão que cliquei.
            nomeBotao = ((Button)sender).Name;

            //Identifica qual a label que esse botão está.
            Button nomeBotao2 = (Button)sender;
            nomeBotao2.Enabled = false;
            nomeLabel = ((Panel)nomeBotao2.Parent);
            
            //Adiciona o símbolo da vez no botão
            ((Button)sender).Text = vezJogador;

            nomeLabel.BackColor = Color.LightPink;
            TrocaJogada();
            CheckLabelWinner(nomeLabel.Name);
            if(acabouJogo == true) { MessageBox.Show("O jogo acabou. O vencedor foi: " + winner.ToUpper()); }
            else if(numJogosFeitos == 9) { MessageBox.Show(" MATCH DRAW !!!"); }
            else LiberaCampo(sender);
        }

        private void LiberaCampo(object sender)
        {
            if ((nomeBotao == "Ba1c1") || (nomeBotao == "Ba1c2") || (nomeBotao == "Ba1c3") || (nomeBotao == "Ba1c4") || (nomeBotao == "Ba1c5") || (nomeBotao == "Ba1c6") || (nomeBotao == "Ba1c7") || (nomeBotao == "Ba1c8") || (nomeBotao == "Ba1c9"))
            {
                BloqueiaCampos();
                if (resultCampo[1] == "") { Campo1.Enabled = true; Campo1.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
                
            }
            else if ((nomeBotao == "Ba2c1") || (nomeBotao == "Ba2c2") || (nomeBotao == "Ba2c3") || (nomeBotao == "Ba2c4") || (nomeBotao == "Ba2c5") || (nomeBotao == "Ba2c6") || (nomeBotao == "Ba2c7") || (nomeBotao == "Ba2c8") || (nomeBotao == "Ba2c9"))
            {
                BloqueiaCampos();
                if (resultCampo[2] == "") { Campo2.Enabled = true; Campo2.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Ba3c1") || (nomeBotao == "Ba3c2") || (nomeBotao == "Ba3c3") || (nomeBotao == "Ba3c4") || (nomeBotao == "Ba3c5") || (nomeBotao == "Ba3c6") || (nomeBotao == "Ba3c7") || (nomeBotao == "Ba3c8") || (nomeBotao == "Ba3c9"))
            {
                BloqueiaCampos();
                if (resultCampo[3] == "") { Campo3.Enabled = true; Campo3.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bb1c1") || (nomeBotao == "Bb1c2") || (nomeBotao == "Bb1c3") || (nomeBotao == "Bb1c4") || (nomeBotao == "Bb1c5") || (nomeBotao == "Bb1c6") || (nomeBotao == "Bb1c7") || (nomeBotao == "Bb1c8") || (nomeBotao == "Bb1c9"))
            {
                BloqueiaCampos();
                if (resultCampo[4] == "") { Campo4.Enabled = true; Campo4.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bb2c1") || (nomeBotao == "Bb2c2") || (nomeBotao == "Bb2c3") || (nomeBotao == "Bb2c4") || (nomeBotao == "Bb2c5") || (nomeBotao == "Bb2c6") || (nomeBotao == "Bb2c7") || (nomeBotao == "Bb2c8") || (nomeBotao == "Bb2c9"))
            {
                BloqueiaCampos();
                if (resultCampo[5] == "") { Campo5.Enabled = true; Campo5.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bb3c1") || (nomeBotao == "Bb3c2") || (nomeBotao == "Bb3c3") || (nomeBotao == "Bb3c4") || (nomeBotao == "Bb3c5") || (nomeBotao == "Bb3c6") || (nomeBotao == "Bb3c7") || (nomeBotao == "Bb3c8") || (nomeBotao == "Bb3c9"))
            {
                BloqueiaCampos();
                if (resultCampo[6] == "") { Campo6.Enabled = true; Campo6.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bc1c1") || (nomeBotao == "Bc1c2") || (nomeBotao == "Bc1c3") || (nomeBotao == "Bc1c4") || (nomeBotao == "Bc1c5") || (nomeBotao == "Bc1c6") || (nomeBotao == "Bc1c7") || (nomeBotao == "Bc1c8") || (nomeBotao == "Bc1c9"))
            {
                BloqueiaCampos();
                if (resultCampo[7] == "") { Campo7.Enabled = true; Campo7.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bc2c1") || (nomeBotao == "Bc2c2") || (nomeBotao == "Bc2c3") || (nomeBotao == "Bc2c4") || (nomeBotao == "Bc2c5") || (nomeBotao == "Bc2c6") || (nomeBotao == "Bc2c7") || (nomeBotao == "Bc2c8") || (nomeBotao == "Bc2c9"))
            {
                BloqueiaCampos();
                if (resultCampo[8] == "") { Campo8.Enabled = true; Campo8.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }
            else if ((nomeBotao == "Bc3c1") || (nomeBotao == "Bc3c2") || (nomeBotao == "Bc3c3") || (nomeBotao == "Bc3c4") || (nomeBotao == "Bc3c5") || (nomeBotao == "Bc3c6") || (nomeBotao == "Bc3c7") || (nomeBotao == "Bc3c8") || (nomeBotao == "Bc3c9"))
            {
                BloqueiaCampos();
                if (resultCampo[9] == "") { Campo9.Enabled = true; Campo9.BackColor = Color.LightGreen; }
                else VerificaCampoJogavel();
            }

        }

        //FUNÇÃO PARA BLOQUEAR TODAS AS LABELS
        private void BloqueiaCampos()
        {
            Campo1.Enabled = false; Campo1.BackColor = Color.LightPink;
            Campo2.Enabled = false; Campo2.BackColor = Color.LightPink;
            Campo3.Enabled = false; Campo3.BackColor = Color.LightPink;
            Campo4.Enabled = false; Campo4.BackColor = Color.LightPink;
            Campo5.Enabled = false; Campo5.BackColor = Color.LightPink;
            Campo6.Enabled = false; Campo6.BackColor = Color.LightPink;
            Campo7.Enabled = false; Campo7.BackColor = Color.LightPink;
            Campo8.Enabled = false; Campo8.BackColor = Color.LightPink;
            Campo9.Enabled = false; Campo9.BackColor = Color.LightPink;
        }

        //FUNÇÃO PARA LIBERAR AS LABELS AINDA JOGÁVEIS
        private void VerificaCampoJogavel()
        {
            for (int i = 1; i < 10; i++)
            {
                if (resultCampo[i] == "") 
                { 
                    if (i == 1) { Campo1.Enabled = true; Campo1.BackColor = Color.LightGreen; }
                    else if (i == 2) { Campo2.Enabled = true; Campo2.BackColor = Color.LightGreen; }
                    else if (i == 3) { Campo3.Enabled = true; Campo3.BackColor = Color.LightGreen; }
                    else if (i == 4) { Campo4.Enabled = true; Campo4.BackColor = Color.LightGreen; }
                    else if (i == 5) { Campo5.Enabled = true; Campo5.BackColor = Color.LightGreen; }
                    else if (i == 6) { Campo6.Enabled = true; Campo6.BackColor = Color.LightGreen; }
                    else if (i == 7) { Campo7.Enabled = true; Campo7.BackColor = Color.LightGreen; }
                    else if (i == 8) { Campo8.Enabled = true; Campo8.BackColor = Color.LightGreen; }
                    else if (i == 9) { Campo9.Enabled = true; Campo9.BackColor = Color.LightGreen; }
                }
            }
        }


        private void CheckLabelWinner(String Campo)
        {
            switch (Campo)
            {
                case "Campo1":
                    checkwinner(Ba1c1,Ba2c1,Ba3c1,Bb1c1,Bb2c1,Bb3c1,Bc1c1,Bc2c1,Bc3c1);
                    break;
                case "Campo2":
                    checkwinner(Ba1c2, Ba2c2, Ba3c2, Bb1c2, Bb2c2, Bb3c2, Bc1c2, Bc2c2, Bc3c2);
                    break;
                case "Campo3":
                    checkwinner(Ba1c3, Ba2c3, Ba3c3, Bb1c3, Bb2c3, Bb3c3, Bc1c3, Bc2c3, Bc3c3);
                    break;
                case "Campo4":
                    checkwinner(Ba1c4, Ba2c4, Ba3c4, Bb1c4, Bb2c4, Bb3c4, Bc1c4, Bc2c4, Bc3c4);
                    break;
                case "Campo5":
                    checkwinner(Ba1c5, Ba2c5, Ba3c5, Bb1c5, Bb2c5, Bb3c5, Bc1c5, Bc2c5, Bc3c5);
                    break;
                case "Campo6":
                    checkwinner(Ba1c6, Ba2c6, Ba3c6, Bb1c6, Bb2c6, Bb3c6, Bc1c6, Bc2c6, Bc3c6);
                    break;
                case "Campo7":
                    checkwinner(Ba1c7, Ba2c7, Ba3c7, Bb1c7, Bb2c7, Bb3c7, Bc1c7, Bc2c7, Bc3c7);
                    break;
                case "Campo8":
                    checkwinner(Ba1c8, Ba2c8, Ba3c8, Bb1c8, Bb2c8, Bb3c8, Bc1c8, Bc2c8, Bc3c8);
                    break;
                case "Campo9":
                    checkwinner(Ba1c9, Ba2c9, Ba3c9, Bb1c9, Bb2c9, Bb3c9, Bc1c9, Bc2c9, Bc3c9);
                    break;
            }
        }

        //VERIFICAÇÃO SE CAMPO ESTÁ COMPLETO
        private void checkwinner(Button a1, Button a2, Button a3, Button b1, Button b2, Button b3, Button c1, Button c2, Button c3)
        {
            //horizontal check  
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled)) organizarLabel();
            else if((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled)) organizarLabel();
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled)) organizarLabel();

            //vertical check
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled)) organizarLabel();
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled)) organizarLabel();
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled)) organizarLabel();

            //diagonal check
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled)) organizarLabel();
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled)) organizarLabel();
            else if (a1.Text != "" && a2.Text != "" && a3.Text != "" && b1.Text != "" && b2.Text != "" && b3.Text != "" && c1.Text != "" && c2.Text != "" && c3.Text != "") { resultadoVelha(); }
        }

        //FUNÇÃO PARA TORNAR O JOGO MENOR VELHA
        public void resultadoVelha()
        {
            nomeLabel.BackColor = Color.LightSlateGray;
            nomeLabel.Enabled = false;
            winner = "f";
            updateArray(winner, nomeLabel.Name);
            numJogosFeitos++;
        }

        //FUNÇÃO PARA FINALIZAR CAMPO
        private void organizarLabel()
        {
            nomeLabel.BackColor = Color.LightSlateGray;
            nomeLabel.Enabled = false;
            if(vezJogador == "X") { nomeLabel.BackgroundImage = Properties.Resources.letra_o; winner = "o"; }
            else { nomeLabel.BackgroundImage = Properties.Resources.x_tic_tac; winner = "x"; }
            updateArray(winner, nomeLabel.Name);

            numJogosFeitos++;
            for (int i = 1; i <= 9; i += 3)
            {
                if (resultCampo[i] == resultCampo[i + 1] && resultCampo[i + 1] == resultCampo[i + 2] && resultCampo[i] != "") {acabouJogo = true;}
            }
            for (int i = 1; i <= 3; i ++)
            {
                if (resultCampo[i] == resultCampo[i + 3] && resultCampo[i + 3] == resultCampo[i + 6] && resultCampo[i] != "") {acabouJogo = true;}
            }
            if (resultCampo[1] == resultCampo[5] && resultCampo[5] == resultCampo[9] && resultCampo[1] != "") { acabouJogo = true; }
            if (resultCampo[7] == resultCampo[5] && resultCampo[5] == resultCampo[3] && resultCampo[7] != "") { acabouJogo = true; }
        }


        public void updateArray(string winner, string nomeLabel)
        {
            switch (nomeLabel)
            {
                case "Campo1":
                    resultCampo[1] = winner;
                    break;
                case "Campo2":
                    resultCampo[2] = winner;
                    break;
                case "Campo3":
                    resultCampo[3] = winner;
                    break;
                case "Campo4":
                    resultCampo[4] = winner;
                    break;
                case "Campo5":
                    resultCampo[5] = winner;
                    break;
                case "Campo6":
                    resultCampo[6] = winner;
                    break;
                case "Campo7":
                    resultCampo[7] = winner;
                    break;
                case "Campo8":
                    resultCampo[8] = winner;
                    break;
                case "Campo9":
                    resultCampo[9] = winner;
                    break;
            }
        } 
    }
}
