using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject[,] grid = new GameObject[9, 9];
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            PlaceMines();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaceMines()
    {
        int x = UnityEngine.Random.Range(0, 9);
        int y = UnityEngine.Random.Range(0, 9);

        if (grid[x, y] == null)
        {
            GameObject mineTile = Instantiate(Resources.Load("Prefab/Mine", typeof(GameObject)), new Vector3(x, y, 0), Quaternion.identity) as GameObject;
            grid[x, y] = mineTile;
            Debug.Log("(" + x + "," + y + ")");
;        }

        else
        {
            PlaceMines();
        }
    }
}
