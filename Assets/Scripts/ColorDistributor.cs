using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDistributor : MonoBehaviour
{
    [SerializeField] private Color intervalColor = new Color();
    [SerializeField] private Color _finalColor = new Color();
    [SerializeField] private Color _startColor = new Color();
    [SerializeField] private Color[] _intervalColors = new Color[3];
    public void GenerateFinalColor()
    {
        _finalColor = GenerateRandomColor();
    }

    public void GenerateStartColor()
    {
        int randomIntervalColor = Random.Range(0, _intervalColors.Length);
        intervalColor = _intervalColors[randomIntervalColor];
        float Blend = 0.5f;
        float RedColor = (_finalColor.r / Blend) - intervalColor.r;
        float GreenColor = (_finalColor.g / Blend) - intervalColor.g;
        float BlueColor = (_finalColor.b / Blend) - intervalColor.b;
        _startColor = new Color(RedColor, GreenColor ,BlueColor,1f);
    }

    public void GenerateIntervalColor(int count)
    {
        _intervalColors[count] = GenerateRandomColor();
    }

    private Color GenerateRandomColor()
    {
        float r = Random.Range(0, 1f);
        float g = Random.Range(0, 1f);
        float b = Random.Range(0, 1f);
        intervalColor = new Color(r, g, b, 1);
        return intervalColor;
    }

    private void OnEnable()
    {
        PlayerColorChanger.OnLevelStarted += SendStartColor;
    }

    private void OnDisable()
    {
        PlayerColorChanger.OnLevelStarted -= SendStartColor;
    }

    private void Awake()
    {
        GenerateFinalColor();
        for (int i = 0; i < _intervalColors.Length; i++)
        {
            GenerateIntervalColor(i);
        }
        GenerateStartColor();
    }

    private void SendStartColor(PlayerColorChanger playerColorChanger)
    {
        playerColorChanger.ChangeColor(_startColor);
    }

    
}
