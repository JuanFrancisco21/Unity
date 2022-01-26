using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;
    public GameObject transition;
    private void Update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected(){
        if (transform.childCount==0 && SceneManager.GetActiveScene().name!="Level2")
        {
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 2);
            Debug.Log(SceneManager.GetActiveScene().name);
        }
        else if (transform.childCount==0 && SceneManager.GetActiveScene().name=="Level2")
        {
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
        }
    }

    public void ChangeScene(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
