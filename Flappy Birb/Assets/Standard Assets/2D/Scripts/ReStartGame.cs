using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ReStartGame : MonoBehaviour
{

    public Text scoreText;
    public Text title;
    public Text playText;
    public Text quitText;
    public Text finalScore;
    public Text finalStatic;
    public Image scoreScroll;
    public Image coinImage;
    public Image logo;
    public GameObject spriter;
    public GameObject spawner;
    public GameObject butten1;
    public GameObject butten2;

    public void Activate()
    {
        Time.timeScale = 1;
        scoreText.text = "0";
        coinImage.enabled = true;
        spriter.GetComponent<SpriteRenderer>().color = Color.white;
        spriter.GetComponent<BirbControl>().isGameActive = true;
        spawner.GetComponent<SpawnerKolumnowy>().isGameActive = true;
        logo.enabled = false;
        title.enabled = false;
        playText.enabled = false;
        quitText.enabled = false;
        butten1.active = false;
        butten2.active = false;
        scoreScroll.enabled = false;
        finalScore.enabled = false;
        finalStatic.enabled = false;
        spriter.GetComponent<BirbControl>().opadanie = 0;
        spriter.GetComponent<BirbControl>().score = 0;
        var obj = GameObject.FindGameObjectsWithTag("Clone");
        for (int i = 0; i < obj.Length; i++)
        {
            Destroy(obj[i].gameObject);
        }

    }
}
