using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    [SerializeField] private Player player;
    void Start()
    {
        player.playerName = "Kien";
        player.playerScore = 0;
        player.DisplayScore();

        //phuong thuc them diem
        player.AddScore(10);
        player.AddScore(20);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddScore(5);
        }
    }
}
