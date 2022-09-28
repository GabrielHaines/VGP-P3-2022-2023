using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
   private float turnspeed = 25.0f;
   private float horizontalInput;
   private float forwardInput;


   // Start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("horizontal");
        forwardInput = Input.GetAxis("vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
        //^^^^Vehicle move script^^^^
        
    }
}
