using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel;

    public float fadeTime = 3f;
    private float percent = 0f;

    private float timer = 0f;
    IEnumerator Start()
    {
        while (timer < 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, timer);
            yield return null; 
        }

        
    }

}
