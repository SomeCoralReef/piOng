using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Transform>().position += new Vector3(0f,-0.018f,0f);
        }
         if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Transform>().position += new Vector3(0f,0.016f,0f);
        }
    
    }
}
