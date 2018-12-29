using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Battlefield : MonoBehaviour {

    private int width = 5;
    private int length = 5;


    public Tilemap Tilemap;

    public Dictionary<Vector3, GameTile> tiles = new Dictionary<Vector3, GameTile>();
    public static Battlefield instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        GetWorldTiles();
    }

    private void GetWorldTiles()
    {
        tiles = new Dictionary<Vector3, GameTile>();
        foreach (Vector3Int pos in Tilemap.cellBounds.allPositionsWithin)
        {
            var localPlace = new Vector3Int(pos.x, pos.y, pos.z);

            if (!Tilemap.HasTile(localPlace)) continue;

            var tile = new GameTile
            {
                LocalPlace = localPlace,
                BoardPosition = Tilemap.CellToWorld(localPlace),
                Name = localPlace.x + "," + localPlace.y,
                Cost = 1 // TODO: Change this with the proper cost from ruletile
            };

            tiles.Add(tile.BoardPosition, tile);
        }
    }

    // Use this for initialization
    void Start () {
        // how to create a square grid with tiles
        //for (int x = 0; x < length; x++)
        //{
        //    for (int y = 0; y < width; y++)
        //    {
        //        GameTile t = new GameTile();
        //        t.position = new Vector2(x, y);

        //        tiles.Add(t.position, t);
        //    }
        //}

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
