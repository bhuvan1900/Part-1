using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed3 = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
        
        //if (Input.GetKeyDown(KeyCode.V)) ;
        {
            transform.Rotate(keyboardInput * speed3 * Time.deltaTime * Vector3.forward, 1);
        }
    }

    
}
