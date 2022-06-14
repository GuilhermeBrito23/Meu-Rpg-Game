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

        public bool VerifyLVLUP(int exp)
        {
            if (this.exp>= this.maxExp)
            {
            
                Console.WriteLine("Você subiu de nivel");
                return true;

            }
            else
            {
                return false;
            }
        }

        public void LVLUP(int exp)
        {

            
            if (this.exp == this.maxExp)
            {
                this.exp = 0;
                this.maxExp += maxExp;
                this.maxHP += maxHP;
                this.hp = maxHP;
                this.power *= 2;
                this.level += 1;
            }
            if (this.exp > this.maxExp)
            {
                while (this.exp > this.maxExp)
                {
                    this.exp -= this.maxExp;
                    if (this.exp < 0)
                    {
                        this.exp = 0;
                    }
                    this.maxExp += maxExp;
                    this.maxHP += maxHP;
                    this.hp = maxHP;
                    this.power *= 2;
                    this.level += 1;
                }
            }
        }
    }
}
