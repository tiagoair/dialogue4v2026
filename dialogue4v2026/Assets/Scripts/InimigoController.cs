using System;
using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Animator inimigoSM;
    [SerializeField] private float velocidadeMovimento;
    [SerializeField] private List<Transform> pontosDePatrulha;
    

    public Transform PlayerTransform => playerTransform;
    public float VelocidadeMovimento => velocidadeMovimento;
    public List<Transform> PontosDePatrulha => pontosDePatrulha;
    public int indiceAtual;
    
    private void Update()
    {
        inimigoSM.SetFloat("Distancia",Vector3.Distance(playerTransform.position, transform.position));
    }
}
