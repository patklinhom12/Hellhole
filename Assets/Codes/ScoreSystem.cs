using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    //public GameObject _scoreText;
    public GameObject _PatientStatus;
    public static int TheScore = 0;
    public float DestroyTime = 0.5f;
    public static int PatientNum = 0;
    //public AudioSource CollectSound;

    private void Update()
    {
        if (PatientNum > 0)
        {
            _PatientStatus.GetComponent<Text>().text = "Patient on board!";
        } else if (PatientNum == 1)
                {
            _PatientStatus.GetComponent<Text>().text = "Can't pick up!";
        } else
        {
            _PatientStatus.GetComponent<Text>().text = "Find a patient";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && PatientNum < 1)
        {
            PatientNum += 1;
            Debug.Log("PatientNum + 1");
            //TheScore += 50; 
            //_scoreText.GetComponent<Text>().text = "Score : " + TheScore;
            Destroy(gameObject, DestroyTime);
        } 
    }
}
