using System.Collections;
using System.Collections.Generic;
using Scenes.Tutorial13.Scripts;
using UnityEngine;

public class FallingBlockManagerController : MonoBehaviour
{
    
    public GameObject fallingBlock;
    private Vector2 ScreenSizeWorldUnits;
    public float speed = 5;
    public float fBRotationValueFactor = 5;
    public float fBScaleValueFactor = 1;

    public Vector2 SecondsBetweenSpawnMinMax;

    private float nextSpwntime;
    
    // Start is called before the first frame update
    void Start()
    {
        ScreenSizeWorldUnits = new Vector2(Camera.main.aspect*Camera.main.orthographicSize , Camera.main.orthographicSize);

        //print(ScreenSizeWorldUnits.y);
       
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-ScreenSizeWorldUnits.x, ScreenSizeWorldUnits.x) , ScreenSizeWorldUnits.y);
        float randomRotation = Random.Range(-fBRotationValueFactor, fBRotationValueFactor);
        float randomScale = Random.Range(fBScaleValueFactor / 2 , fBScaleValueFactor);
        if (Time.time > nextSpwntime)
        {
            float secondsBetweenSpawns = Mathf.Lerp(SecondsBetweenSpawnMinMax.y, SecondsBetweenSpawnMinMax.x,
                Dificullty.GetDificultyPercnt());
            nextSpwntime = Time.time + secondsBetweenSpawns;
            var block = Instantiate(fallingBlock, spawnPosition , Quaternion.Euler(0,0,randomRotation));
            block.transform.localScale = new Vector3(randomScale ,randomScale , randomScale);
            block.transform.parent = transform;
            
            Renderer material = block.GetComponent<Renderer>();
            material.material.color = Color.blue;
            
            //print(Mathf.Clamp01(Time.time / 60));
        }
       
      

      
       
    }


}
