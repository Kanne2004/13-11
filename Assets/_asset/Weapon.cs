using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public int CalculateDamage(int baseDamage, int bonusDamage)
    {
        return baseDamage + bonusDamage;
    }
    public float CalculateDamage(float baseDamage, float multiplier)
    {
        return baseDamage * multiplier;
    }
    public int CalculateDamage(int baseDamage, int bonusDamage, int criticalHit)
    {
        return (baseDamage + bonusDamage) * criticalHit;
    }

}
