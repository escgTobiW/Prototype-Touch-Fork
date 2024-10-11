using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeImplimentScript : MonoBehaviour
{
    void Start()
    {
        // Enable The Gyroscope as Input Device
        Input.gyro.enabled = true;
    }

    void Update()
    {
        // Sets Rotation Of Game Object To Match Gyroscope
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        // Returns Quaternions in order (Up & Down, Forward & Back, Left & Right)
        return new Quaternion(q.x, -q.z, q.y, -q.w);
    }
    
}
    
