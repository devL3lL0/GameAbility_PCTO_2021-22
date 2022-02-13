using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public void PlayAgainTastiera(){
		SceneManager.LoadScene("Game");
	}   

	public void PlayAgainLeap(){
		SceneManager.LoadScene("GameLeapDx");
	}

	public void MenuGame(){
		SceneManager.LoadScene("Menu");
	}
}
