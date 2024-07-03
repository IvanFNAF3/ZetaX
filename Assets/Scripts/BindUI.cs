using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BindUI : MonoBehaviour
{
    public int id;
    public InputField textName;
    public InputField textValue;
    public Text idText;
    private BindManager bm;

    private void Awake() {
        bm = FindObjectOfType<BindManager>();
        textValue.gameObject.SetActive(false);

    }

    public void SaveBind()
    {
        PlayerPrefs.SetString($"{id}_name", textName.text);
        PlayerPrefs.SetString($"{id}_valu", textValue.text);
        textValue.gameObject.SetActive(true);
    }

    public void SaveDescBind()
    {
        PlayerPrefs.SetString($"{id}_name", textName.text);
        PlayerPrefs.SetString($"{id}_valu", textValue.text);
        bm.Init();
    }
}
