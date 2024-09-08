using UnityEngine;

public class TakeItem : MonoBehaviour, ICollectable
{
    public Sprite iconInv;
    public Inventory inventory;
    public string itemName;
    public GameObject itemObj;
    public bool isOnTrain;
    public Transform train;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    public void Collect(GameObject player)
    {
        if(inventory.CheckSlots())
        {
            if(itemObj != null)
            {
                Transform itemSlot = GameObject.FindGameObjectWithTag("ItemSlot").gameObject.transform;
                
                GameObject gameObjectInst = Instantiate(itemObj);
                gameObjectInst.transform.position = itemSlot.position;
                gameObjectInst.transform.SetParent(itemSlot);
                gameObjectInst.transform.rotation = itemSlot.rotation;

                int index = inventory.AddItemInInventory(iconInv, gameObjectInst);
                gameObjectInst.GetComponent<DropItem>().indexInInv = index;
                Inventory.CurrentObjectInHand = index;
                DestroyItem();
            }
            else
            {
                Debug.Log("Dont have obj link");
            }
        }
        else
        {
            Debug.Log("You dont have space in inv");
        }
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<Collider>().isTrigger = true;
        }

        if(collision.gameObject.tag == "Train")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<Collider>().isTrigger = true;
            train = collision.gameObject.GetComponent<Transform>();
            gameObject.transform.SetParent(train);
        }
    }
}
