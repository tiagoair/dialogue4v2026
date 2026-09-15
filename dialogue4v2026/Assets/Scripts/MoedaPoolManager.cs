using System;
using UnityEngine;
using UnityEngine.Pool;

public class MoedaPoolManager : MonoBehaviour
{
    public static MoedaPoolManager Instance;

    [SerializeField] private GameObject moedaPrefab;
    
    public ObjectPool<MoedaController> moedaPool;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            moedaPool = new ObjectPool<MoedaController>(InstantiateMoeda, GetMoeda, ReleaseMoeda,
                DestroyMoeda, true, 100, 10000);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private MoedaController InstantiateMoeda()
    {
        return Instantiate(moedaPrefab, transform).GetComponent<MoedaController>();
    }

    private void GetMoeda(MoedaController moeda)
    {
        moeda.gameObject.SetActive(true);
    }

    private void ReleaseMoeda(MoedaController moeda)
    {
        moeda.gameObject.SetActive(false);
    }

    private void DestroyMoeda(MoedaController moeda)
    {
        Destroy(moeda.gameObject);
    }
}
