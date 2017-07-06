using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// This script will allow the user to have a fade in screen making the alpha go from black to clear.
public class Fadein : MonoBehaviour {

	public float fadeInTime;

	private Image fadePanel;
	private Color currentColor = Color.black;

	void Start(){
		fadePanel = GetComponent<Image>();
	}

	void Update(){
		if (Time.timeSinceLevelLoad < fadeInTime) {
			// Fade in
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		} else {
			gameObject.SetActive (false);
		}
	}
}