using UnityEngine;
using System;
using UnityEditor;

namespace Scenes.Tutorial13.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 7;
        private  float ScreenBounds;
        public event System.Action OnPlayerDeatch ;
        
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            ScreenBounds = ScreenboundsHoriz();
    
            float direction = Input.GetAxisRaw("Horizontal");
            
            float velocity = direction*speed ;
            Vector2 translationVector = Vector2.right* (velocity * Time.deltaTime) ;
          transform.Translate(translationVector);
          screenHalfWidhInWorld();

          // float clampedPos = Mathf.Clamp(transform.position.x, -bounds, bounds);
          // Vector2 clampedTranslation = new Vector2(clampedPos, 0);
          // transform.position = clampedTranslation;

        }

        private void screenHalfWidhInWorld()
        {
            var _bounds = ScreenBounds;
            if (transform.position.x < -_bounds)
            {
                transform.position = new Vector2( _bounds , transform.position.y);
            }
            if (transform.position.x > _bounds)
            {
                transform.position = new Vector2(-_bounds , transform.position.y);
                
            }
        }

        public float ScreenboundsHoriz()
        {
            float HalfPlayerWidth = transform.localScale.x;
            float _screenBounds =  Camera.main.aspect * Camera.main.orthographicSize + HalfPlayerWidth;
            //print($"resolution is {_screenBounds}");

            return _screenBounds;
        }
        public float ScreenboundsVert(float screenBounds)
        {
            ScreenBounds = Camera.main.orthographicSize - screenBounds/2;
            return ScreenBounds;
        }
        public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "FallingBlock")
            {
                if (OnPlayerDeatch !=null) {
                    OnPlayerDeatch();
                }
               Destroy(gameObject);
                //EditorApplication.ExitPlaymode();
            }
           
        }
    }
}
