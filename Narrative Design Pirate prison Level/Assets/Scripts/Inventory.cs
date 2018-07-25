using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    //This is if there is more than one inventroy write in console theres more than one inventory
    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this; 
    }

    #endregion


    public delegate void OnItemChanged();
    public OnItemChanged onitemChangedCallback;

    public int space = 10;

    //These are items in our inventory
    public List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
        if (!item.isDefaultitem)
        {  
            if (items.Count >= space)
            {
                Debug.Log("Not enough space");
                return false;
            }
         items.Add(item);

            if (onitemChangedCallback != null)
            onitemChangedCallback.Invoke();
        }

        return true;
    }

    public void Remove (Item item)
    {
        items.Remove(item);

        if (onitemChangedCallback != null)
            onitemChangedCallback.Invoke();
    }
}
