using UnityEngine;

namespace Scenes.Tutorial07.Scripts {
    public class Player : MonoBehaviour {
        
        private Enemy[] _enemies;
       //[HideInInspector] 
       
        public  float speed = 10f;

        // Start is called before the first frame update
      
        public void Initialise(Enemy[] enemies) {
            _enemies = enemies;
        }

        // Update is called once per frame
        void Update() {
            
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Vector3 direction = input.normalized;
            Vector3 velocity = direction * speed;
            Vector3 moveAmount = velocity * Time.deltaTime;
            transform.position += moveAmount;
            
            if( _enemies == null) return;
                
            
            for (int i = 0; i < _enemies.Length; i++) {

                var displacementFromTarget = transform.position - _enemies[i].transform.position ;
                var directionToTarget = displacementFromTarget.normalized;
                var enemyvelocity = directionToTarget * _enemies[i].enemySpeed;
                var distanceToTarget = displacementFromTarget.magnitude;
                if (distanceToTarget > 1.5f) {
                    
                   _enemies[i].transform.Translate(enemyvelocity * Time.deltaTime);
                }
            }

        }
    }
}