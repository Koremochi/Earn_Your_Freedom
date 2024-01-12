using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public ItemPickUp getItems; // refrence for the ItemPickUp script
    public GameObject guardJail;
    public GameObject guardGoalDoor;
    public GameObject guardNearCoin;
    public GuardMovement guardMovement;

    private void Update() 
    {
        if(getItems.loot.Count == 3)
        {
            this.gameObject.transform.position = Vector3.down;
        }

        if(getItems.loot.Count == 4 && this.gameObject.tag == "Goal Door")
        {
            this.gameObject.transform.position = Vector3.down;
            //transform.position = Vector3.MoveTowards(transform.position, guardMovement.player.transform.position, guardMovement.guardSpeed * Time.unscaledDeltaTime);
        }
    }
}
