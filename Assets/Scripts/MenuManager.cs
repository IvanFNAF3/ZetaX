using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ChangeToMain()
    {
        anim.SetTrigger("main");
    }

    public void ChangeToBind()
    {
        anim.SetTrigger("bind");
    }
}
