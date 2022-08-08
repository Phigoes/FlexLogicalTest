# Teste de Lógica

## Primo
Um número primo é aquele que é divisível apenas por um e por ele mesmo. 
Obs: O número 1 não é primo.
Escreva uma função otimizada que, dado um número inteiro positivo, retorne true se o número for primo ou false caso contrário, com o menor número de iterações possível.
Imprima o resultado em tela da seguinte forma: 
“O número num é primo. Número de iterações necessárias: count”
ou
“O número num não é primo. Número de iterações necessárias: count”

## Palíndromo
Palíndromo, do grego palin (novo) e dromo (percurso), é toda palavra ou frase que quando lida ao contrário, desconsiderando espaços e pontuações, possui o mesmo sentido. Ex.: “asa”, “ovo”, “A base do teto desaba”. 
Escreva uma função que receba uma string como parâmetro e retorne true caso o valor dessa string seja um palíndromo ou false, caso contrário.

## Movimento do bot
Existe um bot localizado em um par de coordenadas inteiras, (x, y). Ele pode ser movido para um outro par de coordenadas. Embora o bot possa se mover quantas vezes quiser, ele só pode fazer os dois tipos de movimentos a seguir:
    1. Da posição (x, y) para a posição (x + y, y).
    2. Da posição (x, y) para a posição (x, x + y).
Por exemplo, se o bot começa em (1, 1), ele pode fazer a seguinte sequência de movimentos: (1, 1) → (1, 2) → (3, 2) → (5, 2). Observe que o movimento sempre será para cima ou para a direita.

![image](https://user-images.githubusercontent.com/17608029/183329702-66a781e7-9273-4b2d-8fed-54d7443cb7ec.png)

Escreva uma função que, dadas as coordenadas iniciais e finais, determine se o bot pode alcançar as coordenadas finais de acordo com as regras de movimento.
Descrição da função:
A função deve retornar true se o bot puder atingir seu objetivo, caso contrário, retorne false.
A função tem o(s) seguinte(s) parâmetro(s):
  x1: valor inteiro, coordenada x inicial
  y1: valor inteiro, coordenada y inicial
  x2: valor inteiro, coordenada x final
  y2: valor inteiro, coordenada y final
