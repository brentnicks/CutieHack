using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int score;
    private float timeCountFloat;
    private int timeCountInt;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI gameOver;
    public Spawner mySpawner;
    public void PlayerLost()
    {
        Time.timeScale = 0;
        gameOver.GetComponent<TextMeshProUGUI>().enabled = true;

    }

    private void Update()
    {
        timeCountFloat += Time.deltaTime;
        timeCountInt = Mathf.RoundToInt(timeCountFloat);
        timer.text = "Time: " + timeCountInt.ToString() + " s";

        if (timeCountInt > 8)
        {
            mySpawner.spawnDelay = 3.5f;
        }
        if (timeCountInt < 16 && timeCountInt >= 8)
        {
            mySpawner.spawnDelay = 3.0f;
        }
        if (timeCountInt < 24 && timeCountInt >= 16)
        {
            mySpawner.spawnDelay = 2.5f;
        }
        if (timeCountInt < 32 && timeCountInt >= 24)
        {
            mySpawner.spawnDelay = 2.0f;
        }
        if (timeCountInt >= 32)
        {
            mySpawner.spawnDelay = 1.5f;
        }
    }
}
