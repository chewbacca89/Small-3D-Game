using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	public float timeTillNextLevel = 0.0f;
	// Update is called once per frame
	void Update () {
		//Get to the next scene by pressing the space bar
		/*if(Input.GetKeyDown(KeyCode.Space)){
			LoadNextScene ();
		}*/
		if(timeTillNextLevel > 0)
		{
			timeTillNextLevel -= Time.deltaTime;
			print ("Time till next Level:" + timeTillNextLevel);
			if (timeTillNextLevel < 0) 
			{
				LoadNextScene();	
			}
		}
	}

	public void LoadNextScene(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousScene(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}

	public void doExitGame(){
		Application.Quit();
	}
}
