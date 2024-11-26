
# Duna 1984 - Documentação  
<br>  
<table>  
  <tr>  
    <td>  
      <p>Projeto realizado por Guilherme Fonseca da Silva e Guilherme Henrique Lemes de Souza, baseado na cena icônica do filme Duna (1984). A cena combina elementos cinematográficos com uma jogabilidade interativa para criar uma experiência imersiva, utilizando referências visuais e músicas do filme original.</p>  
    </td>  
  </tr>  
</table>  
<br>

## Explicação da cena original do filme
<p>
  Na cena original de Duna (1984), Paul Atreides utiliza um gancho para escalar o imenso verme de areia, uma criatura colossal que domina o deserto de Arrakis. A sequência destaca a determinação e o controle de Paul ao conquistar o verme, demonstrando seu crescimento como líder dos Fremen. O momento é crucial para sua jornada, simbolizando a conexão dele com o deserto e sua aceitação do destino como o Kwisatz Haderach (aquele que pode ver as memórias dos ancestrais), enquanto ele utiliza o verme como transporte através das vastas dunas de areia. </p>

## Explicação do jogo  

<p>O jogo se inicia com o jogador controlando Paul em cima do verme, desviando de pedras que aparecem no caminho. O jogador vence ao sobreviver por 2 minutos sem colidir com nenhuma pedra, retornando ao menu inicial ao fim do desafio. Caso o verme colida com uma pedra, uma tela de game over é exibida. O jogo possui menus interativos, músicas do filme e uma estética fiel ao universo visual de Duna. </p>  
<br>  

## Cenário e Ambientação
<p>O cenário do jogo foi projetado para capturar a atmosfera do deserto de Arrakis, utilizando um campo de visão (Field of View - FOV) com tonalidade amarelada. Essa escolha visual reforça a sensação de calor intenso e vastidão do deserto, transportando o jogador para o ambiente de Duna.

Para construir o cenário, utilizamos um prefab de terreno desértico, que foi ajustado e integrado ao jogo. Esse prefab inclui textura de areia realista e elementos visuais que remetem ao filme, como a imensidão sem fim do horizonte e a movimentação sutil da areia com o vento. Essa abordagem permitiu criar um ambiente imersivo, conectando visualmente o jogo à obra cinematográfica.</p>
<br>


## Paleta de Cores  

<p>A paleta de cores do jogo foi escolhida para refletir a estética do filme Duna (1984) e reforçar a ambientação do deserto de Arrakis. Tons terrosos, como areia, dourado e marrom, dominam o cenário, criando uma sensação de aridez e vastidão.  

Os elementos visuais principais, como o traje de destilação de Paul Atreides e o verme de areia, foram destacados com tons mais escuros, como preto e cinza, para contrastar com o fundo amarelado do deserto. A tonalidade amarelada aplicada ao campo de visão do jogador ajuda a transmitir a intensidade do sol e o calor característico de Arrakis, aumentando a imersão no mundo do jogo.</p>
<br>


## Personagens  

### Protagonista  

<p>Paul Atreides é o protagonista da história. Durante o jogo, ele monta o verme de areia em um momento crucial de sua jornada, representando sua conexão com o deserto de Arrakis e sua transformação como líder. Sua aparência segue o traje típico do deserto (traje de destilação), destacando tons escuros.</p>  
<table>  
<thead>
  <th>
    
  ![Imagem de Paul](https://github.com/user-attachments/assets/870b8ffa-c17f-499b-973e-daf9b7cd1b61)
  </th>
</thead>  
</table>  

### Verme de areia  

<p>O verme de areia é uma criatura icônica de Arrakis. Ele serve como o principal elemento visual e mecânico do jogo, movendo-se pelo deserto enquanto o jogador desvia de obstáculos no caminho. Sua aparência é fiel ao design do filme.</p>  
<table>  
<thead>  
  <th> 
    Feito totalmente no software 3d blender pela dupla.
    
![Imagem verme de areia](https://github.com/user-attachments/assets/b6168abf-0db9-45df-aae1-7f4c619d765b)
  </th>  
</thead>  
</table>  

## Obstáculos  

<p>Os obstáculos consistem em pedras que aparecem aleatoriamente no caminho do verme de areia. Esses elementos foram projetados para criar um desafio ao jogador, exigindo atenção e reflexos rápidos.</p>  
<table>  
<thead>  
  <th>
    
  ![Imgem pedras usadas de obstacúlo](https://github.com/user-attachments/assets/e036740b-1020-482e-8b5c-4b97780be6b8)
  </th>  
</thead>  
</table>  
<br>  

## Menus 
Feitos totalmente pelo site Canva.

### Menu Principal  

 • Tela inicial com botões interativos: jogar, e sair.  
 • Os botões mudam de cor ao passar o mouse por cima, proporcionando uma experiência dinâmica.  
<table>  
<thead>  
  <th> 
    
  ![Imagem do menu principal](https://github.com/user-attachments/assets/474f0874-afea-4ca1-b0f6-26e11dee176d)
  </th>  
</thead>  
</table>   

### Game Over  

 • Tela exibida caso o verme de areia colida com uma pedra.  
 • Contém a opção de reiniciar o jogo, retornando ao menu principal.  
<table>  
<thead>  
  <th>  
    
   ![Imagem do game over](https://github.com/user-attachments/assets/110c557d-bfb3-485c-8bbe-b8ac8a8fa3d3)
  </th>  
</thead>  
</table>

## Músicas do jogo  

<p>As músicas utilizadas no jogo foram cuidadosamente escolhidas para refletir a atmosfera de Duna (1984) e proporcionar uma experiência imersiva. No menu principal, a trilha sonora é composta por "Dune (Desert Theme)" e "Main Title", ambas da banda Toto, responsáveis pela trilha sonora original do filme. Essas músicas capturam a grandiosidade e o mistério do universo de Arrakis, conectando o jogador diretamente à estética sonora do filme.</p>  

## Códigos do jogo  

 Imagens de todos os scripts comentados e com suas devidas explicações. 
<br>  

### Menu Principal  

Scripts que gerenciam os botões e suas funções, como iniciar o jogo, acessar as configurações e sair.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Botões do Menu  

Scripts que controlam a interação visual dos botões, como a mudança de cor ao passar o mouse.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Câmera  

Script que ajusta a câmera para acompanhar o movimento do verme no deserto.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Pedras  

Configuração do modelo 3D das pedras usadas como obstáculos no jogo.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Geração das Pedras  

Código que gera as pedras aleatoriamente no caminho do verme.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Game Over  

Scripts que exibem a tela de game over e permitem ao jogador reiniciar o jogo.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

### Timer  

Scripts que criam um cronômetro e verifica se chegou no final gerando a condição de vitória.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

## Movimentação do verme de areia  

Código que controla o movimento contínuo do verme e a detecção de colisões com obstáculos.  
<table>  
<thead>  
  <th>  
    imagem  
  </th>  
</thead>  
</table>  
<br>  

## Vídeo  

Vídeos de Apresentação básica das mecânicas do jogo.  

[Duna 1984](https://github.com/user-attachments/assets/478b5a62-651c-4a37-91cd-7cc0da90ff35)


<br>  

> ### Referências  

 [Proganista](https://sketchfab.com/3d-models/fremen-of-dune-fb4be07a655a47f890f1ff1d42f7f57e)
 
 [Deserto](https://sketchfab.com/3d-models/dune-arrakis-wip-58bd8be249944f1b892a52eb52e06024)
 
 [Pedras usadas de obstáculo](https://assetstore.unity.com/packages/3d/environments/landscapes/stylized-low-poly-rocks-271334)

 [Música do menu principal](https://youtu.be/oauF0jXcAq8?si=goZx5islc5gG6Zvs)

 [Música do jogo](https://youtu.be/yE4pPzrkgsM?si=WzNQ7ztFg0gi-7A5)
 
