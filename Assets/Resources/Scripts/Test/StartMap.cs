using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMap : MonoBehaviour
{
    public void StartSession()
    {
        SceneManager.LoadScene(0);
    }
}
