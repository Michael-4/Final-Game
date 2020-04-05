using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/* Sits on all InventorySlots. */

public class CraftingRecipes : MonoBehaviour
{
    public Item key;
    public Item sword;
    public Item wood;
    public Item armour;

    public static Item staticKey;// Current item in the slot
    public static Item staticSword;
    public static Item staticWood;
    public static Item staticArmour;

    private void Awake()
    {
        staticKey = key;
        staticSword = sword;
        staticWood = wood;
        staticArmour = armour;
    }

    public static Item ReadWord(string word)
    {

        switch (word)
        {
            case "KEY":
                return staticKey;
            case "SWORD":
                return staticSword;
            case "WOOD":
                return staticWood;
            case "ARMOUR":
                return staticArmour;
            default:
                return null;
        }

    }
    
}
