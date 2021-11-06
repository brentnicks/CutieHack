using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int score;

    public void PlayerLost()
    {
        Debug.Log("Player has lost");
        Time.timeScale = 0;
    }
}
