using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    int clickNum = 0;

    public List<GameObject> image1 = new List<GameObject>();
    public List<GameObject> image2 = new List<GameObject>();
    public List<GameObject> image3 = new List<GameObject>();
    public List<GameObject> image4 = new List<GameObject>();
    public List<GameObject> image5 = new List<GameObject>();
    public List<GameObject> image6 = new List<GameObject>();

    
    public GameObject student;
    public GameObject scene_camera;
    void Start()
    {
        student = GameObject.Find("student");
        scene_camera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            clickNum++;
            ImageFlow();
        }
        
    }

    void ImageFlow(){
        switch(clickNum){
            case 1:
                ImageOff(image1);
                ImageOn(image2);
                break;
            case 2:
                ImageOff(image2);
                ImageOn(image3);
                break;
            case 3:
                ImageOff(image3);
                ImageOn(image4);
                break;
            case 4:
                ImageOff(image4);
                ImageOn(image5);
                break;
            case 5:
                ImageOff(image5);
                ImageOn(image6);
                break;
            case 6:
                LoadingScene.LoadScene("Start Scene");
                Destroy(scene_camera);
                Destroy(student);
                break;
            default:
                break;
                
        }
    }

    void ImageOn(List<GameObject> list){
        for(int i = 0;i<list.Count;i++){
            list[i].SetActive(true);
        }
    }

    void ImageOff(List<GameObject> list){
        for(int i = 0;i<list.Count;i++){
            list[i].SetActive(false);
        }
    }

}
