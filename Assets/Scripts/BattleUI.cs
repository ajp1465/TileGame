using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour {

    public Text HitText;
	// Use this for initialization
	void Start () {
        HitText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        updateHitText();
	}

    public void updateHitText()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            //RaycastHit hitInfo = new RaycastHit();
            //bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            //RaycastHit2D hit = Physics2D.Raycast(new Vector2(Input.mousePosition.x, Input.mousePosition.y), -Vector2.up);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                HitText.text = ("Hit");
                HitText.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               
            }
            else
            {
                HitText.text = ("No Hit");
                HitText.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.Log("No hit");
            }
        }
    }
}
