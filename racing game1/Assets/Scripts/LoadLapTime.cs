using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {
	public int MinCount;
	public int SecCount;
	public float MilliCount;
	public GameObject MinDisplay;//minの表示場所
	public GameObject SecDisplay;
	public GameObject MilliDisplay;

	void Update () {
		
		MinCount=PlayerPrefs.GetInt("MinSave");
		SecCount=PlayerPrefs.GetInt("SecSave");
		MilliCount=PlayerPrefs.GetFloat("MilliSave");
		MinDisplay.GetComponent<Text>().text=""+MinCount+":";
		SecDisplay.GetComponent<Text>().text=""+SecCount+".";
		MilliDisplay.GetComponent<Text>().text=""+MilliCount;
	}

}
