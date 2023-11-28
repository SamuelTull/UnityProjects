using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{   
    public float NSpawned= 0;
    public float NPassed = 0;
    public float spawnRate;
    public float heightOffset;
    public float baseVelocity;
    public float velocityMultiplier;
    public GameObject pipePrefab;
    public List<GameObject> pipes = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {   
        if (Time.timeSinceLevelLoad > NSpawned*spawnRate)
        {   spawnPipe(NSpawned+1);
            NSpawned += 1;
        }

        // remove from pipes if passed the bird 
        if (pipes.Count > 0 && pipes[0].GetComponent<PipeScript>().isPassed)
        {
            NPassed += 1;
            pipes.RemoveAt(0);
        }

    }

    void spawnPipe(float pipeCount)
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        GameObject newPipe = Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0) , transform.rotation);
        float velocity = baseVelocity * Mathf.Pow(velocityMultiplier, pipeCount);
        newPipe.GetComponent<PipeScript>().setVelocity(velocity);
        pipes.Add(newPipe);
    }
}
