using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int[] array = new int[4];
    public Color[] Colors = {Color.red, Color.blue, Color.green, Color.yellow};
   
    

    void Start()
    {
        Colors[0] = Color.red;
        Colors[1] = Color.blue;
        Colors[2] = Color.green;
        Colors[3] = Color.yellow;
        
    }

    
    void Update()
    {
       
    }
}
