using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombControl : MonoBehaviour
{
    OyunKontrol okScript;
    float y;
    void Start()
    {
        okScript = GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>();
        
    }

    // Update is called once per frame
    void Update()
    {
        y = gameObject.transform.position.y;
        if(y>5.71f)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        okScript.OyunBitti();
    }
}
