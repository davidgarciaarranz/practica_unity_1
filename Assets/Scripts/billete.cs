using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class billete : MonoBehaviour
{
    public float velocidad;
    public GameObject text;
    Transform movimiento;
    private bool estaMov = true;
    private Vector2 dir;
    private Animator animacion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movimiento = GetComponent<Transform>();
        dir = Vector2.right;
        animacion = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (estaMov)
        {
             movimiento.Translate(dir * Time.deltaTime * velocidad);
             //transform.Translate(dir * Time.deltaTime * velocidad);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            estaMov = !estaMov;

        }
        if (estaMov == false)
        {

            animacion.enabled = false;
        }
        if (estaMov)
        {
            animacion.enabled = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Personaje")) {
            
            text.SetActive(true);
            Debug.Log("Otro para la buchaca");
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("paredes"))
        {
            dir = -dir;
        }

    }
}
