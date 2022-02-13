using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
    
    public void MenuGame(){
        SceneManager.LoadScene("Menu");
    }
}
