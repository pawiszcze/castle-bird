using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public static StartGame instance;

    public Text scoreText;
    public Text title;
    public Text playText;
    public Text quitText;
    public Text optionsText;
    public Image coinImage;
    public Image logo;
    public GameObject spriter;
    public GameObject spawner;
    public GameObject butten1;
    public GameObject butten2;
    public GameObject butten3;
    public GameObject optionsButten;
    public int gameMode;

    private void Awake()
    {
        instance = this;
        gameMode = 1;
    }

    public void Activate() {
      //  gameMode = 1;
        Time.timeScale = 1;
        scoreText.text = "0";
        coinImage.enabled = true;
        spriter.GetComponent<SpriteRenderer>().color = Color.white;
        spriter.GetComponent<BirbControl>().isGameActive = true;
        Debug.Log("cycky");
        spawner.GetComponent<SpawnerKolumnowy>().isGameActive = true;
        spawner.GetComponent<SpawnerKolumnowy>().dupa = true;
        logo.enabled = false;
        title.enabled = false;
        playText.enabled = false;
        quitText.enabled = false;
        butten1.active = false;
        butten2.active = false;
        butten3.active = false;
        optionsButten.active = false;
        optionsText.enabled = false;
    }
}
