using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respon : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))// این برای ریسپیون تو مکان اوله
        {
            transform.position = new Vector3(696.9f, 3.12f, 720.84f); 
            transform.rotation = Quaternion.Euler(0, -179.509f, 0); 

        }
        if(Input.GetKeyDown (KeyCode.O)) // اینم برای تغییر زاویه داخل همون مکان کلید او هستO
        {
            transform.rotation = Quaternion.Euler(0,0, 0);
        }
    }
}
