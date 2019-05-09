using System.Collections;
using System.Collections;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

    public float szybkosc = 0;

	void Start () {
		
	}
	
	void Update () {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time * szybkosc)%1, 0f);
	}
}
