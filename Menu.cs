using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineUI;

public class ButtonScript : MonoBehaviour
{
    public Text buttonText;

    void Start();
    {
       Button button = GetComponent<Button>();
       button.onClick.AddListener(ButtonClick);
    }
    void ButtonClick()
    {
    buttonText.text = "Clicked!";

    }
}
