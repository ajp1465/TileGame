using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile{

    public Vector3 LocalPlace;
    public Vector2 BoardPosition;
    public string Name;
    public int Cost;

 	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
                //LocalPlace = localPlace,
                //BoardLocation = Tilemap.CellToWorld(localPlace),
                //TileBase = Tilemap.GetTile(localPlace),
                //TilemapMember = Tilemap,
                //Name = localPlace.x + "," + localPlace.y,
                //Cost = 1 // TODO: Change this with the proper cost from ruletile