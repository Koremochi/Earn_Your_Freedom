using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    public Transform position1, position2;
    public GameObject player;
    public float guardSpeed = 2.5f;
    private bool posSwitch = false;
    public bool alarm = false;

    private void FixedUpdate() 
    {
        if(posSwitch == false && alarm == false) 
        {
            transform.position = Vector3.MoveTowards(transform.position, position1.position, guardSpeed * Time.unscaledDeltaTime);
        } 
        else if(posSwitch == true && alarm == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position, guardSpeed * Time.unscaledDeltaTime);
        }

        if(transform.position == position1.position)
        {
            transform.eulerAngles = new Vector3 (0, 90, 0);
            posSwitch = true;
        }      
        else if(transform.position == position2.position)
        {
            transform.eulerAngles = new Vector3 (0, -90, 0);
            posSwitch = false;
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            alarm = true;
            //transform.LookAt(player.transform);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, guardSpeed * Time.unscaledDeltaTime);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        alarm = false;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Game over");
        }
    }
}
