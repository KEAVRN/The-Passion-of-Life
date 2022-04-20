using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptLoader : MonoBehaviour
{
    public void SceneLoad(int index)
    {
        SceneManager.LoadScene(index);
    }
}
