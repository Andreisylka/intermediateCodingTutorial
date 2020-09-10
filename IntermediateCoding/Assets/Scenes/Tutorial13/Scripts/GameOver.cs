using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Scenes.Tutorial13.Scripts;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Text ScoreTime;
    private bool Gameover;

     void Start() {
         FindObjectOfType<PlayerController>().OnPlayerDeatch += OnGameOver;
     }

    // Update is called once per frame
    void Update() {
        
       
        if (Gameover)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
             
            }
         

            
        }
      

    }
      void OnGameOver()
    {
        gameOverCanvas.gameObject.SetActive(true);
        ScoreTime.text = Mathf.Round(Time.timeSinceLevelLoad).ToString();
        Gameover = true;
    }
}
