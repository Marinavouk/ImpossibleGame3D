using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jump = 300;
    public float speed = 0.05f; //public so its not visible an don the 
    //top so it applies otherwise it doesnt work//Field
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
      void Update()
    {
        transform.Translate(0, 0, speed);//it moves the object thats attached to
        
        bool isKeyWasJustPressed = Input.GetKeyDown(KeyCode.Space);
        if (isKeyWasJustPressed)//if true then jumps
        {
            Rigidbody rb = GetComponent<Rigidbody>(); 
            rb.AddForce(0, jump, 0); 
        }
        
    }
}
