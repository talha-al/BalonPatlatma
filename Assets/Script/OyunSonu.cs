using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunSonu : MonoBehaviour
{
    OyunKontrol okScript;
    public Text skorText, enYüksekText;

    void Start()
    {
        
    }

    
    void Update()
    {
        int skor = PlayerPrefs.GetInt("SkorKayit");
        int enYüksekSkor = PlayerPrefs.GetInt("EnYüksekSkor");
        skorText.text = "Skor: " + skor;
        enYüksekText.text = "En Yüksek Skor: " + enYüksekSkor;
    }

    public void SahneDegistir()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }
}
