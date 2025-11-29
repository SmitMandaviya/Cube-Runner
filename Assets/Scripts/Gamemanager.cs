using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
     bool game = false;
     public float gameend = 1f;
     public GameObject completelevelUI;

     public void Completelevel(){
          completelevelUI.SetActive(true);
     }
   public void Endgame ()
   {
    if(game == false)
    {
        game = true;
        Debug.Log("Game Over");
        Invoke("Restart",gameend);
    }
   }
   public void Restart()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
