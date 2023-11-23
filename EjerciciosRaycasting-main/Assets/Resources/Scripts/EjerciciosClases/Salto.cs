using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    Rigidbody fisicas;

    private void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

        Vector3 origen = transform.position;
        Vector3 direccion = Vector3.down;
        RaycastHit golpe;

        if (Physics.Raycast(origen, direccion, out golpe))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fisicas.AddForce(Vector3.up * 10, ForceMode.Impulse);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, Vector3.down);
    }
}
