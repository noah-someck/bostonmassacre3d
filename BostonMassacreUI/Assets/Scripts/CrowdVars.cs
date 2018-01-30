using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdVars : MonoBehaviour {

    private int crowdSize;
    private int captainPosition;
    private int crowdMood;
	public static int CAPTAIN_POSITION_FRONT = 1;
	public static int CAPTAIN_POSITION_BEHIND = 2;
	public static int MOOD_CALM = 1;
	public static int MOOD_AGITATED = 2;
	public static int MOOD_HOSTILE = 3;
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

	public void setCaptainPosition(int captainPosition) {
		this.captainPosition = captainPosition;
		Debug.Log (captainPosition);
	}

	public int getCaptainPosition() {
		return crowdVars.captainPosition;
	}

	public void setMood(int crowdMood) {
		this.crowdMood = crowdMood;
		Debug.Log (crowdMood);
	}

	public int getMood() {
		return crowdVars.crowdMood;
	}

	public void set(int crowdSize) {
		this.crowdSize = crowdSize;
		Debug.Log (crowdSize);
	}

	public int getCrowdSize() {
		return crowdVars.crowdSize;
	}
}
