using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ItemType { Useable,Weapon,Armor}
[CreateAssetMenu(fileName ="New Item",menuName ="Inventory/ItemData")]
public class ItemData_SO : ScriptableObject
{
    public ItemType itemType;

    public string itemName;

    public Sprite itemIcon;

    public int itemAmount;
    [TextArea]
    public string description = "";

    public bool stackable;

    [Header("Weapon")]
    public GameObject weaponPrefab;

    public AttackData_SO weaponAttackDate;

    public AnimatorOverrideController weaponAnimator;

    [Header("UseableItem")]
    public UseableItemData_SO usableItemData;

    [Header("Armor")]
    public GameObject armorPrefab;
    public CharacterDate_SO armorDate;
}
