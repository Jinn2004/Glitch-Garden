using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	// This will be for the splash screen that will load after 2.9 secs
	void Start(){
		if (autoLoadNextLevelAfter == 0) {
			Debug.Log ("Level auto Load Disabled.");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string Levelname){
		Debug.Log ("Level load requested for " + Levelname);
		Application.LoadLevel (Levelname);
	}

	public void QuitLevel(string Levelname){
		Debug.Log ("We have called quit level" + Levelname);
		Application.Quit ();
	}

	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
