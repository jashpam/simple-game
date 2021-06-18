using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Text score;
    public Rigidbody ball;
    public float forwardForce = 100;
    public float sideForce = 200;


    void Start()
    {
        Debug.Log("Hello world");   
    }

    void Update()
    {
        ball.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            ball.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            ball.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

        score.text = transform.position.z.ToString("0");
    }
}
