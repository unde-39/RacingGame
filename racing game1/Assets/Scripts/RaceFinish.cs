using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RaceFinish : MonoBehaviour {
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;
    public GameObject LapTimeManager;
    float CarSpeed;
    public GameObject Result;

    void OnTriggerEnter() {
    if (ModeSelect.RaceMode==2) {
        // TIMEモードの場合
        if (LapComplete.succeed==1) {
            Result.GetComponent<Text>().text ="New Record!";
        }else{
            Result.GetComponent<Text>().text ="Failed";
        }
    } 
    if(ModeSelect.RaceMode==1){
        GlobalCash.TotalCash += ModeScore.CurrentScore;
    }
        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CompleteTrig.SetActive(false);
        CarSpeed = CarController.m_Topspeed;
        CarController.m_Topspeed = 0.0f;
        MyCar.GetComponent<CarController>().enabled = false;
        MyCar.GetComponent<CarUserControl>().enabled = false;
        MyCar.SetActive(true);
        LapTimeManager.SetActive(false);
        FinishCam.SetActive(true);
        LevelMusic.SetActive(false);
        ViewModes.SetActive(false);
        FinishMusic.Play();
        StartCoroutine(RaceEnd());
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
    
}

    IEnumerator RaceEnd() {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(4);
        CarController.m_Topspeed = CarSpeed;
        ModeScore.CurrentScore=0;
    }
}
