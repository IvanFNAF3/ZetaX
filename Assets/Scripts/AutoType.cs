using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoType : MonoBehaviour
{
    [SerializeField] private float letterSpeed;
    public string displayText;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        displayText = text.text;
        text.text = "";
        StartCoroutine(DisplayText());
    }

    public IEnumerator DisplayText()
    {
        text.text = text.text + $"\n\n";
        foreach (char a in displayText.ToCharArray())
        {
            yield return new WaitForSeconds(letterSpeed);
            text.text += a;
        }
    }
}
