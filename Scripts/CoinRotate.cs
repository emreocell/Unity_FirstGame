using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float coinSpeed;
    void Update()
    {
        transform.Rotate(0, coinSpeed, 0, Space.World);
    }
}
