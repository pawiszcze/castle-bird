using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsScript : MonoBehaviour {

    public GameObject BackButten;
    public Image OptionsBanner;
    public Text BackText;
    public Text BannerText;

    // Use this for initialization
    public void Activate() {

        BackButten.active = true;
        BackText.enabled = true;
        OptionsBanner.enabled = true;
        BannerText.enabled = true;
    }

    public void Dectivate()
    {

        BackButten.active = false;
        BackText.enabled = false;
        OptionsBanner.enabled = false;
        BannerText.enabled = false;
    }

}
