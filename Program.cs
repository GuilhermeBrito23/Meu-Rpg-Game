using RPG_Game.src;
using System.Threading;

//inicio da aplicação e instancia de classe com funções para manipulação dos calculos
Calc calc = new Calc();
Console.WriteLine("Jogo de RPG de Texto");

Console.WriteLine("Criando seu personagem...");
Thread.Sleep(1000);

//criando personagem do player através da classe PlayerHero
PlayerHero hero = new PlayerHero();
Console.WriteLine("Personagem Criado");
Console.WriteLine("Gerando Inimigos...");
Thread.Sleep(1000);

//criando um inimigo instanciando a classe Enemy
Enemy enemy = new Enemy();
Console.WriteLine("Inimigos Criados");
Console.WriteLine("Mostrando informações do Jogador");
Console.WriteLine(hero);

// variaveis para controle do loop
bool start = true;
string nextStep = " "; 
while (start == true)
{
    Console.WriteLine("Escolha a opção: ");
    Console.WriteLine("Aperte enter para prosseguir");
    Console.WriteLine("aperte C para sair");
    nextStep = Console.ReadLine();

    //verifica entrada do uruário
    switch (nextStep)
    {
        case "c":
            start = false;
            break;

        case "":
        // Caso usuário digite "Enter" é chamado a função de calculo da batalha
            calc.Attacks(hero, enemy);
            break;

        default:
            Console.WriteLine("Digite uma opção Valida");
            break;
    }
}


