using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraObject;
    void Start()
    {
        cameraObject = GameObject.Find("[VRTK]_VIVE");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
