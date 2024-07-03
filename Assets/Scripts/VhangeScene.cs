using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VhangeScene : MonoBehaviour
{
    public void ChangeScene(int ind)
    {
        SceneManager.LoadScene(ind);
    }
}
