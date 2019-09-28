using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;

    float spedd;
    float finalSpeed;

    // Start is called before the first frame update
    void Start() {
        spedd=0.15f;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(up)){
            if (transform.localPosition.y > 4){
                finalSpeed = 0;

            } else{
                finalSpeed = spedd;
            }
            transform.Translate(0,finalSpeed,0);
        }


        if (Input.GetKey(down)){

            if (transform.localPosition.y < -4)
            {
                finalSpeed = 0;

            }
            else
            {
                finalSpeed = spedd;
            }

        transform.Translate(0,-finalSpeed,0);
         }
        }
      }