using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void openHome(){
        SceneManager.LoadScene("Home");
    }
    public void back(){
        SceneManager.LoadScene("GetStarted");
    }
    public void openCredits(){
        SceneManager.LoadScene("Credits");
    }
    public void openHowToUse(){
        SceneManager.LoadScene("HowToUse");
    }
    public void openGithub(){
        Application.OpenURL("https://github.com/Shrimad-Bhagwat/AR-GUIDE");
    }
    public void exit(){
        Debug.Log("Exit");
         Application.Quit();
    }
}
