using System.Collections;
using UnityEngine;

public class BALLCONTROL : MonoBehaviour {
    int speddX;
    int speddY;

    float spedd;

    // Start is called before the first frame update
    void Start() {

        spedd=Random.Range(5,10);

        speddX=Random.Range(0,2);
        if(speddX==0){
            speddX=1;
        } else{
            speddX=-1;
        }

        speddY=Random.Range(0,2);
                if(speddY==0){
                    speddY=1;
                } else{
                    speddY=-1;
                }
        GetComponent<Rigidbody>().velocity= new Vector3(spedd*speddX,spedd*speddY,0);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
