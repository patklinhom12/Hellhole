using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoBehaviour
{
    public float TimeStart = 60;
    public float _TimeMinus = 20;
    public float _TimePlus = 20;
    bool TimeS = true;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = TimeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeStart >= 0)
        {
            TimeS = true;
           TimeStart -= Time.deltaTime;
           textbox.text = Mathf.Round(TimeStart).ToString();          
        } else
        {
            textbox.text = "GAME OVER";
            FindObjectOfType<GameManager>().EndGame();
        } 
    }

    public void MinusTime()
    {
        TimeStart -= _TimeMinus;
    }

    public void PlusTime()
    {
        TimeStart += _TimePlus;
    }
}
