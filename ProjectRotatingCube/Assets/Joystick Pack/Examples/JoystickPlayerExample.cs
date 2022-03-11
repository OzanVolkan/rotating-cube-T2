using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick fixedJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * fixedJoystick.Vertical + Vector3.right * fixedJoystick.Horizontal;
        
        rb.velocity = direction * speed * Time.deltaTime;
        //rb.AddForce(direction * speed * Time.deltaTime, ForceMode.Impulse);
        //rb.AddTorque(direction * speed, ForceMode.Impulse);
    }

}