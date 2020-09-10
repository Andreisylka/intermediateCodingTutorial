using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Text ScoreTime;
    private bool Gameover;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Gameover)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }

            
        }
    }
    public  void OnGameOver()
    {
        gameOverCanvas.gameObject.SetActive(false);
        ScoreTime.text = Time.time.ToString();
        Gameover = true;
    }
}
