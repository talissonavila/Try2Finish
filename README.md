# Documentação de Try2Finish
Try2Finish é um jogo Desenvolvido em plataforma 2D na [Unity](https://pt.wikipedia.org/wiki/Unity) com scripts em [C#](https://pt.wikipedia.org/wiki/C_Sharp).
- Para acessar a build em desenvolvimento do jogo acesse [aqui](https://github.com/talissonavila/Try2Finish/tree/try2finish_build).
- Caso encontre algum bug ou queira inserir alguma funcionalidade, abra uma issue no repositório do projeto que os desenvolvedores verão e arrumarão o bug ou verão a viabilidade de implantação de tal funcionalidade.

# Requisitos e funcionalidade do projeto
- O jogo contém um personagem principal tem a seguinte movimentação:
    - Movimentação para a esquerda (usando a tecla 'A' do teclado ou a seta para esquerda '←').
    - Movimentação para a direita (usando a tecla 'D' do telcado ou a seta para direita '→').
    - Pulo, que pode ser feito usando a tecla 'ESPAÇO' do teclado. O jogador pode durante a mecânica de pulo dar mais um pulo no ar, gerando um pulo duplo (double jump).
- Animações:
    - O personagem possui 3 animações. Para sair de uma animação é preciso iniciar outra.
        1. Caso ele fique parado, uma animação de idle se inicia.
        2. Quando ele se movimenta, uma animação de 'corrida' se inicia.
        3. Quando ele pula, uma animação de pulo se inicia.
    - Objetos também possuem animações.
        1. No caso de coletáveis, maçãs, elas possuem uma animação de idle mas, ao pegá-las, inicia-se uma animação de destruição, sumindo com elas.
        2. Obstáculos possuem uma animação de idle padrão, com excessão da plataforma que cai e da mola que, no caso da plataforma que cai, ao entrar em contato com o personagem, cai após determinado tempo, e da mola que ao entrar em contato com o personagem, inicia uma animação de 'expandir' e voltar para idle após determinado tempo, aguardando novo contato com o personagem.
        3. Inimigos possuem animação de 'corrida' para o lado e para o outro, eles se movimentam para um lado e após colisão eles mudam a direção em 180º (Caso estejam se movendo para esquerda, ao colidir com algo, movem-se para direita e vice-versa).
- Durante as fases terão maçãs que ao pegá-las irá pro contador de maçãs localizado no canto superior direito.
- Para avançar de fases o jogador deve passar por cima de uma bandeira, uma linha de chegada. Isso levará para a próxima fase. Exceto na última que levará para os créditos do jogo.
- Cada fase tem um ambiente diferente do outro, com inimigos, número de coletáveis (maçãs), obstáculos, diferentes do outro, de modo que quem esteja jogando sinta que há progressão durante sua jornada em Try2Finish.
- Os obstáculos inseridos no jogo são: 
    - Uma 'mola' que joga o jogador para bem alto.
    - Uma plataforma flutuante, que depois de determinado tempo, cai, fazendo com que caso o jogador esteja em cima dela precise ser rápido para sair dela.
    - Espinhos que, ao tocá-los, mata o personagem.
    - Ventilador que quando o jogador está no alcance dele, o faz flutuar para cima e para baixo, precisando observar a mecânica para progredir de fase.
    - Inimigo que caso entrem em contao com o personagem, mata-o exceto caso o personagem pule em cima da cabeça do inimigo, resultando na morte do inimigo.
    - Serra que se move durante trecho da fase que faz com que o personagem precise pular por cima dela, caso entre em contato com ela, ele morre.

# Protótipos de baixa fidelidade
## **Aqui contém algumas imagens do jogo em funcionamento.**
1. Abaixo está a imagem da tela inicial do jogo. Nela dá pra ver a primeira fase do jogo com animação nas maçãs bem como no checkpoint que lhe leva para próxima fase. Para começar o jogo se faz necessário clicar no botão 'START GAME'.

![Tela Inicial de Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/newgame.png)

2. Abaixo está a imagem da primeira fase do jogo. Por ser a primeira fase, não contém inimigos ou obstáculos, para que o jogador crie familiaridade com o jogo.

![Fase 1 Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/phase1.png)

3. Abaixo está a imagem da segunda fase do jogo. Percebe-se uma diferença nos blocos que compõe o cenário, assim como adição de obstáculos.

![Fase 2 Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/phase2.png)

3. Abaixo está a imagem da terceira fase do jogo. Diferente no cenário das outras fases anteriores, como adição de outros obstáculos, para que o jogador sinta uma progressão de nível durante o jogo.

![Fase 3 de Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/phase3.png)

4. Abaixo está a imagem da quarta fase do jogo. Novamente, há uma diferença na composição do cenário em relação as fases anteriores, assim como na adição de obstáculos novos e de inimigos.

![Fase 4 de Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/phase4.png)

5. Ao falhar durante as fases de Try2Finish, entrará a tela de 'Fim de Jogo' que dará a chance do jogador tentar novamente, após clicar em 'RESTART GAMING', levando-o para a fase inicial do jogo.

![Tela de Fim de Jogo de Try2Finish](https://github.com/talissonavila/Try2Finish/blob/try2finish_build/images/gameover.png)

# Instalação
1. Acesse a build em desenvolvimento, clicando [aqui](https://github.com/talissonavila/Try2Finish/tree/try2finish_build).
2. Baixe o arquivo compactado.
3. Descompacte-o pelo seu descompactador de preferência.
4. Abra a pasta Build.
5. Execute o arquivo Try2Finish.exe.
6. Aproveite sua jogatina.

# Créditos
- Hellyson Herik da Silva Costa (desenvolvedor).
- Talisson Freitas Avila (desenvolvedor).
- Walber Florêncio de Almeida(orientador).
