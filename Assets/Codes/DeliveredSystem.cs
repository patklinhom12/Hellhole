using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveredSystem : MonoBehaviour
{
    public GameObject _scoreText;
    public static int TheScore = 0;
    //TimerSystem bonusTime;
    //public AudioSource CollectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ScoreSystem.PatientNum > 0)
        {
            TheScore += 50; 
            _scoreText.GetComponent<Text>().text = "Score : " + TheScore;
            ScoreSystem.PatientNum -= 1;
            //bonusTime.PlusTime();
            Debug.Log("PatientNum - 1");
        }
    }
}
