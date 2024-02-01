using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakenonspawn : MonoBehaviour
{
   
    public float cakeSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        cakebody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //make the cannon move with keyboard input
        float direction = Input.GetAxis("Vertical");

         
        //make it move only in y-axis
        transform.Translate(direction * cakeSpeed * Time.deltaTime, 0, 0);
    }
}
