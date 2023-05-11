using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
public GameObject gameoverCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }
public void GameOver()
{
    gameoverCanvas.SetActive(true);
    Time.timeScale = 0 ;
}
    // Update is called once per frame
 public void Repaly ()
 {
    SceneManager.LoadScene(0); 
 }
}
