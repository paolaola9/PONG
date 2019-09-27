using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    Public KeyCode up;
    Public KeyCode down;

    float spedd;

    // Start is called before the first frame update
    void Start() {
        spedd=0.15f;
    }

    // Update is called once per frame
    void Update() {
        if(Input.Getkey(up)){
            transform.Translate(0,spedd,0);
         }
         if (Input.GetKey(down)){
          transform.Translate(0,-spedd,0);
         }
        }
      }