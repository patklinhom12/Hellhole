using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnemy : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-speed * 10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
