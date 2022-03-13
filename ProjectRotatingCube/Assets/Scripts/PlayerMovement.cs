using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Renderer renderer;

    public GameObject _expScreen;
    public GameObject crashEffect;
    //public bool isMoving;
    public float moveSpeed = 10f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        crashEffect = Instantiate(Resources.Load("CrashEffect")) as GameObject;
        //   _expScreen = GetComponent<Screens>().expscreen;
    }

    void Update()
    {

        /*
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }
        if (isMoving)
        {
            rb.AddForce(Vector3.forward * moveSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        } */

        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -49f, 49f), transform.position.y, Mathf.Clamp(transform.position.z, 1f, 99f));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Red")
        {
            renderer.material.color = Color.red;
            Score.scoreCount++;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Green")
        {
            renderer.material.color = Color.green;
            Score.scoreCount += 3;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Blue")
        {
            renderer.material.color = Color.blue;
            Score.scoreCount += 2;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            //rb.AddForce(transform.up * 100000f);
            //rb.AddExplosionForce(1000f, transform.position, 10f, 1000f, ForceMode.Impulse);
            _expScreen.SetActive(true);
            renderer.enabled = false;
            crashEffect.transform.position = transform.position;
            crashEffect.GetComponent<ParticleSystem>().Play();
        }
    }
}
