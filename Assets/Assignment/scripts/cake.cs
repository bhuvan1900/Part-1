using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cake : MonoBehaviour
{
    public GameObject cakefab;
    public Vector2 cakeSpeed = new Vector2(10, 0);
    Rigidbody2D cakebody;

    // Start is called before the first frame update
    void Start()
    {
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(cakefab, transform.position, transform.rotation);
        }
       


    }

    private void FixedUpdate()
    {
        cakebody.MovePosition(cakebody.position + cakeSpeed * Time.deltaTime);
    }


}
