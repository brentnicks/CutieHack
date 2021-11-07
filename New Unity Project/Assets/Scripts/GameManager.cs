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
    public void PlayerLost()
    {
        Debug.Log("Player has lost");
        Time.timeScale = 0;
        gameOver.GetComponent<TextMeshProUGUI>().enabled = true;

    }

    private void Update()
    {
        timeCountFloat += Time.deltaTime;
        timeCountInt = Mathf.RoundToInt(timeCountFloat);
        timer.text = "Time: " + timeCountInt.ToString() + " s";
    }
}
