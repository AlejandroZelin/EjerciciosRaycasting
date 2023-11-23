using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public float movX, movZ;
    public GameObject Personaje;
    public GameObject Camara;
    Rigidbody fisicas;
    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");


        Camara.transform.position = new Vector3(Personaje.transform.position.x, Personaje.transform.position.y + 2, Personaje.transform.position.z - 5);

        Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit direccion;
        
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(rayoCamara, out direccion, 100))
            {
                Vector3 newPos = direccion.point + new Vector3(0,0.5f,0);
                Personaje.transform.position = newPos;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawRay(transform.position, transform.forward);
    }
}
