using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {
    
    private int lifetime = 240;

	void Update () {
        if (lifetime > 0)
        {
            lifetime = lifetime - 1;
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
