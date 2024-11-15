using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private int health;
    private int energy;

    public Character(int Health, int Energy)
    {
        health = Health;
        energy = Energy;
    }
    public void TakeDamage(int amount)
    {
        if (amount > 0)
        {
            health -= amount;
            health = Mathf.Max(health, 0);
            Debug.Log("Nhan damage: " + amount);
        }
    }

    public void UseEnergy(int amount)
    {
        if (amount > 0 && amount <= energy)
        {
            energy -= amount;
            Debug.Log("Da su dung: " + amount + " nang luong!");
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
        {
            health += amount;
            Debug.Log("Da heal: " + amount);
        }
    }

    public void RechargeEnergy(int amount)
    {
        if (amount > 0)
        {
            energy += amount;
            Debug.Log("Nang luong da hoi: " + amount);
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetEnergy()
    {
        return energy;
    }
}
