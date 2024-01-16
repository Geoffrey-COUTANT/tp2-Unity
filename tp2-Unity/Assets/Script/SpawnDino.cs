using UnityEngine;

public class SpawnDinoGround : MonoBehaviour
{
    public GameObject objectToSpawn;
    private float spawnInterval = 2f;

    private Camera mainCamera;
    private float nextSpawnTime;

    void Start()
    {
        mainCamera = Camera.main;
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = CalculateSpawnPosition();
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        
        if (!IsObjectVisible(spawnedObject.GetComponent<Renderer>()))
        {
            Destroy(spawnedObject);
        }
    }

    Vector2 CalculateSpawnPosition()
    {
        float spawnX = Random.Range(9f, 9f);
        float spawnY = Random.Range(-1.2f, -1.2f);

        return new Vector3(spawnX, spawnY);
    }

    bool IsObjectVisible(Renderer objectRenderer)
    {
        if (objectRenderer == null)
            return false;
        
        Plane[] frustumPlanes = GeometryUtility.CalculateFrustumPlanes(mainCamera);
        return GeometryUtility.TestPlanesAABB(frustumPlanes, objectRenderer.bounds);
    }
}