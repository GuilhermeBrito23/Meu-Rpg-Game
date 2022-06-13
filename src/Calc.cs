namespace RPG_Game.src
{

    public class Calc
    {
        public int DmgPlayer(PlayerHero player)
        {


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
        public int DmgEnemy(Enemy enemy)
        {
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


        public void Attacks(PlayerHero playerHero, Enemy enemy)
        {

            int dmgPlayer = DmgPlayer(playerHero);
            int dmgEnemy = DmgEnemy(enemy);

            Console.WriteLine($"Você causou {dmgPlayer} de dano");
            Console.WriteLine($"O monstro lhe causou {dmgEnemy} de dano");

            playerHero.hp -= dmgEnemy;
            enemy.hp -= dmgPlayer;
            if (enemy.hp <= 0)
            {
                Console.WriteLine("Você derrotou o monstro!");
              if(playerHero.levelUP(enemy.exp)== true){
               
                Console.WriteLine(playerHero);
              }
            }
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