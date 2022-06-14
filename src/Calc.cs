namespace RPG_Game.src
{

    public class Calc
    {
        // função que calcula o dano do Jogador através do seu atributo power
        public int DmgPlayer(PlayerHero player)
        {

            //Gerando calculo aleatório de dano, com retorno do atributo power multiplicado(1,2 ou 3)
            Random rand = new Random();
            int num = rand.Next(0, 4);

            if (num == 1)
            {
                return player.power * 1;
            }
            else if (num == 2)
            {
                return player.power * 2;
            }
            else
            {
                return player.power * 3;
            }
        }

        // função que calcula o dano do Monstro através do seu atributo power também
        public int DmgEnemy(Enemy enemy)
        {
            
            //Gerando calculo aleatório de dano, com retorno do atributo power multiplicado(1,2 ou 3)
            Random rand = new Random();
            int num = rand.Next(0, 4);

            if (num == 1)
            {
                return enemy.power * 1;
            }
            else if (num == 2)
            {
                return enemy.power * 2;
            }
            else
            {
                return enemy.power * 3;
            }
        }


        //função responsavel por todo calculo de dano  e exibição das informações apôs as interações
        public void Attacks(PlayerHero playerHero, Enemy enemy)
        {
            
            int dmgPlayer = DmgPlayer(playerHero);
            int dmgEnemy = DmgEnemy(enemy);

            Console.WriteLine($"Você causou {dmgPlayer} de dano");
            Console.WriteLine($"O monstro lhe causou {dmgEnemy} de dano");
            //Aqui é feito a atribuição de dano
            playerHero.hp -= dmgEnemy;
            enemy.hp -= dmgPlayer;

            //verifica se o monstro morreu
            if (enemy.hp <= 0)
            {
                Console.WriteLine("Você derrotou o monstro!");
              //atribui a xp que o monstro carregava para o player
              playerHero.exp += enemy.exp;
              //Faz a verificação se o player subiu de nivel
              //E caso a xp for muito grande verifica e atribui a quantidade de niveis recebido
              while(playerHero.VerifyLVLUP(enemy.exp)== true){
               playerHero.LVLUP(enemy.exp);
                Console.WriteLine(playerHero);
              }
              //exibe as informações do player após a luta contra o monstro
              Console.WriteLine("Status do seu personagem: ");
                Console.WriteLine(playerHero);
            }
            //se o monstro não morrer Exibe ambos os status
            else
            {
                Console.WriteLine("Status do seu personagem: ");
                Console.WriteLine(playerHero);
                Console.Write("Status do Monstro: ");
                Console.WriteLine(enemy);
            }

        }

    }
}