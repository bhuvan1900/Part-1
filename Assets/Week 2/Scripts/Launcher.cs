using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject missilePrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
            //make missile appear
            Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
      
    }
}
