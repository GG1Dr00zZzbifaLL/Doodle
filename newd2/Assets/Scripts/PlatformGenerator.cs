using UnityEngine;
public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject platformTucha;
    public float forceJump;
    public int cloudLength;
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        for (int i = 0; i < cloudLength; i++)
        {
            SpawnerPosition.x = Random.Range(-4f, 4f);
            SpawnerPosition.y = Random.Range(-10f, 8f);
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
        for (int i = 0; i < cloudLength - 1; i++)
        {
            SpawnerPosition.x = Random.Range(-4f, 4f);
            SpawnerPosition.y = Random.Range(-10f, 8f);
            Instantiate(platformTucha, SpawnerPosition, Quaternion.identity);
        }
    }
}
