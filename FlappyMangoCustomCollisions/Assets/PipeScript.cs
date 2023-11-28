using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float velocity;
    public bool isPassed = false;
    



    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;

        if (!isPassed)
        {
            if (transform.position.x < -0.3)
            {
                isPassed = true;
            }
        }
        else if (transform.position.x < -5)
            {
                Destroy(gameObject);
            }
        





    }

    public void setVelocity(float newVelocity)
    {
        //Debug.Log("Setting velocity to " + newVelocity);
        velocity = newVelocity;
    }

}
