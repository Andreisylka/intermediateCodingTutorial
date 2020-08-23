using UnityEngine;

namespace Scenes.Tutorial07.Scripts {
    public class SceneController : MonoBehaviour {
        [SerializeField] private Player playerPrefab;
        [SerializeField] private Enemy enemyPrefab;
        
        [SerializeField] private Player player;
        [SerializeField] private Enemy[] enemies;
       
        public const int ENEMIES_COUNT = 5;


    
        // Start is called before the first frame update
        void Start() {
            
            player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
            enemies = new Enemy[ENEMIES_COUNT];
            for (int i = 0; i < ENEMIES_COUNT; i++) {
                var newEnemyPosition = new Vector3(Random.Range(-5 , 5) , 0 , -2);
                enemies[i] = Instantiate(enemyPrefab, newEnemyPosition, Quaternion.identity);
                enemies[i].enemySpeed = Random.Range(2, 4);
               
            }
       
           player.Initialise(enemies);
           
           
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
