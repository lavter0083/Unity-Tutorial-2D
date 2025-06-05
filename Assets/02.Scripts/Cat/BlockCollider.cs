using UnityEngine;

public class BlockCollider : MonoBehaviour
{
    public GameObject fadeUI;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);  
            Debug.Log("Game Over");
        }
    }
}
