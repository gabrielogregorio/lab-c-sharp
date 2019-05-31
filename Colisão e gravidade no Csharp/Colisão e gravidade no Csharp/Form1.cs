using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colisão_e_gravidade_no_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* Gravidade e colisão no form do C#. Versão 1.2
        Autor: Gabriel Gregório da Silva
        E-mail: gabriel.gregorio.1@outlook.com
        Créditos: Não roube meus créditos hahahah

        Como Implementar? Cole esse código no formulário
        do seu game e siga as intruções abaixo
            _______________________________________________________
        |   COMO USAR O MÉTODO DA GRAVIDADE?                    |
        |   gravidade(caixa,chao);                              |
        |                                                       |
        |  Exemplo para fornecer a gravidade para o             |
        |  botão "caixa", Até tocar no Botão "chao":             |
        |  gravidade(caixa , chao);                             |
        |_______________________________________________________|
        _______________________________________________________
        |  COMO USAR O MÉTODO DE COLISÃO?                       |
        |  colisao(objeto_1, objeto_2);                         |
        |                                                       |
        |  Exemplo para verificar se o button1 toca no button2: |
        |  if ( colisao(button1 , button2) == "sim")            |
        |  {                                                    |
        |      // button1 tocou no button2, ou vice versa!      |
        |  };                                                   |
        |_______________________________________________________|
        */

        // *************** CALCULOS DE GRAVIDADE *************** \\
        private void gravidade(Button objeto, Button chao_referencia)
        {
            int x = var_global.tempo;    // Tempo decorrido!.
            int g = 10;                  // Gravidade relativa.
            int vi = 0;                  // Velocidade Inicial.
            int fator_redução = 300;     // Reduz a Intensidade da gravidade. (Padrão é 300, caso você mude, terá que atualizar alguns dados no método gravidade)

            /* Vamos chamar o método de colisão para verificar se
                o objeto que está sofrendo a ação da gravidade já
                tocou no 'chão'. Caso verdade, vamos 'parar' a gravidade*/
            if (colisao(objeto, chao_referencia) == "sim")
            {
                var_global.tempo = 1;    // O objeto já tocou no chão
            }
            else
            {
                // Queda no eixo Y
                int y = Convert.ToInt16((-(g * x ^ 2) / (2 * vi ^ 2)) / fator_redução);

                // Atualização da posição do objeto
                objeto.Location = new Point(objeto.Location.X, objeto.Location.Y - y);

                // Atualização da Variável Global
                var_global.tempo = var_global.tempo + 1;
            }
        }

        // *************** CALCULOS DE COLISÃO *************** \\
        public string colisao(Button objeto_1, Button objeto_2)
        {
            string colidiu = "nada"; // Retorna se houve uma colisão ou não
            Button c;                // Ajuda na inversão para multiplos testes
            int x = 1;               // Fazer os mesmos testes em elementos diferentes

            // Testar os dois lados
            while (x < 3)
            {
                if (objeto_1.Location.X < objeto_2.Location.X && objeto_1.Location.X + objeto_1.Size.Width > objeto_2.Location.X && objeto_1.Location.Y < objeto_2.Location.Y && objeto_1.Location.Y + objeto_1.Size.Height > objeto_2.Location.Y)
                {
                    colidiu = "sim";
                }
                // Inversão de botões
                c = objeto_1;
                objeto_1 = objeto_2;
                objeto_2 = c;

                // Andante pelo loop
                x = x + 1;
            }

            x = 1;
            // Testar os dois lados
            while (x < 3)
            {
                if (objeto_2.Location.X + objeto_2.Width < objeto_1.Location.X + objeto_1.Width && objeto_2.Location.X + objeto_2.Width > objeto_1.Location.X && objeto_2.Location.Y + objeto_2.Height < objeto_1.Location.Y + objeto_1.Height && objeto_2.Location.Y + objeto_2.Height > objeto_1.Location.Y)
                {
                    colidiu = "sim";
                }
                // Inversão de botões
                c = objeto_1;
                objeto_1 = objeto_2;
                objeto_2 = c;

                // Andante pelo loop
                x = x + 1;
            }

            x = 1;
            // Testar os dois lados
            while (x < 3)
            {
                if (objeto_2.Location.X + objeto_2.Width < objeto_1.Location.X + objeto_1.Width && objeto_2.Location.X + objeto_2.Width > objeto_1.Location.X && objeto_2.Location.Y < objeto_1.Location.Y + objeto_1.Height && objeto_2.Location.Y > objeto_1.Location.Y)
                {
                    colidiu = "sim";
                }
                // Inversão de botões
                c = objeto_1;
                objeto_1 = objeto_2;
                objeto_2 = c;

                // Andante pelo loop
                x = x + 1;
            }
            x = 1;

            // Testar os dois lados
            while (x < 3)
            {
                if (objeto_2.Location.X < objeto_1.Location.X + objeto_1.Width && objeto_2.Location.X > objeto_1.Location.X && objeto_2.Location.Y < objeto_1.Location.Y + objeto_1.Height && objeto_2.Location.Y > objeto_1.Location.Y)
                {
                    colidiu = "sim";
                }
                // Inversão de botões
                c = objeto_1;
                objeto_1 = objeto_2;
                objeto_2 = c;

                // Andante pelo loop
                x = x + 1;
            }

            return (colidiu);
        }

        // Lista de variáveis Globais
        static class var_global
        {
            public static int tempo = 1;
        }

        // A Cada Clock do relógio (Tempo do jogo)
        private void EU_SOU_O_TEMPO_Tick_1(object sender, EventArgs e)
        {
            // Vamos chamar a "gravidade"
            gravidade(BTN_CAIXA, BTN_CHAO);
        }
    }
}
