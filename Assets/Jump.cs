using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpHeight = 7f;
    public bool isGrounded = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Jump Loaded");
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("Jump Button");
                rb.AddForce(Vector3.up * jumpHeight);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("isGrounded = true");
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
            Debug.Log("isGrounded = false");
        }
    }
}
