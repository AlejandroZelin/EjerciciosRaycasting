using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionDeCamara : MonoBehaviour
{
    public Rigidbody rb;


    public float rotacionX, rotacionY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotacionX += mouseX;
        rotacionY += mouseY;

        transform.eulerAngles = new Vector3(-rotacionY, rotacionX, 0);
    }
}
