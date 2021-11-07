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
    public Button menuButton;
    public Spawner mySpawner;
    bool isPaused = false;
    bool isGameOver = false;
    public void PlayerLost()
    {
        Time.timeScale = 0;
        gameOver.GetComponent<TextMeshProUGUI>().enabled = true;
        menuButton.GetComponent<Image>().enabled = true;
        menuButton.GetComponent<Button>().enabled = true;
        menuButton.enabled = true;
        isGameOver = true;

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

        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused && isGameOver != true)
        {
            Time.timeScale = 0;
            isPaused = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused && isGameOver != true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
