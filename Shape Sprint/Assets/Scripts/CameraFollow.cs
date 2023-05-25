using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
  
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 position = transform.position;
        position.x = player.position.x;
        position.z = -10;
        transform.position = position;
    }
}
