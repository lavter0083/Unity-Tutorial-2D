using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalSet : MonoBehaviour
{
    public FadeRoutine fade;

    public GameObject portalEffect;
    public GameObject loadingImage;

    public Image progressBar;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PortalRoutine());
        }
    }

    IEnumerator PortalRoutine()
    {
        portalEffect.SetActive(true);

        yield return StartCoroutine(fade.Fade(3f, Color.white, true));

        // 로딩창

        loadingImage.SetActive(true);
        yield return StartCoroutine(fade.Fade(3f, Color.white, false));

        while (progressBar.fillAmount < 1f)
        {
            progressBar.fillAmount += Time.deltaTime * 0.3f;
            yield return null;
        }
        // 씬 변경

        SceneManager.LoadScene(1);

        // 페이드 오프


    }
}