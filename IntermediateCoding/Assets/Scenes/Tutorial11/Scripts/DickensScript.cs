using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DickensScript : MonoBehaviour
{
    public GameObject dickPrefab;

    private int childCount;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomTransform = new Vector3(Random.Range(-10 , +10), transform.position.y , Random.Range(-10 , 10));
            var _instantiate = Instantiate(dickPrefab ,randomTransform , transform.rotation);
            _instantiate.transform.parent = transform;
            childCount = transform.childCount;
            for (int i = childCount-1; i < childCount; i++)
            {
                var child = transform.GetChild(i);
                child.name = dickPrefab.name + "_"+ i;
                //print(child.tag);
            }
            print("one more Dick in da base");
        }
    }
}
