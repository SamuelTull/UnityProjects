using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public GameObject pipeSpawner;
    public float gravity;
    public float upForce;
    public float velocity;
    public float Nchecked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity = upForce;
        }
        velocity -= gravity * Time.deltaTime;
        transform.position += new Vector3 (0, velocity * Time.deltaTime, 0);


        
    }
}
