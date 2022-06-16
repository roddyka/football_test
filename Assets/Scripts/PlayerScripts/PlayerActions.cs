using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float forceApplied;
    public bool snapped = false;
    public bool snapped_continue_on_movement = true;
    public GameObject snapparent;
    public Vector3 offset;

    void Update()
    {
       
    }
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "ball")
        {
            if(!snapped){
                snapped = true;
                snapparent = collision.gameObject;
                offset = transform.position - snapparent.transform.position; 
                // collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                collision.gameObject.GetComponent<Rigidbody>().mass = 0;
            }
            

            if (Input.GetMouseButtonDown(0)){
                snapped = false;
                Debug.Log("Pressed primary button.");
                collision.gameObject.GetComponent<Rigidbody>().AddForce (forceApplied, 0, 0);
            }
            
        }
    }
}
