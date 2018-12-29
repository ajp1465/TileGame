using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public bool selected = false;
    private Battlefield board = Battlefield.instance;
    private Vector3 position;
    private Vector2 mousePosition;

	// Use this for initialization
	void Start () {
        position = transform.position;
    }
	
	// Update is called once per frame
	void Update() {

        

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition = new Vector2(point.x, point.y);
            if (mousePosition != (Vector2)position)
            {
                Move();
            }
        }
    }

    public void GetNeighbors()
    {
        //gets neighboring tiles 

    }


    public void Move()
    {
        position = Camera.main.ScreenToWorldPoint((Vector2)Input.mousePosition);
        Debug.Log("Position: " + Input.mousePosition.ToString());
        Debug.Log("MousePosition: " + mousePosition.ToString());
        transform.position = new Vector3( position.x, position.y, 1 );
    }
}
