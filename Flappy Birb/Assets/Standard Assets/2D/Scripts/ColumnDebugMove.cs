using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnDebugMove : MonoBehaviour {

    Rigidbody2D koolumna;

	// Use this for initialization
	void Start () {

        koolumna = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        Vector2 lokucja = new Vector2(GetComponent<Rigidbody2D>().position.x - 10, (GetComponent<Rigidbody2D>().position.y));

        GetComponent<Rigidbody2D>().MovePosition(lokucja);

        if(koolumna.position.x < -50)
        {
            Destroy(gameObject);
        }
    }
}
