using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pong : MonoBehaviour
{ public bool isplayer_1;
  public float speed;
  public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){
    if(isplayer_1)
    {
        movement = Input.GetAxisDraw5555("Vertical");
    }
    else
    {
        movement = Input.GetAxisDraw("Vertical2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}