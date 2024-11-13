using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string EnemyName;

    public virtual void Attack()
    {
        Debug.Log(EnemyName + " attack!");
    }
}

public class Goblin : Enemy
{
    //override: ghi de => thay the phuong thuc dang ke thua
    public override void Attack()
    {
        Debug.Log(EnemyName + " chem!");
    }

    public void Steal()
    {
        Debug.Log(EnemyName + " da cuop it vang!");
    }
}

public class Dragon : Enemy
{
    //public override void Attack()
    //{
    //    Debug.Log(EnemyName + " phun lua!");
    //}

    public void Fly()
    {
        Debug.Log(EnemyName + " bay tren troi!");
    }
}