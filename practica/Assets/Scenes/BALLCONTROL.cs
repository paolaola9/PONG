using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BALLCONTROL : MonoBehaviour {
    int speddX;
    int speddY;
   
    float spedd;

    public Text scoreText;
    int player1Score;
    int player2Score;

    // Start is called before the first frame update
    void Start() {

        spedd=Random.Range(10,20);

        speddX=Random.Range(0,4);
        if(speddX==0){
            speddX=1;
        } else{
            speddX=-1;
        }

        speddY=Random.Range(0,4);
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
        scoreText.text = player1Score.ToString() + " - " + player2Score.ToString();
        
    }

    private void OnCollisionEnter(Collision objeto){

        if (objeto.collider.tag=="goal izquierda")
        {
            player1Score++;
        }

        if (objeto.collider.tag == "goal derecha")
        {
            player2Score++;
        }

    }
}
