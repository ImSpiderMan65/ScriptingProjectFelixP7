using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxis : MonoBehaviour
{
    public float hRange;
    public float vRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos = v * hRange;

        transform.position = new Vector3(xPos, 0, vPos);
        Debug.Log("Horizontal Position: " + h.ToString("F2"));
        Debug.Log("Vertical Position: " + v.ToString("F2"));
    }
}
