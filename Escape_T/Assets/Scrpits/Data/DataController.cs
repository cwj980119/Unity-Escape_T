using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

public class DataController : MonoBehaviour
{
    // ---Singleton--- 
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }
    static DataController _instance; 
    public static DataController Instance 
    { 
        get 
        { 
            if (!_instance) 
            { 
                _container = new GameObject();
                _container.name = "DataController"; 
                _instance = _container.AddComponent(typeof(DataController)) as DataController; 
                DontDestroyOnLoad(_container); 
            } 
            return _instance; 
        } 
    } 
    
    // --- File Name ---
    public string GameDataFileName = "Escape_T.json"; 
    
    public GameData _gameData; 
    public GameData gameData 
    {
        get 
        { 
            if(_gameData == null)
            { 
                LoadGameData(); 
                SaveGameData();
            }
            return _gameData;
        }
    } 
    
    private void Start() 
    {
        LoadGameData(); 
        SaveGameData();
    } 
    
    // Data Load
    public void LoadGameData() 
    {
        string filePath = Application.persistentDataPath + GameDataFileName;
        
        // ����� ������ �ִٸ�
        if (File.Exists(filePath))
        { 
            print("Load Success"); 
            string FromJsonData = File.ReadAllText(filePath); 
            _gameData = JsonUtility.FromJson<GameData>(FromJsonData);
        }
        
        // ����� ������ ���ٸ�
        else 
        { 
            print("Create New File");            
            _gameData = new GameData();
        } 
    } 
    
    // Data Save
    public void SaveGameData() 
    { 
        string ToJsonData = JsonUtility.ToJson(gameData); 
        string filePath = Application.persistentDataPath + GameDataFileName; 

        // File Overwrite
        File.WriteAllText(filePath, ToJsonData);
        
        // Log Test)
        print("Save"); 
        print("4F Clear " + gameData.isClear4); 
        print("5F Clear " + gameData.isClear5); 
        print("6F Clear " + gameData.isClear6);
        print("7F Clear " + gameData.isClear7); 
    } 
    
    // AutoSave(quitGame)
    private void OnApplicationQuit()
    { 
        SaveGameData(); 
    } 

    public string val = "test";

    public void call()
    {
        FieldInfo fld = typeof(DataController).GetField("val");
        Debug.Log(fld.ToString());
        val = "hi";
        Debug.Log("HI");
        Debug.Log(fld);
    }

    // public bool CheckClear(string sceneNumber){
    //     return gameData. + sceneNumber;
    // }
} 