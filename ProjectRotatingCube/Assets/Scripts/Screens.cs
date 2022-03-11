using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screens : MonoBehaviour
{
    public GameObject expscreen;
    public GameObject endscreen;
  
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
