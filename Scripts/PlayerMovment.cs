using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2200f;
    public float sidesForce = 100f;
    public Vector3 scale;
    public Vector3 positionChange;
    
    void FixedUpdate()
    {
        scale = new Vector3(0.75f*Time.deltaTime, 0.75f * Time.deltaTime, 0.75f * Time.deltaTime);
        positionChange = new Vector3(0.0f, -0.01f, 0.0f);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        transform.localScale += scale;
        transform.position += positionChange;


        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidesForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidesForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space"))
        {
            Application.Quit();
        }
    }
}
