//Ben Michael and Tristan Hildahl
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    float deviceOrientX;
    float deviceOrientY;
    Gyroscope theGyro;
    //Rigidbody2D sandRB2D;
    void Start ()
    {
        theGyro = Input.gyro;
        theGyro.enabled = true;
        //sandRB2D = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        deviceOrientX = theGyro.attitude.x;
        deviceOrientY = theGyro.attitude.y;

        Physics2D.gravity = new Vector2(deviceOrientX, deviceOrientY);
        //sandRB2D.AddForce(new Vector2(deviceOrientX, deviceOrientY));
    }
}
