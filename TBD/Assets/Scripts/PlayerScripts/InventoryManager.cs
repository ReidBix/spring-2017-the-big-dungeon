﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<Item> items;
    private int maxSize = 20;
    private int currentSize;
    // Use this for initialization
    void Start()
    {

    }

    public void addItem(Item item)
    {
        //If item already in inventory, increment quantity of item
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].name.Equals(item.name))
            {
                items[i].quantity += item.quantity;
                return;
            }
        }
        //If not, add the item
        items.Add(item);
    }
    //Can't implement this yet
    public void dropItem()
    {

    }
    //Destroy A Specified Number of Items
    public bool destroyItem(Item item, int quantity)
    {
        if (items.Contains(item))
        {
            if (quantity >= item.quantity)
                items.Remove(item);
            else
                item.quantity -= quantity;
            return true;
        }
        return false;
    }
    //Destroy All Items Passed In
    bool destroyItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            return true;
        }
        return false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}

public class Item
{
    public bool special { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string slug { get; set; }
    public int quantity { get; set; }
    public Item(string name, string description, string slug, int quantity, bool special)
    {
        this.name = name;
        this.description = description;
        this.slug = slug;
        this.quantity = quantity;
        this.special = special;
    }
    public Item(string name, string description, string slug, bool special)
    {
        this.name = name;
        this.description = description;
        this.slug = slug;
        this.special = special;
    }

}
