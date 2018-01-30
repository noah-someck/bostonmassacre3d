using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdVars {

    private int crowdSize;
	public enum POSITION { Front, Back, Left, Right };
    private POSITION captainPosition;
	public enum MOOD { Calm, Agitated, Hostile };
	private MOOD crowdMood;
	private static CrowdVars crowdVars;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static CrowdVars getCrowdVars() {
		if (crowdVars == null) {
			crowdVars = new CrowdVars ();
		}
		return crowdVars;
	}

	public void setCaptainPosition(POSITION captainPosition) {
		this.captainPosition = captainPosition;
		Debug.Log (captainPosition);
	}

	public POSITION getCaptainPosition() {
		return crowdVars.captainPosition;
	}

	public void setMood(MOOD crowdMood) {
		this.crowdMood = crowdMood;
		Debug.Log (crowdMood);
	}

	public MOOD getMood() {
		return crowdVars.crowdMood;
	}

	public void setCrowdSize(int crowdSize) {
		this.crowdSize = crowdSize;
		//Debug.Log (crowdSize);
	}

	public int getCrowdSize() {
		return crowdVars.crowdSize;
	}
}
