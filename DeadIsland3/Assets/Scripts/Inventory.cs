using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[4];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        
        //open slot finder
        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + " was added");
                itemAdded = false;
                break;
            }
        }

        //inv full
        if (!itemAdded)
        {
            Debug.Log("Inventory Full - Item Not Added");
        }
    }

}
