using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotations : MonoBehaviour
{
    public GameObject spherePrefab;
    public Transform sphereTransform;
    public float rotationSpeed;
    public float movementSpeed;

    // Start is called before the first frame updae
    void Start()
    {
        
        rotationSpeed = Mathf.Floor(transform.rotation.eulerAngles.y);
        
        initialise();
        Debug.Log(transform.rotation.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
       movement();
        transform.Rotate(0 ,rotationSpeed, 0 , Space.World);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed +=2;
        }
       
    }

    void initialise()
    {
        var child = Instantiate(spherePrefab);
        sphereTransform = child.transform;
        
        sphereTransform.parent = transform;
        foreach (Transform child2 in transform)
        {
            child2.position = transform.position;
            child2.position += Vector3.forward * 1.0f;
        }
        
    }

    void movement()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0 ,Input.GetAxis("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * movementSpeed;
        Vector3 moveAmount = velocity * Time.deltaTime;
        transform.Translate(moveAmount);
    }
}
