using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Equipment",menuName ="Inventory/Equipment")]
public class Equipment : Item {

    // Use this for initialization
    public EquipmentSlot equipSlot;
    public int armorModifier;
    public int damageModifier;
    public override void Use()
    {
        base.Use();
        //equip the item
        EquipmentManager.instance.Equip(this);
        //remove it form the inventory
        RemoveFromInventory();
    }
}

public enum EquipmentSlot { Head,Chest,Legs,Weapon,Shield,Feet}