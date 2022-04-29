using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 12f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;
        Vector3 actualmove = move * speed * Time.deltaTime;
        rb.angularVelocity = Vector3.zero;
        rb.velocity = new Vector3(actualmove.x, rb.velocity.y, actualmove.z);
    }
}
