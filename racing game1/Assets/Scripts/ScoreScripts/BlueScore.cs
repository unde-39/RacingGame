using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour {
	private AudioSource audioSource;
	private bool isCollected = false; // 既に獲得されたかどうかを判定
	void Start(){
        audioSource = GetComponent<AudioSource>();
    }
	void OnTriggerEnter(){
		if (isCollected) return;

        isCollected = true; 
		audioSource.Play();
        StartCoroutine(DisableAfterSound());
		ModeScore.CurrentScore+=3;
	}
	IEnumerator DisableAfterSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length/2);
        gameObject.SetActive(false);
    }
}
