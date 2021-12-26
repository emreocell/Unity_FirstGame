using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour
{
    public Vector3 nScale = new Vector3(2f, 2f, 2f);
    public Transform player;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            player.transform.localScale += nScale;
            Destroy(gameObject);
        }
    }
}
