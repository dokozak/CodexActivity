using UnityEngine;
using UnityEngine.Rendering;

public class StatsGuy
{
    public int life = 7;
    public const int DEFAULTHP = 7;

    public int power = 5;
    public const int DEFAULTPOWER = 5;

    public int typeOfDamage = 0;
    public const int WATER = 0;
    public const int FIRE = 1;
    public const int GRASS = 2;


    public StatsGuy() { }

    public StatsGuy(int life, int power, int typeOfDamage)
    {
        this.life = life;
        this.power = power;
        this.typeOfDamage = typeOfDamage;
    }


    private void LoseLife(int life){ 
    this.life -= life;
    }

    private void WinLife(int life)
    {
        this.life += life;
    }

    public bool fight(int otherPower)
    {
        
        return power >= otherPower;
    }

    private bool contraElementFight(int otherPower)
    {
        return (power >= otherPower * 2);
    }

    private bool goodElementFight(int otherPower)
    {
        return (power* 2 >= otherPower);
    }

    public bool fightWithTypeOfDamage(int power, int type)
    {
        if(typeOfDamage == WATER)
        {
            switch (type)
            {
                case FIRE:
                    return goodElementFight(power);
                case GRASS:
                    return contraElementFight(power);
                case WATER:
                    return fight(power);
            }
        }

        if(typeOfDamage == GRASS)
        {
            switch (type)
            {
                case WATER:
                    return goodElementFight(power);
                case FIRE:
                    return contraElementFight(power);
                case GRASS:
                    return fight(power);
            }
        }

        if(typeOfDamage == FIRE)
        {
            switch (type)
            {
                case GRASS:
                    return goodElementFight(power);
                case WATER:
                    return contraElementFight(power);
                case FIRE:
                    return fight(power);
            }
        }

        return false;
    }

    public int getTypeOfDamage()
    {
        return typeOfDamage;
    }

}
