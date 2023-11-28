using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{   
    public GameObject pipePrefab;
    public float spawnRate;
    public float NSpawned;
    public float heightOffset;

    public float baseVelocity;
    public float velocityMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        NSpawned = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Time.timeSinceLevelLoad > NSpawned*spawnRate)
        {   spawnPipe(NSpawned+1);
            NSpawned += 1;
        }
        
    }

    void spawnPipe(float pipeCount)
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        GameObject newPipe = Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0) , transform.rotation);
        float velocity = baseVelocity * Mathf.Pow(velocityMultiplier, pipeCount);
        newPipe.GetComponent<PipeScript>().setVelocity(velocity);
    }
}
