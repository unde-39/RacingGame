using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour {

	public GameObject pinkButton;
	public GameObject greenButton;
	public GameObject greyButton;

	public int cashValue;
	void Update () {
		cashValue=GlobalCash.TotalCash;
		if(cashValue>=100){
			pinkButton.GetComponent<Button>().interactable=true;
		}
		if(cashValue>=300){
			greenButton.GetComponent<Button>().interactable=true;
		}
		if(cashValue>=500){
			greyButton.GetComponent<Button>().interactable=true;
		}
	}
	public void PinkUnlock(){
		pinkButton.SetActive(false);
		cashValue -=100;
		GlobalCash.TotalCash-=100;
		PlayerPrefs.SetInt("SavedCash",GlobalCash.TotalCash);
		PlayerPrefs.SetInt("PinkBought",100);
	}
	public void GreenUnlock(){
		greenButton.SetActive(false);
		cashValue -=300;
		GlobalCash.TotalCash-=300;
		PlayerPrefs.SetInt("SavedCash",GlobalCash.TotalCash);
		PlayerPrefs.SetInt("GreenBought",300);
	}
	public void GreyUnlock(){
		greyButton.SetActive(false);
		cashValue -=500;
		GlobalCash.TotalCash-=500;
		PlayerPrefs.SetInt("SavedCash",GlobalCash.TotalCash);
		PlayerPrefs.SetInt("GreyBought",500);
	}
}
