﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour {

	void Start () {
		StartCoroutine(CreditEnd());
	}
	IEnumerator CreditEnd(){
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(0);
	}
}
