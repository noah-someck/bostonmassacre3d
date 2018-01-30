using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodController : MonoBehaviour {

	public GameObject calmButton;
	public GameObject agitatedButton;
	public GameObject hostileButton;
	private bool calmClicked;
	private bool agitatedClicked;
	private bool hostileClicked;
	private ColorBlock grayColors;
	private ColorBlock whiteColors;

	// Use this for initialization
	void Start () {
		calmClicked = false;
		agitatedClicked = false;
		hostileClicked = false;

		ColorBlock colorBlock = hostileButton.GetComponent<Button> ().colors;
		colorBlock.normalColor = Color.white;
		whiteColors = colorBlock;

		colorBlock.normalColor = Color.gray;
		colorBlock.highlightedColor = Color.gray;
		grayColors = colorBlock;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onCalmClicked () {
		if (!calmClicked) {
			calmClicked = true;
			agitatedClicked = false;
			hostileClicked = false;

			calmButton.GetComponent<Button> ().colors = grayColors;
			agitatedButton.GetComponent<Button> ().colors = whiteColors;
			hostileButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.getCrowdVars ().setMood (CrowdVars.MOOD.Calm);
		}
	}

	public void onAgitatedClicked () {
		if (!agitatedClicked) {
			agitatedClicked = true;
			calmClicked = false;
			hostileClicked = false;

			agitatedButton.GetComponent<Button> ().colors = grayColors;
			calmButton.GetComponent<Button> ().colors = whiteColors;
			hostileButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.getCrowdVars ().setMood (CrowdVars.MOOD.Agitated);
		}
	}

	public void onHostileClicked () {
		if (!hostileClicked) {
			hostileClicked = true;
			calmClicked = false;
			agitatedClicked = false;

			hostileButton.GetComponent<Button> ().colors = grayColors;
			calmButton.GetComponent<Button> ().colors = whiteColors;
			agitatedButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.getCrowdVars ().setMood (CrowdVars.MOOD.Hostile);
		}
	}
}
