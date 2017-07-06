using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	// Use this for initialization
	void Awake() {
		DontDestroyOnLoad(gameObject);
		Debug.Log ("Do not destroy on Load: "  + name);
	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();

	}

	// Good Documentation on this It takes the level number and loads it.
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log ("Playing Clip: " + thisLevelMusic);
		if(thisLevelMusic){	// There is music attached
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	public void ChangeVolume(float volume){
		audioSource.volume = volume;
	}
}
