using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch_light : MonoBehaviour
{
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>();
        if (Input.GetKey(KeyCode.F))
        {
            light.enabled = !light.enabled;
        }

        
    }
}
