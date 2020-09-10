using System.Collections;
using System.Collections.Generic;
using  System;
using Scenes.Tutorial13.Scripts;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class FallingBlock : MonoBehaviour
{
    //private float speed;

    public GameObject player;

    float screenBounds;

    public Vector2 speedMinMax;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        var player = FindObjectOfType<PlayerController>();
        if (player!=null) {
            screenBounds = player.ScreenboundsVert(transform.localScale.y);
        }
        
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Dificullty.GetDificultyPercnt());
        //print($" every time on start : {speed}");

    }

    // Update is called once per frame
      void Update()
        {
            // speed = Random.Range(1, controllerSpeed.speed);
            //FallingBlockManagerController controllerSpeed =
             //   this.transform.parent.gameObject.GetComponent<FallingBlockManagerController>();

            Vector2 direction = Vector2.down.normalized;
            transform.Translate(direction * speed * Time.deltaTime);
            if (transform.position.y < -screenBounds)
            {
                Destroy(gameObject);
            }
//print(player);

        }


    }

    



