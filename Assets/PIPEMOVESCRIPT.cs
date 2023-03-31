using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIPEMOVESCRIPT : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxSpeed = 13f;
    public float Speedinterval = 4f;
    public float Speedincrease = 1f;
    public float deadZone = -30;
    
    private IEnumerator SpeedCoroutine;
    // Start is called before the first frame update
    private void Start() {
        SpeedCoroutine = increaseSpeed();
        StartCoroutine(SpeedCoroutine);
    }
    private IEnumerator increaseSpeed() {
        while (moveSpeed < maxSpeed) {
            moveSpeed += Speedincrease;
            yield return new WaitForSeconds(Speedincrease);
        }
        moveSpeed = maxSpeed;
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
