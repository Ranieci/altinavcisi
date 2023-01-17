using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunkontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public Text altinsayisiText;
    public Button baslaButonu;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void altinArttir()
    {
        altinSayisi += 1;
        altinsayisiText.text = "" + altinSayisi;
    }

    public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
}
