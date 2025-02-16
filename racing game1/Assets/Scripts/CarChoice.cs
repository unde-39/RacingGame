using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {
	//1=Red,2=Blue,3=Green,4=Pink,5=Grey,6=Yellow
	public GameObject RedBody;
	public GameObject BlueBody;
	public GameObject GreenBody;
	public GameObject PinkBody;
	public GameObject GreyBody;
	public GameObject YellowBody;
	public int CarImport;
	void Start () {
		CarImport=GlobalCar.CarType;
		if(CarImport==1){
			RedBody.SetActive(true);
		}

		if(CarImport==2){
			BlueBody.SetActive(true);
		}
		if(CarImport==3){
			GreenBody.SetActive(true);
		}

		if(CarImport==4){
			PinkBody.SetActive(true);
		}
		if(CarImport==5){
			GreyBody.SetActive(true);
		}

		if(CarImport==6){
			YellowBody.SetActive(true);
		}
	}
	
}
