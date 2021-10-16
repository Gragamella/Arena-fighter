using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{

    public Player inventarioGiocatore;
    public static ItemWorld SpawnItemWorld(Vector3 position, Items item)
    {
       Transform transform = Instantiate(ItemsAssets.Instance.pfItemWorld, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();

        itemWorld.SetItem(item);

        return itemWorld;
    }

    private SpriteRenderer spriteRenderer;
    private Items item;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        inventarioGiocatore = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (this.gameObject.GetComponent<Collider2D>().IsTouching(inventarioGiocatore.gameObject.GetComponent<Collider2D>()))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inventarioGiocatore.inventario.addItems(GetItem());
                Destroy(this.gameObject);
            }
        }
    }

    public void SetItem(Items item)
    {
        this.item = item;
        spriteRenderer.sprite = item.GetSprite();
    }


    public Items GetItem()
    {
        return item;
    }

    public void OnTriggerStay2D(Collider2D collider)
    {
      
    }

}
