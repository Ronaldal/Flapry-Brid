using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heigestOffset = 10;
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spwanPipe();
            timer = 0;
        }
    }
    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heigestOffset;
        float heigestPoint = transform.position.y + heigestOffset;
        Instantiate(pipe, new Vector3 (transform.position.x,Random.Range(lowestPoint,heigestOffset),0), transform.rotation);

    }
}
