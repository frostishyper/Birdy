using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private bool hasDied = false;
    public float flapStrength;
    public LOGICSCRIPT logic;
    public AudioClip clip;
    public bool birdIsAlive = true;
    public Sprite red;
    public Sprite black;
    public Sprite blu;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LOGICSCRIPT>();
        int Skinvalue = PlayerPrefs.GetInt("SkinValue");
            if (Skinvalue == 0) {
                GetComponent<SpriteRenderer>().sprite = red;
            }
            if (Skinvalue == 1) {
                GetComponent<SpriteRenderer>().sprite = black;
            }
            if (Skinvalue == 2) {
                GetComponent<SpriteRenderer>().sprite = blu;
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (birdIsAlive == false && !hasDied) {
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            hasDied = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
