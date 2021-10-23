using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug_test : MonoBehaviour
{
    float num;
    // Start is called before the first frame update
    void Start()
    {
        num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        num += 1;
        Debug.Log(num);
    }
}
