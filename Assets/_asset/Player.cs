using UnityEngine;
using System;


[Serializable]
public class Player
{
    public string playerName;
    public int playerScore;

    public void DisplayScore()
    {
        Debug.Log(playerName + "da dat " + playerScore + " diem!");
    }

    public void AddScore(int points)
    {
        playerScore += points;
        Debug.Log(points + " diem duoc them vao " + playerName + "'s score. Total socre: " + playerScore);
    }
}
