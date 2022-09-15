using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public float sayi;
    public Text sayiYazi, ipucuYazi;
    public GameObject bar, ekran;
    public int ipucusayi;

    void Start()
    {
        ekran.SetActive(true);
        ipucusayi = Random.Range(0, 3);
    }

    void Update()
    {
        sayiYazi.text = "" + (int)sayi + "%";
        bar.transform.localScale = new Vector3(sayi / 100, 1, 1);

        if (sayi < 100)
        {
            sayi += Time.deltaTime * 10;
        } if (sayi >= 100)
        {
            sayi = 100;
            ekran.SetActive(false);
        } 
        if(ipucusayi == 0)
        {
            ipucuYazi.text = "Biliyor musun: Bu oyun -Animo Software- taraf�ndan yap�lm��t�r ve Animo Latince'de Ak�l demektir :)";
        }
        if(ipucusayi == 1)
        {
            ipucuYazi.text = "Senin iki kere z�playabilme gibi m�thi� bir yetene�in var";
        }
        if(ipucusayi == 2)
        {
            ipucuYazi.text = "Onca oyun aras�nda beni mi tercih ettin. Art�k sen benim dostumsun ;)";
        }
    }
}
