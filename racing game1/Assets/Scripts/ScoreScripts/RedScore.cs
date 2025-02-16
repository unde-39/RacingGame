using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isCollected = false; // 既に獲得されたかどうかを判定

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        // すでに獲得されていたら処理しない
        if (isCollected) return;

        isCollected = true; // 獲得済みに設定
        ModeScore.CurrentScore += 5;
        audioSource.Play();
        StartCoroutine(DisableAfterSound());
    }

    IEnumerator DisableAfterSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        gameObject.SetActive(false);
    }
}
