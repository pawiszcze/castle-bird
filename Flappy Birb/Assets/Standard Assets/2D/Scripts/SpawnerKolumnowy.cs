using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    SpawnerKolumnowy : MonoBehaviour {

    public static SpawnerKolumnowy instance;

    CameraScript camera;
    StartGame start;
    bool doOnce = false;
    int deltaT = 0;
    public bool isGameActive = false;
    public bool dupa = true;
    public int delay;
    public int yMin;
    public int yMax;
    public GameObject prefab;
    public GameObject wallPrefab;
    //public GameObject controller;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        //controller.GetInstanceID();
        start = StartGame.instance;
        camera = CameraScript.instance;
	}

    // Update is called once per frame
    void Update()
    {
        if (start.gameMode == 1)
        {
            if (!doOnce)
            {
                Vector3 vectBack = new Vector3(0, 0, 1);
                GameObject back = (GameObject)Instantiate(wallPrefab, vectBack, transform.rotation, camera.transform);
                back.transform.localPosition = new Vector3(0, 0, 1);
                doOnce = true;
            }

        }

            if (deltaT == delay)
            {
                Vector2 vect = new Vector2(1500, Random.Range(yMin, yMax));

            Vector2 vectBack = new Vector2(0, 0);
            //bool dupa = controller.GetComponent<BirbControl>().isGameActive;
            if (dupa)
                {
                    GameObject kol = (GameObject)Instantiate(prefab, vect, transform.rotation);
                    GameObject back = (GameObject)Instantiate(wallPrefab, vectBack, transform.rotation);
            } 
                
            




                deltaT = deltaT - delay;

            }
            else
            {
                deltaT = deltaT + 1;
            }

        
            
        
    }
}
