using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 300;
    public float speed = 0.05f; //public so its not visible an don the 
    //top so it applies otherwise it doesnt work//Field

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>(); //finds the component 
            rigidBody.AddForce(0, jumpForce, 0);

        }

        transform.Translate(0, 0, speed); //it moves the object thats attached to}
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, 
            transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }

    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody.velocity.y < -1f)
        {
            rigidbody.AddForce(0, -1, 0);
        }
    }
}