using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoCamara : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {

            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit golpe;

            if (Physics.Raycast(rayoCamara, out golpe)) 
            {
                Debug.Log(golpe.collider.gameObject.name);
            }
        }
    }
}
