using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    Rigidbody rb;
    float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

    }

    void FixedUpdate(){
        Vector3 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
