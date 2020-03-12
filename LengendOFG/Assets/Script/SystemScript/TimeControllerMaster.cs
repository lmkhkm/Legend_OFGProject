using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllerMaster : MonoBehaviour
{

    public float totalPlayTime;
    public float timer;
    public short hour;
    public short day;
    public short month;
    public short year;
    public short gameSpeed;
    public bool isGamePause;

    public Text timerText;
    public Text GameSpeedText;


    private void Start()
    {
        totalPlayTime = 0;
        timer = 0;
        gameSpeed = 1;
        GameSpeedText.text = ">";
        isGamePause = false;

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (!isGamePause)
        {
            timer += Time.deltaTime;
        }
        switch(gameSpeed)
        {
            case 1:
                if (timer > 4f/24f)
                {
                    timer -= 4f/24f;
                    hour++;
                };
                break;
            case 2:
                if (timer > 2f/24f)
                {
                    timer -= 2f/24f;
                    hour++;
                };
                break;
            case 3:
                if (timer > 1f/24f)
                {
                    timer -= 1f / 24f;
                    hour++;
                };
                break;
            case 4:
                if (timer > 0.5f/24f)
                {
                    timer -= 0.5f / 24f;
                    hour++;
                };
                break;
        }
        if (hour>24)
        {
            hour -= 24;
            day++;
        }
        if (day>=31)
        {
            day -= 30;
            month++;
        }
        if (month>12)
        {
            month -= 12;
            year++;
        }
        timerText.text = timer.ToString("F4") + "\n" + year + "." + month + "." + day;
    }

    public void GameSpeedUp()
    {
        if (gameSpeed < 4)
        {
            gameSpeed++;
        }
        else
            gameSpeed = 4;
        switch(gameSpeed)
        {
            case 1:
                GameSpeedText.text = ">";
                break;
            case 2:
                GameSpeedText.text = ">>";
                break;
            case 3:
                GameSpeedText.text = ">>>";
                break;
            case 4:
                GameSpeedText.text = ">>>>";
                break;
        }
    }

    public void GameSpeedDown()
    {
        if (gameSpeed > 1)
        {
            gameSpeed--;
        }
        else
            gameSpeed = 1;
        switch (gameSpeed)
        {
            case 1:
                GameSpeedText.text = ">";
                break;
            case 2:
                GameSpeedText.text = ">>";
                break;
            case 3:
                GameSpeedText.text = ">>>";
                break;
            case 4:
                GameSpeedText.text = ">>>>";
                break;
        }
    }

    public void GamePause()
    {
        if(isGamePause == true)
        {
            isGamePause = false;
        }
        else
        {
            isGamePause = true;
        }
    }
}
