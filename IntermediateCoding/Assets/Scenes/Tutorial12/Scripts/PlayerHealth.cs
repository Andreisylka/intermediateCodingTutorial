﻿using System;
using UnityEngine;

namespace Scenes.Tutorial12.Scripts
{
    public class PlayerHealth : MonoBehaviour
    {
        public int health =100;

        public event Action OnPlayerDeath;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            health = health - (int)Time.time;
            PlayerDeath();
//print($"health is {health}");
        }

        void PlayerDeath()
        {
            if (health<=0)
            {
                if (OnPlayerDeath!=null)
                {
                    OnPlayerDeath();

                }
            }
        }
    }
}
