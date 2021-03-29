using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldRule : MonoBehaviour
{
    private TMP_InputField inputField;
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    void Update()
    {
        if(inputField.text != "" )
        {
            if (int.Parse(inputField.text) > 100) //limit players input
                inputField.text = 100.ToString();
            else if (int.Parse(inputField.text) < 1)
                inputField.text = 1.ToString();
        }
    }
    
}
