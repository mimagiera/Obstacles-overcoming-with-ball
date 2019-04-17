using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public float speed;
    private Vector3 moveDirection;
    // Use this for initialization
    void Start()
    {
        moveDirection = Vector3.up;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (transform.position.y >= 3.75)
        {
            moveDirection = Vector3.down;
        }
        else if (transform.position.y <= 0.1f)
        {
            moveDirection = Vector3.up;
        }
       transform.Translate(moveDirection * Time.deltaTime * speed);
    }
}