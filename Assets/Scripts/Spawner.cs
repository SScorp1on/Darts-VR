using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Material[] materials; // ������ ����������
    public Transform spawnLocation; // ����� ������



    public void SpawnObject()
    {
    if (prefabToSpawn != null && materials.Length > 0 && spawnLocation != null)
    {
        // ����� ������� � ������������ �����
        GameObject spawnedObject = Instantiate(prefabToSpawn, spawnLocation.position, spawnLocation.rotation);

        // ����� ���������� ���������
        Material randomMaterial = materials[Random.Range(0, materials.Length)];

        // ���������� ���������� ��������� � ������������� �������
        Renderer objectRenderer = spawnedObject.GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material = randomMaterial;
        }
        else
        {
            Debug.LogError("Spawned object does not have a Renderer component.");
        }
    }
        else
        {
            Debug.LogError("Prefab, materials or spawn location not set.");
        }
    }
}
