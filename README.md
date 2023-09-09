<h1 align="center"> JOGO DA VELHA COMPLEXO </h1>
Criação de um Jogo da Velha Complexo para treinar os conhecimentos de C# usando a ferramenta do Windows Form no Visual Studio 2022

## _Explicando como o jogo funciona!_
### **1. Tela inicial do jogo**
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/tela_inicial.JPG width="500" height="400">

* Como se pode ver não é um jogo da velha habitual, nele há algumas regras e modo de jogar diferentes.\
* Ao iniciar o jogo, o jogador número um poderá escolher qualquer espaço para jogar, porém influenciará na próxima jogada, liberando apenas o setor que está ligado.

### **2. Organização das jogadas**
Aqui está uma imagem dos `espaços` e dos `setores`, cada jogo da velha tem seus setores relacioandos a espaços numerados de 1 a 9:\
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/jogo_setores_maiores.JPG widht=225 height=225>
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/jogo_setores_menores.JPG>

-Como exemplo:
* Na primeira jogada foi escolhido o setor número 2 do espaço central. Logo a jogada seguinte deverá ser no espaço superior central, que está destacado com a cor verde.
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/primeira_opcao.JPG widht=300 height=300>

* Já na segunda imagem foi selecionado o setor 7 do espaço superior. Logo a jogada seguinte deverá ser no espaço inferior esquerdo, destacado em verde.
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/segunda_opcao.JPG widht=300 height=300>

 ### **3. Preenchendo um espaço**
 * Ao finalizar um espaço, tanto para o jogador "X" ou "O", ele é bloqueado para novas inserções e a sequência das jogadas continuam a ordem natural.
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/primeira_label_finalizada.JPG widht=300 height=300>

### **4. Selecioando um setor cujo o espaço está finalizado**
* Para que o jogo fique mais estratégico ao selecionar um setor que o espaço relacionado já esteja completo será liberado para o próximo jogador todos os espaços possíveis de se jogar. Como exemplo segue imagens.

<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/escolhendo_espaco_cheio.JPG widht=300 height=300>
<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/liberando_espacos.JPG widht=300 height=300>

### **5.Finalização do jogo**
* Para finalizar o jogo, o jogador deverá conseguir preencher pelo menos espaços ou em diagonal ou verticalmente ou ainda horizontalmente.
* No exemplo abaixo o jogador "O" ganhou o jogo concluindo verticalmente o jogo.

<img src=https://github.com/VitorVDavoglio/Jogo-da-Velha-Complexo/blob/main/imagens/jogo_finalizado.JPG widht=300 height=300>
