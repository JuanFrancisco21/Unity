using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{

    public void ReloadGame(){
        SceneManager.LoadScene("Level1");
        Debug.Log("mamalo");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
