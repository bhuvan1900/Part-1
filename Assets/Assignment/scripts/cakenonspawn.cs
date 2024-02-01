using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class cakenonspawn : MonoBehaviour
{
   
    public float cakeSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
        //cakebody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //make it move only in y-axis

        transform.Translate(1 * cakeSpeed * Time.deltaTime, 0, 0);
    }
}
