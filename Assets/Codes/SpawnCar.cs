using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    [SerializeField]
    GameObject _itemToBeSpawn;

    [SerializeField]
    GameObject _obstaclesToBeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnItem", 2.0f);
        Invoke("SpawnObstacle", 2.0f);
    }
    /*
    void SpawnItem()
    {
        GameObject go = Instantiate(_itemToBeSpawn,
            new Vector3(Random.Range(200, -200f), 1, Random.Range(-180f, 200f)),
            Quaternion.identity);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnItem", nextSpawnTime);
    }
    */
    // Update is called once per frame
    void SpawnObstacle()
    {
        GameObject go = Instantiate(_obstaclesToBeSpawn,
            new Vector3(240, 3, Random.Range(-170f, 230f)),
            Quaternion.identity);
        float nextSpawnTime = Random.Range(0.15f, 0.5f);
        Invoke("SpawnObstacle", nextSpawnTime);     
        Destroy(go, 5.0f);
    }

}
