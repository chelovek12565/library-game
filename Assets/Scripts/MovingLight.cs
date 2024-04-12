using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour
{
    Vector3 velocity;
    public float smoothTime;
    public float speed;
    public Transform targetPosition;
    bool toMove = false;

    void Update()
    {   
        if (toMove)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition.position, ref velocity, smoothTime, speed);
        }
    }

    public void GetItMoving()
    {
        toMove = true;
    }
}
