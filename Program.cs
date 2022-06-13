using RPG_Game.src;
using System.Threading;

Calc calc = new Calc();
Console.WriteLine("Jogo de RPG de Texto");

Console.WriteLine("Criando seu personagem...");
Thread.Sleep(1000);
PlayerHero hero = new PlayerHero();
Console.WriteLine("Personagem Criado");
Console.WriteLine("Gerando Inimigos...");
Thread.Sleep(1000);
Enemy enemy = new Enemy();
Console.WriteLine("Inimigos Criados");
Console.WriteLine("Mostrando informações do Jogador");
Console.WriteLine(hero);

bool start = true;
string nextStep = " ";
while (start == true)
{
    Console.WriteLine("Escolha a opção: ");
    Console.WriteLine("Aperte enter para prosseguir");
    Console.WriteLine("aperte C para sair");
    nextStep = Console.ReadLine();
    switch (nextStep)
    {
        case "c":

            break;

        case "":
            calc.Attacks(hero, enemy);
            break;

        default:
            Console.WriteLine("Digite uma opção Valida");
            break;
    }
}


