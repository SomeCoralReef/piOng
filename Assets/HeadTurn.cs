using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurn : MonoBehaviour
{
    [SerializeField] private Sprite[] framearray;
    private int currentFrame;
    private float timer; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            timer += Time.deltaTime;

            if(timer >= 0.05f) {
                timer -= 0.05f;
                currentFrame = (currentFrame +1) % framearray.Length;
                gameObject.GetComponent<SpriteRenderer>().sprite = framearray[currentFrame];
            }
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            timer += Time.deltaTime;

            if(timer >= 0.05f) {
                timer -= 0.05f;
                currentFrame = (currentFrame -1) % framearray.Length;
                gameObject.GetComponent<SpriteRenderer>().sprite = framearray[currentFrame];
            }
        }
    
    }
}
