using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot for consumption.");

        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is to cold which meaans bad.");
        }
        else
        {
            print("Coffee is perfect");
        }
    }  
        
}
