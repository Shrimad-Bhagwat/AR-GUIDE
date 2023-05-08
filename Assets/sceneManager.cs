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
}
