using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material colorPaint;

    public void ChangeColor(Color newColor)
    {
        colorPaint.SetColor("_Color", newColor);
    }
}
