using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoedaSpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject moedaPrefab;

    [SerializeField] private Vector3 SpawnLimits1;
    [SerializeField] private Vector3 SpawnLimits2;

    private void Start()
    {
        InvokeRepeating("SpawnMoeda", 0f, 0.001f);
    }

    public void SpawnMoeda()
    {
        float randx =  Random.Range(SpawnLimits1.x, SpawnLimits2.x);
        float randz =  Random.Range(SpawnLimits1.z, SpawnLimits2.z);
        
        //Instantiate(moedaPrefab, new Vector3(randx, 2f, randz), Quaternion.identity);
        MoedaPoolManager.Instance.moedaPool.Get().transform.position = new Vector3(randx, 2f, randz);
    }
}
