using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    float y = 0;
    public GameObject patlamaAnimasyon;
    OyunKontrol oyunKontrol;
   
    private void Start()
    {
        oyunKontrol = GameObject.Find("OyunKontrol").GetComponent<OyunKontrol>();
    }

    private void Update()
    {
        y = this.gameObject.transform.position.y;
        if(y>=5.71)
        {
            this.gameObject.SetActive(false);
            oyunKontrol.canBalon[oyunKontrol.diziNumarasi++].SetActive(false);
            oyunKontrol.canSayac++;

            if(oyunKontrol.canSayac>=3)
            {
                oyunKontrol.OyunBitti();

            }
        }
    }

    void OnMouseDown()
    {
        GameObject ptl = Instantiate(patlamaAnimasyon, transform.position, transform.rotation);
        Destroy(this.gameObject);
        Destroy(ptl,0.583f);
        oyunKontrol.skor+=10;
    }
}
