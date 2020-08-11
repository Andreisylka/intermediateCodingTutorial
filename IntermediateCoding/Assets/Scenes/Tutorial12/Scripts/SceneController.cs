using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject[] sceneObjects;

    // Start is called before the first frame update
    void Start()
    {
       //var obj = Instantiate(sceneObjects[0]);
       //obj.transform.parent = transform;
        initialise();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initialise()
    {
        foreach (var obj in sceneObjects)
        {
            var child = Instantiate(obj);
            child.transform.SetParent(transform);
        }
    }
}
