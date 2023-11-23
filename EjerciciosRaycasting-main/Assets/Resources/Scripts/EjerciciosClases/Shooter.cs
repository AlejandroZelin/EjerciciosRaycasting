using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public int mascara;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mascara = 1 << 7;


        if (Input.GetMouseButtonDown(0))
        {

            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit golpe;

            if (Physics.Raycast(rayoCamara, out golpe, 10000, mascara))
            {
                Destroy(golpe.collider.gameObject);
            }
        }
    }
}
