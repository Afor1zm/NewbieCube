using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    private Color _color;
    [SerializeField] private Renderer _renderer;
    private void Start()
    {
        _color = GetComponent<Renderer>().material.color;        
    }

    private void Update()
    {
        
    }
}
