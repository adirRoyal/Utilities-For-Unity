using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : Component
{
    private readonly T prefab;
    private readonly Queue<T> objects = new Queue<T>();

    public ObjectPool(T prefab, int initialSize = 10)
    {
        this.prefab = prefab;
        for (int i = 0; i < initialSize; i++)
        {
            AddObject();
        }
    }

    private void AddObject()
    {
        T obj = Object.Instantiate(prefab);
        obj.gameObject.SetActive(false);
        objects.Enqueue(obj);
    }

    public T GetObject()
    {
        if (objects.Count == 0) AddObject();
        T obj = objects.Dequeue();
        obj.gameObject.SetActive(true);
        return obj;
    }

    public void ReturnObject(T obj)
    {
        obj.gameObject.SetActive(false);
        objects.Enqueue(obj);
    }
}
