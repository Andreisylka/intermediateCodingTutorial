﻿using UnityEditor;
using UnityEngine;

namespace Scenes.Tutorial12.Scripts
{
    public class GameUi : MonoBehaviour
    {
        private PlayerHealth player;
    
        // private int _playerHealth;
        // Start is called before the first frame update
        void Start()
        {
            // player = GameObject.FindGameObjectWithTag("Player");
            // Debug.Log(_playerHealth);
            player = FindObjectOfType<PlayerHealth>();
            player.OnPlayerDeath += GameOver;

        }

        // Update is called once per frame
        void Update()
        {

        
       
        
        

           
        }

        public void GameOver()
        {
            print("Game over");
            EditorApplication.isPlaying = false;

        }
    }
}
