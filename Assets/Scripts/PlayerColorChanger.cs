using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    public static Action<PlayerColorChanger> OnLevelStarted;
    public void ChangeColor(Color color)
    {
        _renderer.material.color = color;
    }

    private void Start()
    {
        OnLevelStarted?.Invoke(this);
    }
}
