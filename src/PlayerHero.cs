using RPG_Game.src.Interfaces;
namespace RPG_Game.src
{
    public class PlayerHero : BaseHerosClass, IPlayerHero
    {
        public PlayerHero()
        {

            this.maxHP = 100;
            this.hp = maxHP;
            this.exp = 0;
            this.maxExp = 100;
            this.power = 5;
            this.level = 1;
        }

        public override string ToString()
        {
            return @$"
            MaxHP: {this.maxHP}
            HP: {this.hp}
            Exp: {this.exp}
            Exp para Upar: {this.maxExp}
            Força: {this.power}
            Level: {this.level}
            ";
        }

        public bool levelUP(int exp)
        {
            this.exp = exp;
            if (this.exp > maxExp)
            {
                 Console.WriteLine("Você subiu de nivel");
                while (this.exp >= maxExp){
               
                int overExp = this.exp - this.maxExp;

                this.exp = overExp;
                this.maxExp *=2;
                this.maxHP += maxHP;
                this.hp = maxHP;
                this.power *= 2;
                this.level += 1;
                }
                
                return true;
            }
            else if (this.exp == this.maxExp)
            {
                Console.WriteLine("Você subiu de nivel");

                this.exp = 0;
                this.maxHP += maxExp;
                this.hp = maxHP;
                this.power *= 2;
                this.level += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}