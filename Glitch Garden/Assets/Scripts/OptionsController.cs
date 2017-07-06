using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider DifficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		//Debug.LogError (musicManager);
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		// Should get what it is and send it to the rest of the game.
		DifficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);

	}

	public void SetDefaults(){
		DifficultySlider.value = 2f;
		volumeSlider.value = 0.5f;
	}

	public void Save (){
		// Set volume
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		// Set difficulty
		PlayerPrefsManager.SetDifficulty (DifficultySlider.value);
		//PlayerPrefsManager.SetDifficulty (DifficultySlider.value);
		levelManager.LoadLevel("Start");
	}
}
