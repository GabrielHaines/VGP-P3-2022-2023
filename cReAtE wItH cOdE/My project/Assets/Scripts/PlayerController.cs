using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 5.0f;
   private float turnspeed;
   

   // Start is called before the first frame update
    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward*Time.deltaTime* speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnspeed);
        //^^^^Vehicle move script^^^^
        
    }
}
