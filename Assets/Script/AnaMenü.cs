using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenü : MonoBehaviour
{
    OyunKontrol okScript;
    public Text enYüksekText;
    void Start()
    {
        
        int enYüksekSkor = PlayerPrefs.GetInt("EnYüksekSkor");
        enYüksekText.text = "Rekor : " + enYüksekSkor;
        
    }

    void Update()
    {

    }

    public void SahneDegistir()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }
}
