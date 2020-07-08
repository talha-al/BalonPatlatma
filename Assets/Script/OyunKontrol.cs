using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    private float xEksen;
    private float yEksen = -5.76f;

    [SerializeField] GameObject balon;
    [SerializeField] GameObject bomba;
    [SerializeField] Text skorText, enYüksekSkorText;
    [SerializeField] int balonHiz = 250;
    [SerializeField] int enYüksekSkor = 0;

    public int skor = 0;
    public int canSayac = 0, diziNumarasi = 0;
    public GameObject[] canBalon;

    bool kontrol = true;

    void Start()
    {
        enYüksekSkor = PlayerPrefs.GetInt("EnYüksekSkor");
        StartCoroutine(BalonOlusturma());
        StartCoroutine(BombaOlusturma());
        StartCoroutine(BalonHizArttirma());
    }

    void Update()
    {
        /* float zmn = Mathf.Round(kalanZaman);
        zamanText.text = "Zaman: " + zmn; math.round metodu ile küsüratlar atılabilir.   */

        skorText.text = "Skor:" + skor;
        enYüksekSkorText.text = "Rekor: " + enYüksekSkor;
        PlayerPrefs.SetInt("SkorKayit", skor);

        if (skor >= enYüksekSkor)
        {
            enYüksekSkor = skor;
            PlayerPrefs.SetInt("EnYüksekSkor", enYüksekSkor);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void OyunBitti()
    {
        kontrol = false;
        SceneManager.LoadScene("OyunSonu");
    }

    IEnumerator BalonOlusturma()
    {
        while (kontrol)
        {
            xEksen = Random.Range(-2.3f, 2.3f);
            Vector3 olusturulanKonum = new Vector3(xEksen, yEksen);
            GameObject balonObje = Instantiate(balon, olusturulanKonum, Quaternion.identity);
            balonObje.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, balonHiz));
            yield return new WaitForSeconds(0.5f);


            //Instantiate(balon, olusturulanKonum, Quaternion.identity);
            //balonObje.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10); velocity komutu ile bu şekilde yapılır.

        }
    }

    IEnumerator BombaOlusturma()
    {
        while (kontrol)
        {
            float xEks = Random.Range(-2.3f, 2.3f);
            Vector3 bombaKonum = new Vector3(xEks, yEksen);
            GameObject bomb = Instantiate(bomba, bombaKonum, Quaternion.identity);
            bomb.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
            yield return new WaitForSeconds(1.8f);

        }

    }

    IEnumerator BalonHizArttirma()
    {
        while (kontrol)
        {
            yield return new WaitForSeconds(8);
            balonHiz += 20;
        }
    }
}
