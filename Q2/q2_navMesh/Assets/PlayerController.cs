using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera Cam;
    public NavMeshAgent agent007;
    void Start()
    {
        Cursor.visible = true;
       


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            Debug.Log("Update");
            Ray Camray = Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(Camray, out hit))
            {
                agent007.SetDestination(hit.point);
            }
        }

    }
}
