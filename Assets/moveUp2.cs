using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Transform>().position += new Vector3(0f,-0.017f,0f);
        }
         if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Transform>().position += new Vector3(0f,0.014f,0f);
        }
    
    }
}
