using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAM : MonoBehaviour
{
    public float moveSpeed = 7;
    public float deadZone = -30;
    public  BirdScript Birdscript;
    public GameObject Bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 
        
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
