using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderController : MonoBehaviour
{

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag.Equals("player")){
            Debug.Log("Successful Player Colission");
        }
    }

    void Update()
    {
        
    }
}
