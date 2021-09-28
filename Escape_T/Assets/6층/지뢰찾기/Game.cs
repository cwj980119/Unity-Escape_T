using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Tile[,] grid = new Tile[9, 9];

    public List<Tile> tilesToCheck = new List<Tile>();

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

            if(tile.tileState==Tile.TileState.Normal)
            {
                if(tile.isCovered)
                {
                    if(tile.tileKind==Tile.TileKind.Mine)
                    {
                        GameOver(tile);
                    }

                    else
                    {
                        tile.SetIsCovered(false);
                    }

                    if (tile.tileKind == Tile.TileKind.Blank)
                    {
                        RevealTileAt(x, y);
                    }
                }
            }
        }
    }

    private void GameOver(Tile tile)
    {
        tile.SetClickedMine();

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Mine");

        foreach(GameObject go in gameObjects)
        {
            Tile t = go.GetComponent<Tile>();

            if(t != tile)
            {
                if(t.tileState==Tile.TileState.Normal)
                {
                    t.SetIsCovered(false);
                }
            }
        }

        for (int y=0; y<9;y++)
        {
            for(int x=0; x<9; x++)
            {
                Tile t = grid[x, y];

                if(t.tileState==Tile.TileState.Flag)
                {
                    if(t.tileKind!=Tile.TileKind.Mine)
                    {

                        t.SetNotAMineFlag();
                    }
                }
            }
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
                    
                    //合
                    if (y + 1 < 9)
                    {
                        if (grid[x, y + 1] != null && grid[x, y+1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //悼
                    if(x+1<9)
                    {
                        if(grid[x+1,y]!=null && grid[x+1, y].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //巢
                    if(y-1>=0)
                    {
                        if(grid[x,y-1]!=null && grid[x, y - 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //悼
                    if(x-1>=0)
                    {
                        if(grid[x-1,y]!=null && grid[x-1, y].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //合悼
                    if(x+1<9 && y+1<9)
                    {
                        if(grid[x+1,y+1]!=null && grid[x+1, y + 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //合辑
                    if(x-1>=0 && y+1<9)
                    {
                        if(grid[x-1,y+1]!=null && grid[x-1, y + 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //巢悼
                    if(x+1<9 && y-1>=0)
                    {
                        if(grid[x+1,y-1]!=null && grid[x+1, y - 1].tileKind == Tile.TileKind.Mine)
                        {
                            numMines++;
                        }
                    }

                    //巢辑
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

    void RevealTileAt(int x, int y)
    {
        //合率
        if((y+1)<9)
        {
            CheckTileAt(x, y+1);

        }

        //悼率
        if((x+1)<9)
        {
            CheckTileAt(x+1, y);
        }

        //巢率
        if((y-1)>=0)
        {
            CheckTileAt(x, y-1);
        }

        //辑率
        if((x-1)>=0)
        {
            CheckTileAt(x-1, y);
        }

        //合悼率
        if((y+1)<9&&(x+1)<9)
        {
            CheckTileAt(x+1, y+1);
        }

        //合辑率
        if((y+1)<9&&(x-1)>=0)
        {
            CheckTileAt(x - 1, y + 1);
        }

        //巢悼率
        if((y-1)>=0&&(x+1)<9)
        {
            CheckTileAt(x + 1, y - 1);
        }

        //巢辑率
        if((y-1)>=0&&(x-1)>=0)
        {
            CheckTileAt(x - 1, y - 1);
        }

        for (int i=tilesToCheck.Count-1; i >= 0;i--)
        {
            if(tilesToCheck[i].didCheck)
            {
                tilesToCheck.RemoveAt(i);
            }
        }

        if(tilesToCheck.Count>0)
        {
            RevealTileForTile();
        }
    }

    private void RevealTileForTile()
    {
        for(int i=0;i<tilesToCheck.Count;i++)
        {
            Tile tile = tilesToCheck[i];

            int x = (int)tile.gameObject.transform.localPosition.x;
            int y = (int)tile.gameObject.transform.localPosition.y;

            tile.didCheck = true;

            if(tile.tileState!=Tile.TileState.Flag)
            {
                tile.SetIsCovered(false);
            }
            RevealTileAt(x, y);
        }
    }

    private void CheckTileAt(int x, int y)
    {
        Tile tile = grid[x, y];

        if(tile.tileKind==Tile.TileKind.Blank)
        {
            tilesToCheck.Add(tile);
            Debug.Log("blank");
        }

        else if(tile.tileKind==Tile.TileKind.Clue)
        {
            tile.SetIsCovered(false);
            Debug.Log("clue");
        }

        else if(tile.tileKind==Tile.TileKind.Mine)
        {
            Debug.Log("mine");
        }
    }
}
