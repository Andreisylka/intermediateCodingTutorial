using System;
using UnityEngine;

namespace Scenes.Tutorial10.Scripts
{
    public class CoinFinder : MonoBehaviour
    {
        public Input playerSpeed;
        public int  border = 4;
        Rigidbody phisics;
        public GameObject plane;
        
        private void Start()
        {
            phisics = GetComponent<Rigidbody>();
            

        }

       

        private void Update()
        {
            Bounds();
            playerMovement();
        }

         void playerMovement()
        {
            Vector3 position = new Vector3(Input.GetAxisRaw("Horizontal") , 0 , Input.GetAxisRaw("Vertical"));
            Vector3 direction = position.normalized;
            Vector3 velocity = direction * 7f;
            Vector3 moveAmount = velocity * Time.deltaTime;
            transform.Translate(moveAmount);
        }

        void Bounds()
        {
            if ((int)transform.position.x > border)
            {
                transform.position =new Vector3(border , transform.position.y , transform.position.z); ;
            }
            else if ((int)transform.position.x < -border)
            {
                transform.position = new Vector3(-border , transform.position.y , transform.position.z);;

            }
            else if ((int)transform.position.z > border)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y , border);;

            }
            else if ((int)transform.position.z < -border)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y , -border);;

            }
        }
    }
}