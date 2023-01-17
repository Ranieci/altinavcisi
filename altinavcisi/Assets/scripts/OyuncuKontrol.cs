using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip altin, dusme;
    public oyunkontrol oyunk;
    private float hiz = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunk.oyunAktif) { 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x *= Time.deltaTime * hiz;
        y *= Time.deltaTime * hiz;

        transform.Translate(x, 0f, y); //x yatay sað sol 0f yani y ise yukarý z yani y ise ileri geri
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("altin"))
        {
            oyunk.altinArttir();
            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag.Equals("dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            oyunk.oyunAktif = false;
        }
    }
}
