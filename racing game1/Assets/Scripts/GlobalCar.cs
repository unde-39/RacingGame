using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {
	public static int CarType;//1=Red,2=Blue,3=Green,4=Pink,5=Grey,6=Yellow
	public GameObject TrackWindow;

	public void RedCar(){
		CarType=1;
		TrackWindow.SetActive(true);
	}
	public void BlueCar(){
		CarType=2;
		TrackWindow.SetActive(true);
	}
	public void GreenCar(){
		CarType=3;
		TrackWindow.SetActive(true);
	}
	public void PinkCar(){
		CarType=4;
		TrackWindow.SetActive(true);
	}
	public void GreyCar(){
		CarType=5;
		TrackWindow.SetActive(true);
	}
	public void YellowCar(){
		CarType=6;
		TrackWindow.SetActive(true);
	}
}
