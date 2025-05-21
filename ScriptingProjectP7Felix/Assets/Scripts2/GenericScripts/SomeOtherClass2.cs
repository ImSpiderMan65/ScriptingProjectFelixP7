using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass2 myClass = new SomeClass2();

        myClass.GenericMethod<int>(5);
    }
}

   