using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
         else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
