using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemID
{
    public int _id;
    public Vector3 _position;

    public ItemID(int id, Vector3 position)
    {
        _id = id;
        _position = position;
    }
}
