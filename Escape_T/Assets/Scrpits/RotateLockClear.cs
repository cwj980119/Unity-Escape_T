using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLockClear : MonoBehaviour
{
    public List<RotateLock> list;
    [SerializeField]
    GameObject clear;
    public GameObject door;

    private void Update() {
        if(Check()){
            Correct();
        }
    }

    private bool Check(){
        for(int i=0;i<list.Count;i++){
            if(!list[i].Check()){
                return false;
            }
        }
        return true;
    }

    private void Correct(){
        clear.SetActive(false);
        door.SetActive(false);
        gameObject.SetActive(false);
    }
}
