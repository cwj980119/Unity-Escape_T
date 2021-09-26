using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Tile[,] grid = new Tile[9, 9];
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            PlaceMines();
        }

        PlaceClues();

        PlaceBlanks();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            int x = Mathf.RoundToInt(mousePosition.x);
            int y = Mathf.RoundToInt(mousePosition.y);

            Tile tile = grid[x, y];

            tile.SetIsCovered(false);
        }
    }

    void PlaceMines()
    {
        int x = UnityEngine.Random.Range(0, 9);
        int y = UnityEngine.Random.Range(0, 9);

        if (grid[x, y] == null)
        {
            Tile mineTile = Instantiate(Resources.Load("Prefab/Mine", typeof(Tile)), new Vector3(x, y, 0), Quaternion.identity) as Tile;
            grid[x, y] = mineTile;
            Debug.Log("(" + x + "," + y + ")");
;        }

        else
        {
            PlaceMines();
        }
    }

    void PlaceClues()
    {
        for(int y=0; y<9;y++)
        {
            for(int x=0;x<9;x++)
            {
                if(grid[x,y]==null)
                {
                    int numMines = 0;
                    
                    //ºÏ
                    if (y + 1 < 9)
                    {
                        if (grid[x, y + 1] != null && grid[x, y+1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //µ¿
                    if(x+1<9)
                    {
                        if(grid[x+1,y]!=null && grid[x+1, y].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //³²
                    if(y-1>=0)
                    {
                        if(grid[x,y-1]!=null && grid[x, y - 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //µ¿
                    if(x-1>=0)
                    {
                        if(grid[x-1,y]!=null && grid[x-1, y].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //ºÏµ¿
                    if(x+1<9 && y+1<9)
                    {
                        if(grid[x+1,y+1]!=null && grid[x+1, y + 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //ºÏ¼­
                    if(x-1>=0 && y+1<9)
                    {
                        if(grid[x-1,y+1]!=null && grid[x-1, y + 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //³²µ¿
                    if(x+1<9 && y-1>=0)
                    {
                        if(grid[x+1,y-1]!=null && grid[x+1, y - 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //³²¼­
                    if(x-1>=0 && y-1>=0)
                    {
                        if(grid[x-1,y-1]!=null && grid[x-1, y - 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    if(numMines>0)
                    {
                        Tile clueTile = Instantiate(Resources.Load("Prefab/" + numMines, typeof(Tile)), new Vector3(x, y, 0), Quaternion.identity) as Tile;

                        grid[x, y] = clueTile;
                    }
                }
            }
        }
    }

    void PlaceBlanks()
    {
        for(int y=0;y<9;y++)
        {
            for(int x=0;x<9;x++)
            {
                if(grid[x,y]==null)
                {
                    Tile blankTile = Instantiate(Resources.Load("Prefab/blank", typeof(Tile)), new Vector3(x, y, 0), Quaternion.identity) as Tile;

                    grid[x, y] = blankTile;
                }
            }
        }
    }
}
