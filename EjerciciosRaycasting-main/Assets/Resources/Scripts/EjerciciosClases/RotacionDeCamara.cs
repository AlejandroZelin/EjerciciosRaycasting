using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionDeCamara : MonoBehaviour
{
    public GameObject Camara;
    public GameObject Personaje;
    Rigidbody rb;
    float rotacionx = 0f;
    float rotaciony = 0f;
    public float velocidad = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = Personaje.GetComponent<Rigidbody>();
        Camara = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        rotacionx += mouseX;
        rotaciony += mouseY;

        transform.eulerAngles = new Vector3(-rotaciony, rotacionx, 0);

        Mover();
    }


    void Mover()
    {
        Vector3 rectoCamara = Camara.transform.forward;
        Vector3 ladoCamara = Camara.transform.right;
        rectoCamara.y = 0;
        ladoCamara.y = 0;

        Vector3 direccion = (Input.GetAxisRaw("Horizontal") * ladoCamara) * velocidad
            + (Input.GetAxisRaw("Vertical") * rectoCamara) * velocidad;
        direccion.y = rb.velocity.y;

        //Debug.Log(direccion);

        rb.velocity = direccion;
    }
}
