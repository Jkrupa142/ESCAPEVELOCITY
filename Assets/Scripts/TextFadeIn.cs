using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextFadeIn : MonoBehaviour
{
    private TMP_Text text;
    private Image image;

    public float duration = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMP_Text>();
        
        if (text != null)
        {
            Color textColor = text.color;
            Color transparentColor = textColor;
            transparentColor.a = 0;
            text.color = transparentColor;
            text.DOColor(textColor, duration);
        }

        image = GetComponent<Image>();

        if (image != null)
        {
            Color imageColor = image.color;
            Color transparentColor = imageColor;
            transparentColor.a = 0;
            image.color = transparentColor;
            image.DOColor(imageColor, duration);
        }
    }



}
