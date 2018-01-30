using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

    public GameObject crowdSlider;
    public GameObject currentDisplay;
    //public GameObject CrowdVars;
    public int increment;

	// Use this for initialization
	void Start () {
        crowdSlider.GetComponent<Slider>().value = 10;
        currentDisplay.GetComponent<Text>().text = "10";
	}
	
	// Update is called once per frame
	void Update () {
        int val = (int)crowdSlider.GetComponent<Slider>().value * increment;
        currentDisplay.GetComponent<Text>().text = val.ToString();
        //CrowdVars.GetComponent<CrowdVars>().setCrowdSize(val);
	}

    void ButtonClick() {
        int x = 0;
    }
}
