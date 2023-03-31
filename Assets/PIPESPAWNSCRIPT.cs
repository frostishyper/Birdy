
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIPESPAWNSCRIPT : MonoBehaviour
{
    public GameObject pipe;
    public GameObject sam;
    public float spawnRate = 3f;
    private float timer = 0;
    private float samtimer = 0;
    public float heightOffset = 10;
    public float samheightOffset = 8;
    public float SamSpawn = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
            timer = 0;
        }
        if (samtimer < SamSpawn) {
            samtimer += Time.deltaTime;
        }
        else {
            spawnSam();
            samtimer = 0;
        }
    }
    void spawnPipe () {
        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
    void spawnSam () {
        float lowestpoint = transform.position.y - samheightOffset;
        float highestpoint = transform.position.y + samheightOffset;
        
        Instantiate(sam, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
