using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        if (transform.position.y > 20f)
        {
            Debug.Log("IM GOING TO DIEEEEEEEEEEEEE!!!!!!!!!!!!!!!!");
        }
        if (transform.position.y <= 0f)
        {
            Debug.Log("OMG im still alive");
        }
    }
}
