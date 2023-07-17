using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public ColorManager colorManager;
    private Image _colorImage;
    private Button _colorButton;

    private void Awake()
    {
        _colorImage = GetComponent<Image>();
        _colorButton = GetComponent<Button>();
    }

    void Start()
    {
//        _colorButton.onClick.AddListener(() => colorManager.ChangeColor(_colorImage.color));
    }
}
