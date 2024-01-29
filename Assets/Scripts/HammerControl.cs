using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;
    
    public float posX;
    public float rangeX;
    public float posY;
    public float posZ;
    public float zSpeed;

    public float maxLife;
    private float _lifeTime;

    public bool workStats;

    private GameObject _currentPrefab;
    
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_currentPrefab != null)
        {
            if (_lifeTime > 0)
            {
                Vector3 force = new Vector3(0,0,zSpeed);
                _currentPrefab.transform.Translate(force);
                _lifeTime -= 1.0f;
            }
            else
            {
                Destroy(_currentPrefab);
                Vector3 spawnPosition = new Vector3( (int)(Random.Range(-1,2)) * 0.15f, posY, posZ);
                _currentPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
                _lifeTime = (Random.Range(0.5f, 1.5f) + maxLife)*50;
            }
        }
        else
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-rangeX, rangeX) + posX, posY, posZ);
            _currentPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
            _lifeTime = (Random.Range(0.5f, 1.5f) + maxLife)*50;
        }
    }
}
