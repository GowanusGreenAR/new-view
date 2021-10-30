using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = GameObject.Find("[VRTK]_VIVE").transform.position;
        this.gameObject.transform.position = cameraPos;
    }
    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = new Color32(248, 168, 133, 1);
    }
}
