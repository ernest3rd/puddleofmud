using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour {

    public PlayerController pc;
    public bool isTurning = false;

    private float radian = 180 / Mathf.PI;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTurning)
        {
            float dist = -(pc.getVelocity()).x;
            float rotation = Mathf.Atan(dist / 160) * radian;

            if (dist > 10f)
            {
                rotation *= 0.001f;
            }

            transform.Rotate(0, 0, rotation * Time.deltaTime);
        }
    }

    public void Go(){
        isTurning = true;
    }
}
