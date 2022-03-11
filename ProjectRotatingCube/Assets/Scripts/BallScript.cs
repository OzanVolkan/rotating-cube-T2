using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            transform.position = new Vector3(transform.position.x+5, transform.position.y, transform.position.z);
        }
    }
}
