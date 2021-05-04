using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class RunThreadsDebugConsoleOut : MonoBehaviour
{
    // Start is called before the first frame update

 
    void Start()
    {  
        
        
        Thread _t1;
        Thread _t2;
        Debug.Log("Thread Start");
        _t1 = new Thread(Thread1Func);
        _t1.Start();
        _t1.Join();
        _t2 = new Thread(Thread2Func);
        _t2.Start();
        _t2.Join();
        Debug.Log("Main Program End");
       
        


        


        
    }

    void Thread1Func() { 

        


        for (int i = 1;  i  < 5; i++) { 
        
         Debug.Log("Thread#1 "  + i);
        }

        return;
           
    
    }

    void Thread2Func()
    {
        for (int i = 1; i < 5; i++)
        {

            Debug.Log("Thread#2 " + i);
        }

        return;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
