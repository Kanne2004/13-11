using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverloadingExample : MonoBehaviour
{
    void Start()
    {
        Weapon sword = new Weapon();
        Debug.Log("CalculateDamage(int, int): " + sword.CalculateDamage(10, 5));
        Debug.Log("CalculateDamage(float, float): " + sword.CalculateDamage(10.5f, 1.5f));
        Debug.Log("CalculateDamage(int, int, int): " + sword.CalculateDamage(5, 10, 15));
    }
}
