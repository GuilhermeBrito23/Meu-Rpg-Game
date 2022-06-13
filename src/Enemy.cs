namespace RPG_Game.src
{
    public class Enemy : BaseHerosClass
    {
        public Enemy()
        {

            this.maxHP = 20;
            this.hp = maxHP;
            this.level = 1;
            this.exp = 800;
            this.power = 10;
        }
        public override string ToString()
        {
            return @$"
            MaxHP: {this.maxHP}
            HP: {this.hp}
            Exp: {this.exp}
            Força: {this.power}
            Level: {this.level}
            ";
        }

    }
}