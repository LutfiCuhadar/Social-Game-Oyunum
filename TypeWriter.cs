using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class TypeWriter : MonoBehaviour
{
    public GameObject ekran;
    public float delay;

    public AudioClip TypeSound; 
    AudioSource audSrc;

    [Multiline] // stringin baþýna bu terimi yazdýðýmýz zaman yazýlarýmýz büyük ve geniþ olur
    public string yazi;

    Text thisText;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
        thisText = GetComponent<Text>();

        StartCoroutine(TypeWrite());
    }

    IEnumerator TypeWrite()
    {
        foreach(char i in yazi) 
        {
            thisText.text += i.ToString();

            audSrc.pitch = Random.Range(0.8f, 1.2f);
            audSrc.PlayOneShot(TypeSound);

            if (i.ToString() == ".") { yield return new WaitForSeconds(1); }
            else { yield return new WaitForSeconds(delay); }
        }
            ekran.SetActive(false); 
    }
}
