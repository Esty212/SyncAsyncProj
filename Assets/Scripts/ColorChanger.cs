using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Button _activationButton;

    private void Awake()
    {
        _activationButton.onClick.AddListener(OnClick);
    }


    private void OnClick()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        float red = Random.Range(0f, 1f);
        float green = Random.Range(0f, 1f);
        float blue = Random.Range(0f, 1f);
        _activationButton.image.color = new Color(red, green, blue);
    }
}
