using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Material[] materials; // Массив материалов
    public Transform spawnLocation; // Точка спавна



    public void SpawnObject()
    {
    if (prefabToSpawn != null && materials.Length > 0 && spawnLocation != null)
    {
        // Спавн объекта в определенном месте
        GameObject spawnedObject = Instantiate(prefabToSpawn, spawnLocation.position, spawnLocation.rotation);

        // Выбор случайного материала
        Material randomMaterial = materials[Random.Range(0, materials.Length)];

        // Применение случайного материала к заспавненному объекту
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
