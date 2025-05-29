using UnityEngine;

public class Pinball : MonoBehaviour
{
    public PinballManager pinballManager; // À¯´ÏÆ¼»ó¿¡¼­ ÇÒ´ç ÇÊ¿ä

    private void OnCollisionEnter2D(Collision2D other)
    {
        int score = 0;
        switch (other.gameObject.tag)
        {
            case "10Score":
                score += 10;
                break;
            case "30Score":
                score += 30;
                break;
            case "50Score":
                score += 50;
                break;
        }

        pinballManager.totalScore += score;
        if (score !=0)
            Debug.Log($"{score} Á¡ È¹µæ");

        //if (other.gameObject.CompareTag("10Score"))
        //{
        //    pinballManager.totalScore += 10;
        //    Debug.Log("10Á¡ È¹µæ");
        //}
        //else if (other.gameObject.CompareTag("30Score"))
        //{
        //    pinballManager.totalScore += 30;
        //    Debug.Log("30Á¡ È¹µæ");
        //}
        //else if (other.gameObject.CompareTag("50Score"))
        //{
        //    pinballManager.totalScore += 50;
        //    Debug.Log("50Á¡ È¹µæ");//*
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"°ÔÀÓÁ¾·á : ÇöÀç Á¡¼ö {pinballManager.totalScore}");
        }
    }
}

