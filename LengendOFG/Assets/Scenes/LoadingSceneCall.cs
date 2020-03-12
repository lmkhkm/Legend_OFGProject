using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneCall : MonoBehaviour
{

    public static string nextScene;
    public Slider loadingSlider;
    public Text percentText;

    private void Start()
    {
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }
    
    IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation asyncOp = SceneManager.LoadSceneAsync(nextScene);
        asyncOp.allowSceneActivation = false;

        while(!asyncOp.isDone)
        {
            yield return null;


            if (loadingSlider.value < 0.9f)
            {
                loadingSlider.value = asyncOp.progress;
                percentText.text = (asyncOp.progress * 100) + " " + "%";
            }
            else
            {
                loadingSlider.value += 0.01f;
                yield return new WaitForSeconds(0.05f);
                percentText.text = (loadingSlider.value * 100f).ToString() + " " + "%";

                if (loadingSlider.value == 1.0f)
                {
                    percentText.text = "100%";
                    yield return new WaitForSeconds(0.5f);
                    asyncOp.allowSceneActivation = true;
                    yield break;
                }
            }

        }
    }

}
