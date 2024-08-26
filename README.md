# Microondas

Teste pratico criando uma simulação de um painel de Microondas, com sistema de controle de Programas de Aquecimento pré-definidos e customizados integrado.

## Tecnologias
- C#
- Windows Forms Application
- PostgreSQL

## Bando de Dados
Para configurar o Bando de Dados, acesse o caminho Microondas/Properties/DbConnection.cs, e edite a string de conexão. 
Para o Modelo de tabela de dados utilizada, acesse o caminho Microondas/dbMicroondas.csv, la encontrara o insert para a tabela e os dados para os Programas de aquecimento Pré-definidos e alguns customizados.

## Modo de Uso
Sistema conta com painel numérico onde os valores podem ser inseridos através do click com o mouse ou digitados através do teclado do computador. 
Conta também com sistema de controle de Programas de Aquecimento, onde é possível cadastrar novos programas de aquecimento.
 - Programas de aquecimento pré-definidos, por padrão não podem ser editados, com exceção do programa "Aquecimento" que pode ter seu tempo(Mas 2Minutos e Min 1Segundo) e potencia editados.
 - Os novos programas deverem ter obrigatoriamente nome do programa, alimento, potência, símbolo (caractere de aquecimento para o painel).
Para utilizar um programa de aquecimento é necessário clicar duas vezes no programa desejado depois em Iniciar.

Ao pressionar o botão Iniciar com o cronometro 00:00 será acionado o "Inicio Rápido", tendo tempo: 30s e potência: 10. 
Ao pressionar o botão Parar uma vez o cronometro será Pausado, ao pressionar uma segunda vez o aquecimento será cancelado.

### Atenção: 
Os tempos dos programas são cadastrados em SEGUNDOS, porem ao serem selecionados no microonda são convertidos em minutos. 
O mesmo vale para valores inseridos manualmente, ex: 85segundos será convertido para 1m25s. Porem se meu objetivo foi 8m50s basta continuar digitando que o mesmo será novamente convertido para o tempo desejado.
