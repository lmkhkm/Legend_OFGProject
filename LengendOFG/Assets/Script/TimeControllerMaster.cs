using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllerMaster : MonoBehaviour
{

    public float totalPlayTime;
    public float timer;
    public short day;
    public short month;
    public short year;
    public short gameSpeed;


    public Text timerText;
    public Text GameSpeedText;

    private void Start()
    {
        totalPlayTime = 0;
        timer = 0;
        gameSpeed = 1;
        GameSpeedText.text = ">";

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        switch(gameSpeed)
        {
            case 1:
                if (timer > 4)
                {
                    timer -= 4;
                    day++;
                };
                break;
            case 2:
                if (timer > 2)
                {
                    timer -= 2;
                    day++;
                };
                break;
            case 3:
                if (timer > 1)
                {
                    timer -= 1;
                    day++;
                };
                break;
            case 4:
                if (timer > 0.5f)
                {
                    timer -= 0.5f;
                    day++;
                };
                break;
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
        timerText.text = timer + "\n" + year + "." + month + "." + day;
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
}
