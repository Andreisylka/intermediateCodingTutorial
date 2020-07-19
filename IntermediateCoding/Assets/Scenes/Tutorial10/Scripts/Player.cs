using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody myPlayer;

    private float jumpHeight = 4;
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpHeight += 2;
           Vector3 position = new Vector3(transform.position.x , jumpHeight , transform.position.z);
           myPlayer.position = position;
          
           // Vector3 direction = position.normalized;
           // Vector3 velocity = position * 7;
           // Vector3 moveAmount = velocity * Time.deltaTime;
           // Debug.Log(moveAmount);
           // transform.Translate(moveAmount);
        }

    }
    destr
    
        
}
