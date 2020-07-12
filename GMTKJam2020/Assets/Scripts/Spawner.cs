using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObjectReference m_prefab = null;

    private readonly List<GameObject> m_instances = new List<GameObject>();

    public void Spawn()
    {
        var prefab = m_prefab?.Value;
        if (prefab == null)
        {
            return;
        }

        var instance = Instantiate(prefab);
        instance.transform.position = transform.position;
        instance.transform.rotation = transform.rotation;
        instance.name = $"*{prefab.name}";

        m_instances.Add(instance);
        return;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 1f);
        Gizmos.color = Color.white;
    }

}
