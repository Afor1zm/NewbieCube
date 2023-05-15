using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Color _secondColor;
    [SerializeField] private List<Renderer> _renderers = new List<Renderer>();
    private Renderer renderer;
    private float RedColor, GreenColor, BlueColor;
    private float gradient = 0;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = _color;
        float Blend = 0.5f;
        RedColor = renderer.material.color.r + (_secondColor.r - renderer.material.color.r) * Blend;
        GreenColor = renderer.material.color.g + (_secondColor.g - renderer.material.color.g) * Blend;
        BlueColor = renderer.material.color.b + (_secondColor.b - renderer.material.color.b) * Blend;
        //renderer.material.color = new Color(RedColor, GreenColor, BlueColor, 1);
        foreach (var item in _renderers)
        {
            item.material.color = new Color(0, 0, 0, 1);
        }
    }

    private void FixedUpdate()
    {
        renderer.material.color = Color.Lerp(renderer.material.color, new Color(RedColor,GreenColor,BlueColor,1), 0.05f);
        //Debug.Log($"current color {renderer.material.color}");
    }
}
