using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainController : MonoBehaviour {

	public GameObject frontButton;
	public GameObject backButton;
	private bool frontClicked;
	private bool behindClicked;
	private ColorBlock grayColors;
	private ColorBlock whiteColors;


	// Use this for initialization
	void Start () {
		frontClicked = false;
		behindClicked = false;

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

			frontButton.GetComponent<Button> ().colors = grayColors;
			backButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.getCrowdVars ().setCaptainPosition (CrowdVars.POSITION.Front);
		}
	}

	public void OnBehindCLicked () {
		if (!behindClicked) {
			behindClicked = true;
			frontClicked = false;

			backButton.GetComponent<Button> ().colors = grayColors;
			frontButton.GetComponent<Button> ().colors = whiteColors;

			CrowdVars.getCrowdVars ().setCaptainPosition (CrowdVars.POSITION.Back);
		}
	}


}
