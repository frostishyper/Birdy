using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public AudioClip clip;
    private int previousValue = 0;
    
    private void Update() {
        int currentValue = int.Parse(score.text);
        if (currentValue != previousValue && currentValue % 10 == 0) {
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        }
        previousValue = currentValue;
    }
}
