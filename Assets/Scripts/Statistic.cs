[System.Serializable]
public struct Statistic
{
    public int level;
    public int hp;
    public int mana;
    public int gold;
    public int def;
    public int attack;
    public int speed;
    public int knowladge;
    public int power;

    public static Statistic operator -(Statistic a)
    {
        return new Statistic()
        {
            level = -a.level,
            gold = -a.gold,
            hp = -a.hp,
            mana = -a.mana,
            def = -a.def,
            attack = -a.attack,
            speed = -a.speed,
            knowladge = -a.knowladge,
            power = -a.power
        };
    }
    
    public static Statistic operator +(Statistic a,Statistic b)
    {
        return new Statistic()
        {
            level = a.level+b.level,
            gold = a.gold+b.gold,
            hp = a.hp+b.hp,
            mana = a.mana+b.mana,
            def = a.def+b.def,
            attack = a.attack+b.attack,
            speed = a.speed+b.speed,
            knowladge = a.knowladge+b.knowladge,
            power = a.power+b.power
        };
    }

   

    public static Statistic operator *(Statistic a, int multiplier)
    {
        return new Statistic()
        {
            level = a.level * multiplier,
            gold = a.gold * multiplier,
            hp = a.hp * multiplier,
            mana = a.mana * multiplier,
            def = a.def * multiplier,
            attack = a.attack * multiplier,
            power = a.power * multiplier,
            speed = a.speed * multiplier,
            knowladge = a.knowladge * multiplier
            
        };
    }

  
    

}