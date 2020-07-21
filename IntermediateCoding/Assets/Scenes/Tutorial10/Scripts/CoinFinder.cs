using System;
using UnityEditor;
using UnityEngine;

namespace Scenes.Tutorial10.Scripts
{
    public class CoinFinder : MonoBehaviour
    {
        public Input playerSpeed;
        public int  border = 4;
        Rigidbody phisics;
        public MeshRenderer plane;
        private Bounds _targetBound;
        
        private void Start()
        {
            phisics = GetComponent<Rigidbody>();
           _targetBound =  GetBounds(plane);
           //Debug.Log(_targetBound.extents);
        }

       

        private void Update()
        {
           
            playerMovement();
        }

         void playerMovement()
        {
            Vector3 position = new Vector3(Input.GetAxisRaw("Horizontal") , 0 , Input.GetAxisRaw("Vertical"));
            Vector3 direction = position.normalized;
            Vector3 velocity = direction * 7f;
            Vector3 moveAmount = velocity * Time.deltaTime;
            transform.Translate(moveAmount);
            var clampedPosX = Mathf.Clamp(transform.position.x, -_targetBound.extents.x, _targetBound.extents.x);
            var clampedPosZ = Mathf.Clamp(transform.position.z, -_targetBound.extents.z, _targetBound.extents.z);
            var clapedPos = new  Vector3( clampedPosX , transform.position.y , clampedPosZ);
            transform.position = clapedPos;
        }

        Bounds  GetBounds(MeshRenderer target) {
            return target.bounds;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Coin")
            {
                Destroy(other.gameObject);
                print("You gather a coin!");
            }
            else
            {
                Destroy(this.gameObject);
                EditorApplication.isPlaying = false;
                
            }
        }
    }
}