using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public List<GameObject> loot = new List<GameObject>();
    float timer = 5f;
    bool speedUp;
    bool speedDown;
    public PlayerMovement pm;

    private void Update()
    {
        
        Debug.Log(Time.deltaTime);
        if(speedUp == true)
        {
            timer -= Time.deltaTime;
            pm.playerSpeed = 17f;
            if(timer <= 0)
            {
                speedUp = false;
                pm.playerSpeed = 12f;
            }
        }

        if(speedDown == true)
        {
            timer -= Time.deltaTime;
            pm.playerSpeed = 7f;
            if(timer <= 0)
            {
                speedDown = false;
                pm.playerSpeed = 12f;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Bowl")
        {
            loot.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Jug")
        {
            loot.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Coin")
        {
            loot.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Crystal")
        {
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "SpeedUp")
        {
            speedUp = true;
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "SpeedDown")
        {
            speedDown = true;
            other.gameObject.SetActive(false);
        }
    }
}
