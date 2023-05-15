using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Color _defaultColor;
    private Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = _defaultColor;
    }
    void FixedUpdate()
    {
        _renderer.material.color = Color.Lerp(_renderer.material.color, _color, 0.01f);
    }


}
