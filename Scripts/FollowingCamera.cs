using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
