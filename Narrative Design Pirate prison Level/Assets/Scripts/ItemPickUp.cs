using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {

    public Item item;

    public GameObject itemToPickUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PickUp()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (other.tag == "Player")
            {
                if (itemToPickUp == null)
                {
                    return;
                }
                bool wasPickedUp = Inventory.instance.Add(item);

                if (wasPickedUp)
                Destroy(itemToPickUp);

            }
        }
    }
}
