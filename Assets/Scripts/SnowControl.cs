using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowControl : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    
    void Start()
    {
        _particle.Play();
        Debug.Log($"Hello Git");
    }
}
