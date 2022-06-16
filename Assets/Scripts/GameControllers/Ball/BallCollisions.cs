using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisions : MonoBehaviour
{
    public void OnTriggerEnter (Collider other) //Make sure to put this out of Voids
    {
        if (other.gameObject.tag == "goal1") 
        {
            GameController.instance.updateScoreText("goal1");
        }else if(other.gameObject.tag == "goal2") {
            GameController.instance.updateScoreText("goal2");
        }
    }
}
