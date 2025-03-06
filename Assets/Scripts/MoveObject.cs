using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float x, y, z;
    public Vector3 speed;

    // Update is called once per frame
    void Update()
    {
        //include Time;  
        transform.position = new Vector3(x = 1, y, z);
        
        x += Time.deltaTime * speed.x;
        y += Time.deltaTime * speed.y;
        z += Time.deltaTime * speed.z;
        //y = y + Time.deltaTime;
       
        
       
    }
}
