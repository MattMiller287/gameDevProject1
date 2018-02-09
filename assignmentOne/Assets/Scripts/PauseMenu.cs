using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				ResumeGame ();
			} else {
				PauseGame ();
			}
		}
	}

	public void ResumeGame()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void PauseGame()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void QuitGame()
	{
		Debug.Log ("Quit!");
		Application.Quit ();
	}
}
