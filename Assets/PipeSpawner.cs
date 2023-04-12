using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer;
    public float highOffset = 5;
    public float spaceOffset;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float highestPointY = transform.position.y + highOffset;
        float lowestPointY = transform.position.y - highOffset;
        float highestPointX = transform.position.x + spaceOffset;
        Instantiate(pipe, new Vector3(highestPointX, Random.Range(lowestPointY, highestPointY), 0), transform.rotation);
    }
}
