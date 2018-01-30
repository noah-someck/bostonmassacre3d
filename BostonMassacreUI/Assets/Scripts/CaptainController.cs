using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainController : MonoBehaviour {

	public GameObject frontButton;
	public GameObject behindButton;
	public GameObject leftButton;
	public GameObject rightButton;
	private bool frontClicked;
	private bool behindClicked;
	private bool leftClicked;
	private bool rightClicked;
	private ColorBlock grayColors;
	private ColorBlock whiteColors;


	// Use this for initialization
	void Start () {
		frontClicked = false;
		behindClicked = false;
		leftClicked = false;
		rightClicked = false;

		ColorBlock colorBlock = frontButton.GetComponent<Button> ().colors;
		colorBlock.normalColor = Color.white;
		whiteColors = colorBlock;

		colorBlock.normalColor = Color.gray;
		colorBlock.highlightedColor = Color.gray;
		grayColors = colorBlock;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFrontCLicked () {
		if (!frontClicked) {
			frontClicked = true;
			behindClicked = false;
			leftClicked = false;
			rightClicked = false;

			frontButton.GetComponent<Button> ().colors = grayColors;
			behindButton.GetComponent<Button> ().colors = whiteColors;
			leftButton.GetComponent<Button> ().colors = whiteColors;
			rightButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Front);
		}
	}

	public void OnBehindCLicked () {
		if (!behindClicked) {
			behindClicked = true;
			frontClicked = false;
			leftClicked = false;
			rightClicked = false;

			behindButton.GetComponent<Button> ().colors = grayColors;
			frontButton.GetComponent<Button> ().colors = whiteColors;
			leftButton.GetComponent<Button> ().colors = whiteColors;
			rightButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Back);
		}
	}

	public void OnLeftClicked () {
		if (!leftClicked) {
			leftClicked = true;
			frontClicked = false;
			behindClicked = false;
			rightClicked = false;

			leftButton.GetComponent<Button> ().colors = grayColors;
			frontButton.GetComponent<Button> ().colors = whiteColors;
			behindButton.GetComponent<Button> ().colors = whiteColors;
			rightButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Left);
		}
	}

	public void OnRightClicked () {
		if (!rightClicked) {
			rightClicked = true;
			frontClicked = false;
			behindClicked = false;
			leftClicked = false;

			rightButton.GetComponent<Button> ().colors = grayColors;
			frontButton.GetComponent<Button> ().colors = whiteColors;
			behindButton.GetComponent<Button> ().colors = whiteColors;
			leftButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Right);
		}
	}

}
