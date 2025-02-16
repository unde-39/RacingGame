using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObject : MonoBehaviour {
	public int greenSelect;
	public GameObject FakeGreen;
	public int pinkSelect;
	public GameObject FakePink;
	public int greySelect;
	public GameObject FakeGrey;
	void Start () {
		pinkSelect=PlayerPrefs.GetInt("PinkBought");
		if(pinkSelect==100){
			FakePink.SetActive(false);
		}
		greenSelect=PlayerPrefs.GetInt("GreenBought");
		if(greenSelect==300){
			FakeGreen.SetActive(false);
		}
		greySelect=PlayerPrefs.GetInt("GreyBought");
		if(greySelect==500){
			FakeGrey.SetActive(false);
		}
	}

}
