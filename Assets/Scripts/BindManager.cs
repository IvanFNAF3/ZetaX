using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform parent;
    public List<BindUI> allBinds;


    void Start()
    {
        // PlayerPrefs.DeleteAll();
        Init();
    }
    private void Update() {
        // Init();
    }

    public void Init()
    {
        foreach(Transform obj in parent.GetComponentInChildren<Transform>())
        {
            Destroy(obj.gameObject);
        }
        for (int i = 0; i < 10000; i++)
        {
            if(PlayerPrefs.GetString($"{i}_name") != "" || PlayerPrefs.GetString($"{i}_valu") != "")
            {
                print($"ID: {i}\tNAME: {PlayerPrefs.GetString($"{i}_name")}\tDATA: {PlayerPrefs.GetString($"{i}_valu")}");
                var bind = Instantiate(prefab, parent);
                BindUI bindUI = bind.GetComponent<BindUI>();
                bindUI.id = i;
                bindUI.idText.text = i.ToString();
                bindUI.textName.text = PlayerPrefs.GetString($"{i}_name");
                bindUI.textValue.text = PlayerPrefs.GetString($"{i}_valu");
                allBinds.Add(bindUI);
            }
            else
            {
                //print("LOL");
            }
        }
        var bindNew = Instantiate(prefab, parent);
        BindUI bindUINew = bindNew.GetComponent<BindUI>();
        for (int i = 0; i < 100; i++)
        {
            if(PlayerPrefs.GetString($"{i}_name") == "" && PlayerPrefs.GetString($"{i}_valu") == "")
            {
                bindUINew.id = i;
                bindUINew.idText.text = i.ToString();
                break;
            }
        }
        bindUINew.textName.text = "";
        bindUINew.textValue.text = "";
        allBinds.Add(bindUINew);
    }
}
