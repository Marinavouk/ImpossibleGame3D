using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int targetFrameRate = 50;
    public float jumpForce = 300;
    public float speed = 0.05f; //public so its not visible and on the 
    //top so it applies otherwise it doesnt work//Field

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        {
            this.transform.Translate(Input.GetAxis("Horizontal"),0,0);
        }
        
        
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Jump();
        }

        //transform.Translate(0, 0, speed, Space.World); //it moves the object thats attached to}
    }

    private void Jump()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>(); //finds the component 
        rigidBody.AddForce(0, jumpForce, 0);
        rigidBody.angularVelocity = new Vector3(2, 0, 0);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");//if player touching the ground
        return Physics.CheckBox(transform.position, 
            transform.lossyScale / 1.99f, transform.rotation, layerMask);//a bit less then grounf so it collides
    }

    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();//since there is not velocity on 
        //new version. finds the velocity and adds the value
        if (rigidbody.velocity.y < -1f)
        {
            rigidbody.AddForce(0, -1, 0);
        }

        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed);
    }
    
}