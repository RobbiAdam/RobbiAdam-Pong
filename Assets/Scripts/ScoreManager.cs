using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    // Start is called before the first frame update
   public void AddRightScore(int increment)
   {
    rightScore += increment;
    if(rightScore == maxScore)
    {
        GameOver();
    }

   }

   public void AddLeftScore(int increment)
   {
    leftScore+= increment;
    if(leftScore == maxScore)
    {
        GameOver();
    }

   }

   public void GameOver()
   {
    SceneManager.LoadScene("Main Menu");

   }
}
