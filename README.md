# Gravidade e colisão no form do C#. Versão 1.2

Um exemplo que mostra a implementação de gravidade e colisão no C# para jogos simples em 2D.
[<img src="https://raw.githubusercontent.com/gabriel-gregorio-da-silva/gravidade_e_colisao_no_csharp/master/caixa%20e%20ch%C3%A3o%20legal.png">](#)


## Dicas
- Eu recomendo que você implemente a colisão e a gravidade, já que geralmente usamos a gravidade para que objetos possam cair no chão correto?
- E nem pense em fazer um objeto se movimentar __'10 passos'__, porque ele na verdade irá se '__teletransportar__' 10 passos e poderá pular o objetivo

## Como Implementar? 
Copie esses códigos no formulário do seu game seguindo as instruções abaixo:

- - - 

### O MÉTODO DA GRAVIDADE?

```C#
// Exemplo para 'fornecer' a gravidade para o botão "caixa", Até tocar no Botão "chao"
gravidade(caixa , chao);
```
Recomendo que você use um timer de 1 ms para __'chamar'__ o método de gravidade, dessa forma, ele funcionará de forma independente de outras variáveis

- - - 

### O MÉTODO DE COLISÃO?                  
```C#
// Exemplo para verificar se o button1 toca no button2:
if ( colisao(button1 , button2) == "sim")            
{                                                    
// button1 tocou no button2, ou vice-versa!
};                                               
```

- - - 
- - -

# OS ALGORITIMOS
## GRAVIDADE 
### Considerações
- __chao_referencia__ é um objeto botão chamado __chão__ que está em baixo do objeto.
- __objeto__ é um botão que se chama __caixa__ e está em cima do __chao_referencia__, ou seja, a __caixa__ está sobre o __chão__
- __“if (colisao(objeto, chao_referencia)”__ se refere ao método de colisão, que está exemplificado abaixo dessa algoritmo
- A variável global __tempo__ é o "Tempo" para fornecer a aceleração para o objeto até a colisão com o __ “chão”__. 1,2,3,4...

### Algoritmo
```C#
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
        // Lista de variáveis Globais
        static class var_global
        {
            public static int tempo = 1;
        }
```
- - - 
## COLISÃO 
### Considerações
- __objeto_1__ é um botão com nome de __caixa__ que iremos passar para o método
- __objeto_2__ é um botão com nome de __chao__ que iremos passar para o método
- Quando o objeto 1 colidir com o 2, o método irá retornar uma string com a string __sim__

### Algoritmo
```C#
        // *************** CALCULOS DE COLISÃO *************** \\
        public string colisao(Button objeto_1, Button objeto_2)
        {
            string colidiu = "nada"; // Retorna se houve uma colisão ou não
            Button c;                // Ajuda na inversão para múltiplos testes
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
```
# Considerações finais
Novamente recomendo o uso de um timer para __"chamar"__ o método gravidade, para que ele funcione de forma independente e continua. __Faça o seu timer no forms__
```C#
        // Tempo do jogo
        private void EU_SOU_O_TEMPO_Tick_1(object sender, EventArgs e)
        {
            // Vamos chamar a "gravidade"
            gravidade(BTN_CAIXA, BTN_CHAO);
        }
```
### Autor: Gabriel Gregório da Silva
### E-mail: gabriel.gregorio.1@outlook.com
### Créditos: Não roube meu créditos hahahah
