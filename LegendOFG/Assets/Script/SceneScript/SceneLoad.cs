using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneLoadByLoading(string sceneName)
    {
        LoadingSceneCall.LoadScene(sceneName);

    }
}
