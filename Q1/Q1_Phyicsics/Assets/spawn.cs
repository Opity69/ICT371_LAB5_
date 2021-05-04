using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obj;
    public int amount;

    void Start()
    {

        
        for (int i = 0; i < amount; i++) {


          Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
           

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
