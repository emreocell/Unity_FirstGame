using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment movment;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "barrier")
        {
            movment.enabled = false;
            Application.Quit();
        }
    }
}
