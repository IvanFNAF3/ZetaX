using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// [RequireComponent(typeof(AutoType))]
public class BindFinder : MonoBehaviour
{
    private AutoType at;
    private InputField command;

    void Start()
    {
        at = FindObjectOfType<AutoType>();
        command = GetComponent<InputField>();
    }

    public void Find()
    {
        for(int i = 0; i < 10000; i++)
        {
            if(PlayerPrefs.GetString($"{i}_name") == command.text)
            {
                at.displayText = $"Переменная: {PlayerPrefs.GetString($"{i}_name")}\n---------------------------------------\n{PlayerPrefs.GetString($"{i}_valu")}";
                StartCoroutine(at.DisplayText());
                break;
            }
        }

        if(command.text == "/clear")
        {
            at.text.text = "";
        }
        else if(command.text == "/info")
        {
            at.displayText = $"ZetaX beta 1.0.0 - приложение, которое помогает удобно передвигаться по твоим записанным данным с помощью переменных.\n\nЧтобы начать использовать ZetaX вам нужно создать новый бинд с помощью плюса справа сверху.";
            StartCoroutine(at.DisplayText());
        }
        else if(command.text.StartsWith("/fontsize"))
        {
            string[] inputSplit = command.text.Split(' ');
            string _fontsize = inputSplit[1];
            if(int.TryParse(_fontsize, out int value))
            {
                at.text.fontSize = value;
            }
        }
    }
}
