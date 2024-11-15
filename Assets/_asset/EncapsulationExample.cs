using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncapsulationExample : MonoBehaviour
{
    void Start()
    {
        Character character = new Character(100, 50);

        character.TakeDamage(20);
        Debug.Log("Health: " + character.GetHealth());
        character.UseEnergy(15);
        Debug.Log("Energy: " + character.GetEnergy());
        character.Heal(20);
        Debug.Log("Health: " + character.GetHealth());
        character.TakeDamage(20);
        Debug.Log("Energy: " + character.GetEnergy());
    }
}
