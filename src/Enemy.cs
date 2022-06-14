namespace RPG_Game.src
{
    public class Enemy : BaseHerosClass
    {
        bool boss = false;
        string isBoss = "";
          
        public Enemy()
        {

            this.maxHP = 20;
            this.hp = maxHP;
            this.level = 1;
            this.exp = 150;
            this.power = 10;
            this.boss = false;
         
        }
        public Enemy(bool boss){
            if(boss == true){
            this.maxHP = 100;
            this.hp = maxHP;
            this.boss = true;
            this.isBoss = "Boss";
            this.exp = 800 ;
            this.power = 5;

            }
        }
        public override string ToString()
        {
            if(this.isBoss == "Boss"){
                 return @$"
            MaxHP: {this.maxHP}
            HP: {this.hp}
            Exp: {this.exp}
            Força: {this.power}
            Level: {this.isBoss}
            ";
            }else{
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
}