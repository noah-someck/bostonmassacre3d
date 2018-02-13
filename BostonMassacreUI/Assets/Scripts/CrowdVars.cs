using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdVars {

    private int crowdSize;
	public enum POSITION { Front = 0, Back = 1, Left = 2, Right = 3 };
    private POSITION captainPosition;
	public enum MOOD { Calm = 0, Agitated = 1, Hostile = 2 };
	private MOOD crowdMood;
	private static CrowdVars crowdVars;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static CrowdVars GetCrowdVars() {
		if (crowdVars == null) {
			crowdVars = new CrowdVars ();
		}
		return crowdVars;
	}

	public void SetCaptainPosition(POSITION captainPosition) {
		this.captainPosition = captainPosition;
	}

	public POSITION GetCaptainPosition() {
		return crowdVars.captainPosition;
	}

	public void SetMood(MOOD crowdMood) {
		this.crowdMood = crowdMood;
	}

	public MOOD GetMood() {
		return crowdVars.crowdMood;
	}

	public void SetCrowdSize(int crowdSize) {
		this.crowdSize = crowdSize;
	}

	public int GetCrowdSize() {
		return crowdVars.crowdSize;
	}
}
