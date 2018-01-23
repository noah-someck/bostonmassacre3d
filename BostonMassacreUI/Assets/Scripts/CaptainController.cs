using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptainController : MonoBehaviour {

	public GameObject frontButton;
	public GameObject backButton;
	private bool toggleFront;
	private Color grayColor;
	private Color whiteColor;


	// Use this for initialization
	void Start () {
		toggleFront = false;
		whiteColor = Color.white;
		grayColor = Color.gray; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnFrontCLicked () {
		if (!toggleFront) {
			toggleFront = true;

			Button tempButton = frontButton.GetComponent<Button> ();
			ColorBlock colorBlock = tempButton.colors;
			colorBlock.normalColor = Color.gray;
			colorBlock.highlightedColor = Color.gray;
			frontButton.GetComponent<Button> ().colors = colorBlock;

			tempButton = backButton.GetComponent<Button> ();
			colorBlock = tempButton.colors;
			colorBlock.normalColor = Color.white;
			colorBlock.highlightedColor = Color.white;
			backButton.GetComponent<Button> ().colors = colorBlock;
		}
	}

	public void OnBehindCLicked () {
		if (toggleFront) {
			toggleFront = false;

			Button tempButton = backButton.GetComponent<Button> ();
			ColorBlock colorBlock = tempButton.colors;
			colorBlock.normalColor = Color.gray;
			colorBlock.highlightedColor = Color.gray;
			backButton.GetComponent<Button> ().colors = colorBlock;

			tempButton = frontButton.GetComponent<Button> ();
			colorBlock = tempButton.colors;
			colorBlock.normalColor = Color.white;
			colorBlock.highlightedColor = Color.white;
			frontButton.GetComponent<Button> ().colors = colorBlock;
		}
	}
}
