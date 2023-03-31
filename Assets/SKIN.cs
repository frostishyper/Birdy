using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKIN : MonoBehaviour
{
    
    public void skinchange() {
        int Skinvalue = PlayerPrefs.GetInt("SkinValue", 0);
        Skinvalue = (Skinvalue + 1) % 3;
        PlayerPrefs.SetInt("SkinValue", Skinvalue);
    }
    
}



