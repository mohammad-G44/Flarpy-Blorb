using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore=0;
    public Text scoreT;
    public GameObject gameOverScreen;
    [ContextMenu("Increase number")]
    public void addScore()
    {
        
      playerScore= playerScore+1;
        scoreT.text=playerScore.ToString(); 
    }
    public void restartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
