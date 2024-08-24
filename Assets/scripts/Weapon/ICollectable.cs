using UnityEngine;

public interface ICollectable
{
    public void Collect(GameObject player);
    public void DestroyItem();
}
