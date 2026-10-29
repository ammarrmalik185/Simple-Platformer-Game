using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{

    public Rigidbody rigidBody;

    void Update(){
        if (rigidBody.velocity.y < 0.001f){
            if (Input.GetKeyDown(KeyCode.Space)){
                rigidBody.AddForce(0,500f,0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            rigidBody.AddForce(-2f,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            rigidBody.AddForce(2f,0f,0);
        }
    }
}
