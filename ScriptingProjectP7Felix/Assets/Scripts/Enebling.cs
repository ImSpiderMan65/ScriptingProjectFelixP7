using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enebling : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
