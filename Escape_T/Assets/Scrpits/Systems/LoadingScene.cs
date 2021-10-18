using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    static string nextScene;
    [SerializeField]
    Slider slider;
    Image progressBar;
    private float time;

    public static void LoadScene(string sceneName){
        nextScene = sceneName;
        SceneManager.LoadScene("Loading Scene");
    }

    private void Start() {
        StartCoroutine(LoadSceneProcess());
    }

    IEnumerator LoadSceneProcess(){
        AsyncOperation operation = SceneManager.LoadSceneAsync(nextScene);

        operation.allowSceneActivation = false;

        

        while (!operation.isDone) {

            time = 0f;
            time += Time.time;

            slider.value = time / 3f;

            if(time > 3) {
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
        // AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        // op.allowSceneActivation = false;

        // float timer = 0f;
        // while (!op.isDone)
        // {
        //      yield return null;

        //      if(op.progress < 0.9f){
        //         progressBar.fillAmount = op.progress;
        //      }
        //      else{
        //         timer += Time.unscaledDeltaTime;
        //         progressBar.fillAmount = Mathf.Lerp(0.1f,1f,timer);
        //         if(progressBar.fillAmount >= 1f){
        //             op.allowSceneActivation = true;
        //             yield break;
        //         }
        //      }
        // }
    }

}
