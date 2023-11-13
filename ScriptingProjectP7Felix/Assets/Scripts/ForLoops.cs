using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    int NumCount = 6;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < NumCount; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
