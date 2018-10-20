using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour {
     public Transform player;

    void Update()
    {
        if (player.position.y < (transform.position.y+2f))
        {
            transform.position = new Vector3(transform.position.x,player.position.y-2f,transform.position.z);
        }
    }
    
}
