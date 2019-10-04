using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable {

    public Item item;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }
    void Pickup()
    {
        
        Debug.Log("Picking up"+item.name);
        //Add to inventory
        bool wasPickup =Inventory.instance.Add(item);
        if(wasPickup)
        {
            Destroy(gameObject);
        }
        
    }
}
