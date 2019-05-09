using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BirbControl : MonoBehaviour {

    public bool isGameActive = false;
    public float opadanie = 0;
    public float flapnosc = 100;
    public float grawitas = 1;
    public int score = 0;
    public Text scoreText;
    public Text finalScore;
    public Text quitText;
    public Text gameOver;
    public Text backText;
    public Text scoreStatic;
    public Text optionsText;
    public Image coinImage;
    public Image gOverImage;
    public Image scoreImage;
    public Image OptionScroll;
    public Text OptionScrollText;
    public GameObject butten1;
    public GameObject butten2;
    public GameObject backButten;
    public GameObject optionsButten;
    //public GameObject spawner;
    StartGame startGame;
    SpawnerKolumnowy spawner;

    void Start () {
        startGame = StartGame.instance;
        spawner = SpawnerKolumnowy.instance;
        Time.timeScale = 0;
        scoreText.text = " ";
        finalScore.text = "0";
        coinImage.enabled = false;
        GetComponent<SpriteRenderer>().color = Color.clear;
        gameOver.enabled = false;
        scoreStatic.enabled = false;
        finalScore.enabled = false;
        gOverImage.enabled = false;
        scoreImage.enabled = false;
        butten1.active = false;
        OptionScroll.enabled = false;
        OptionScrollText.enabled = false;
        backButten.active = false;
        backText.enabled = false;
        
        

    }
	
	void Update () {
        


        if (isGameActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                opadanie = flapnosc;
                GetComponent<AudioSource>().Play();
            }
            Vector2 lokucja = new Vector2(GetComponent<Rigidbody2D>().position.x, (GetComponent<Rigidbody2D>().position.y + opadanie));
            opadanie -= grawitas / 2;
            GetComponent<Rigidbody2D>().MovePosition(lokucja);

            
        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Scorer")
        {
            score = score + 1;
            scoreText.text = score.ToString();
            Debug.Log(startGame.gameMode);
            if (startGame.gameMode == 1 && score == 3)
            {
                StopSpawning();
            }

            if (startGame.gameMode == 1 && score == 4)
            {
                EndStory();
            }
        }
        else
        {
            //Debug.Log(collision.name);
            if (collision.GetComponent<AudioSource>())
            {
                collision.GetComponent<AudioSource>().Play();
            }
            Time.timeScale = 0;
            finalScore.text = scoreText.text;
            finalScore.enabled = true;
            scoreText.text = " ";
            coinImage.enabled = false;
            butten1.active = true;
            butten2.active = true;
            quitText.enabled = true;
            gameOver.enabled = true;
            scoreStatic.enabled = true;
            gOverImage.enabled = true;
            scoreImage.enabled = true;
            optionsButten.active = true;
            optionsText.enabled = true;



            var obj = GameObject.Find("Resp");
            var pos = obj.transform.position;
            transform.position = pos;
            isGameActive = false;
            GetComponent<SpriteRenderer>().color = Color.clear;
        }         
    }

    void StopSpawning()
    {
        spawner.dupa = false;
    }

    void EndStory()
    {
        Time.timeScale = 0;
    }
}
