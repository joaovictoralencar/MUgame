using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Card : MonoBehaviour
{
    public cardColors color = cardColors.Red;
    public int number = 8;

    [Header("Assign Values")]
    public TextMeshProUGUI mainNum;
    public TextMeshProUGUI minorNumUp;
    public TextMeshProUGUI minorNumDown;

    [Header("Assign Materials")]
    public Material redMaterialColor;
    public Material blueMaterialColor;
    public Material yellowMaterialColor;
    public Material greenMaterialColor;


    MeshRenderer mr;
    void Start()
    {

        mr = GetComponentInChildren<MeshRenderer>();
        UpdateColor();
        UpdateText();
    }

    void UpdateText()
    {
        mainNum.text = number.ToString();
        minorNumUp.text = number.ToString();
        minorNumDown.text = number.ToString();
    }

    void UpdateColor()
    {
        switch (color)
        {
            case cardColors.Red:
                mr.material = redMaterialColor;
                break;
            case cardColors.Green:
                mr.material = greenMaterialColor;
                break;
            case cardColors.Blue:
                mr.material = blueMaterialColor;
                break;
            case cardColors.Yellow:
                mr.material = yellowMaterialColor;
                break;
        }

    }
}

public enum cardColors { Red, Green, Blue, Yellow  }