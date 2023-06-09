using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] AudioClip openingDoorSFX, closingDoorSFX;
    [SerializeField] float secondsToLoad = 0.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("Open", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("Open", false);
    }

    public void StartLoadingNextLevel()
    {
        GetComponent<Animator>().SetBool("Open", false);
        AudioSource.PlayClipAtPoint(closingDoorSFX, Camera.main.transform.position);

        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(secondsToLoad);

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    private void PlayOpeningDoorSFX()
    {
        AudioSource.PlayClipAtPoint(openingDoorSFX, Camera.main.transform.position);
    }
}
