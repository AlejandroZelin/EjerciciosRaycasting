using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionDeCamara : MonoBehaviour
{
    public GameObject Camara;
    Rigidbody rb;
    float rotacionx = 0f;
    float rotaciony = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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


    }


    void Mover()
    {
        Vector3 rectoCamara = Camara.transform.forward;
        Vector3 ladoCamara = Camara.transform.right;
        rectoCamara.y = 0;
        ladoCamara.y = 0;

        Vector3 direccion = Input.GetAxisRaw("Horizontal") * ladoCamara
            + Input.GetAxisRaw("Vertical") * rectoCamara;
        direccion.y = rb.velocity.y;

        Debug.Log(direccion);

        rb.velocity = direccion;
    }
}
