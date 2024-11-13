using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        Goblin goblin = new Goblin();
        goblin.EnemyName = "Goblin";
        goblin.Attack(); //da ghi de (overriden)
        goblin.Steal();

        Dragon dragon = new Dragon();
        dragon.EnemyName = "Dragon";
        dragon.Attack(); 
        dragon.Fly();
    }

    void Update()
    {

    }
}
