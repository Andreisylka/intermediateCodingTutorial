using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tutorial07 {
    public class Enemy : MonoBehaviour {
        //private float speed = Player.speed;
        public GameObject player;
    
    

        // Start is called before the first frame update
        void Start()
        {
            
        print($"enemy pos:{player.transform.position}");
        }

        // Update is called once per frame
        void Update()
        {
           // print($"enemy speed {speed}");
            /*
            Vector3 input ;
            Vector3 direction = input.normalized;
            Vector3 velocity = direction ;
            Vector3 moveAmount = velocity * Time.deltaTime;
            transform.position += moveAmount;
            */
        }
    }

}
