using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public GameObject data;
    public int i;
    bool check;

    public void LoadScene(){
        check = false;
        data = GameObject.Find("Data");
        Invoke("CheckSceneClear"+i.ToString(),0);
    }


    void CheckSceneClear4(){
        check = data.GetComponent<DataController>().gameData.isClear4;
        LoadIfTrue();
    }

    void CheckSceneClear5(){
        check = data.GetComponent<DataController>().gameData.isClear5;
        LoadIfTrue();
    }

    void CheckSceneClear6(){
        check = data.GetComponent<DataController>().gameData.isClear6;
        LoadIfTrue();
    }

    void CheckSceneClear7(){
        check = data.GetComponent<DataController>().gameData.isClear7;
        LoadIfTrue();
    }

    void LoadIfTrue(){
        if(check){
            Debug.Log("t");
            LoadingScene.LoadScene(i.ToString()+"F Scene");
        }
    }
}
