using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 5;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) { timer = timer + Time.deltaTime; }



        else
        {
             Spawn();
            timer = 0;
        }

    }
    void Spawn()
    {
        float lowestPoint= transform.position.y -heightOffset;
        float highestPoint= transform.position.y + heightOffset;    
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}
