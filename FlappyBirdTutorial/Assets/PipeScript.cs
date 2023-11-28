using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;

        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }

    }

    public void setVelocity(float newVelocity)
    {
        Debug.Log("Setting velocity to " + newVelocity);
        velocity = newVelocity;
    }

}
