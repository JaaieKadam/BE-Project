using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSceneManager : MonoBehaviour
{
    public Animator transition;

    public void goToScene(int buildIndex)
    {
        StartCoroutine(fadeToScene(buildIndex));
    }

    IEnumerator fadeToScene(int buildIndex)
    {
        transition.SetTrigger("End");

        yield return new WaitForSeconds(2f);

        UnityEngine.SceneManagement.SceneManager.LoadScene(buildIndex);
    }
}
