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
	private Color regularColor;


	// Use this for initialization
	void Start () {
		frontClicked = false;
		behindClicked = false;
		leftClicked = false;
		rightClicked = false;

		regularColor = frontButton.GetComponent<Image> ().color;
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

			frontButton.GetComponent<Image> ().color = Color.white;
			behindButton.GetComponent<Image> ().color = regularColor;
			leftButton.GetComponent<Image> ().color = regularColor;
			rightButton.GetComponent<Image> ().color = regularColor;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Front);
		}
	}

	public void OnBehindCLicked () {
		if (!behindClicked) {
			behindClicked = true;
			frontClicked = false;
			leftClicked = false;
			rightClicked = false;

			behindButton.GetComponent<Image> ().color = Color.white;
			frontButton.GetComponent<Image> ().color = regularColor;
			leftButton.GetComponent<Image> ().color = regularColor;
			rightButton.GetComponent<Image> ().color = regularColor;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Back);
		}
	}

	public void OnLeftClicked () {
		if (!leftClicked) {
			leftClicked = true;
			frontClicked = false;
			behindClicked = false;
			rightClicked = false;

			leftButton.GetComponent<Image> ().color = Color.white;
			frontButton.GetComponent<Image> ().color = regularColor;
			behindButton.GetComponent<Image> ().color = regularColor;
			rightButton.GetComponent<Image> ().color = regularColor;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Left);
		}
	}

	public void OnRightClicked () {
		if (!rightClicked) {
			rightClicked = true;
			frontClicked = false;
			behindClicked = false;
			leftClicked = false;

			rightButton.GetComponent<Image> ().color = Color.white;
			frontButton.GetComponent<Image> ().color = regularColor;
			behindButton.GetComponent<Image> ().color = regularColor;
			leftButton.GetComponent<Image> ().color = regularColor;

			CrowdVars.GetCrowdVars ().SetCaptainPosition (CrowdVars.POSITION.Right);
		}
	}

}
