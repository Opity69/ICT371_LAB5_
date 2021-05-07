using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MatchAgent : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent007;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.transform.position = agent007.transform.position;


    }
}
