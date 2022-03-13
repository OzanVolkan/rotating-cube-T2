using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float cubeRotateSpeed = 5f;
    [SerializeField] private Transform cubeTransform;

    private bool isMoving = false;

    private float rotateAngle = 0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isMoving = true;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            isMoving = false;
        }

        rotateAngle = Input.GetAxis("Horizontal");

        if (isMoving)
        {
            transform.position += transform.forward * playerSpeed * Time.deltaTime;
            transform.Rotate(0, rotateAngle, 0);
            cubeTransform.Rotate(cubeRotateSpeed * Time.deltaTime, 0, 0);
        }
    }
}
