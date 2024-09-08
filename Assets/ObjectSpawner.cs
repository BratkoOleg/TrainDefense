using UnityEngine;

public class ObjectSpawner : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform _spawnSpot;

    public void Interact()
    {
        GameObject obj = Instantiate(Resources.Load(StaticNames.SwordObject, 
                                                typeof(GameObject))) as GameObject;
        obj.transform.SetParent(_spawnSpot);
        obj.transform.position = _spawnSpot.position;
    }
}
