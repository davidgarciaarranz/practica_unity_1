using UnityEngine;
using System.Collections;   

public class Text : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Muesta();
    }
    private IEnumerator MostrarText()
    {
        yield return new WaitForSeconds(4f);
        gameObject.SetActive(false);
    }

    public void Muesta()
    {
        if (gameObject)
        {
            StartCoroutine(MostrarText());
        }
    }
}

