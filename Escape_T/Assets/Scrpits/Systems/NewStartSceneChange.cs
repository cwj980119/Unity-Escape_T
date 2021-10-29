using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStartSceneChange : MonoBehaviour
{
    public string SceneName;
    private GameObject player;
    private GameObject main_camera;
    public GameObject Music;

    public void LoadNewGame()
    {
        LoadingScene.LoadScene(SceneName);
        if(SceneName=="Start Scene")
        {
            GameObject.Find("SettingCanvas").transform.Find("Setting").transform.GetChild(5).gameObject.SetActive(false);
            player = GameObject.Find("student");
            main_camera = GameObject.Find("Main Camera");
            Destroy(player);
            Destroy(main_camera);
            Music = GameObject.Find("Music");
            Music.GetComponent<AudioController>().InGameSoundOff();
            Music.GetComponent<AudioController>().MainSoundOn();
        }

        else
        {
            Music = GameObject.Find("Music");
            Music.GetComponent<AudioController>().InGameSoundOn();
            Music.GetComponent<AudioController>().MainSoundOff();
        }
    }
}
