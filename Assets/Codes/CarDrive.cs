using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 10;

    public float TurnSpeed = 5;

    public float GravityModifier;

    GameManager gamemanager;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Turn();
        Fall();
        Respawn();
        QuitGame();
        RestartGame();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-Vector3.forward * speed * 10);
        }
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * TurnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * TurnSpeed * 10);
        }
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * GravityModifier);
    }

    void Respawn()
    {
        if (Input.GetKey(KeyCode.R))
        {
            gameObject.transform.position = new Vector3(0, 2, -230);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.AddRelativeForce(Vector3.forward * 0);
            rb.AddTorque(Vector3.up * 0);
        }
    }

    void QuitGame()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

    void RestartGame()
    {
        if (Input.GetKey(KeyCode.G))
            FindObjectOfType<GameManager>().EndGame(); 
    }
}
