using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    //public speed float to tweak in unity
    public float cannonSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the cannon move with keyboard input
        float direction = Input.GetAxis("Vertical");

        //make it move only in y-axis
        transform.Translate(0, direction * cannonSpeed * Time.deltaTime, 0);
    }
}
