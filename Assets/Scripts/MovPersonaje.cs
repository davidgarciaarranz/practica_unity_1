using Unity.VisualScripting;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float velocidad = 8f;

    public Animator animator; 

    Rigidbody2D rg;

    Vector2 mov;

    public bl_Joystick JS;


    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal") + JS.Horizontal;
        float velocidadY = Input.GetAxis("Vertical") + JS.Vertical;

        mov = new Vector2(velocidadX, velocidadY);

        bool estaMov = false;

        if (velocidadX != 0 || velocidadY != 0)
        {
            estaMov = true;
        }
        else
        {
            estaMov = false;
        }

        animator.SetFloat("horizontal", mov.x);
        animator.SetFloat("vertical", mov.y);
        animator.SetBool("isMov", estaMov);
    }
    //usado para las fisicas en unity
    private void FixedUpdate()
    {
        rg.MovePosition(rg.position + mov * velocidad * Time.deltaTime);
        //transform.Translate(Vector3.right * velocidadX * Time.deltaTime * velocidad);
        //transform.Translate(Vector3.up * velocidadY * Time.deltaTime * velocidad);
    }
}
