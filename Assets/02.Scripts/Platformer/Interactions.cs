using System.Collections;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public enum InteractionType { SIGN, DOOR, NPC}
    public InteractionType type;

    public SoundController soundController;

    public GameObject popUp;

    public FadeRoutine fade;

    public GameObject map;
    public GameObject house;

    public Vector3 indoorPos;
    public Vector3 outdoorPos;
    public bool isHouse;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popUp.SetActive(false);
            popUp.SetActive(false);
        }
    }

    void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.SIGN:
                popUp.SetActive(true);
                break;
            case InteractionType.DOOR:
                StartCoroutine(DoorRoutine(player));
                break;
            case InteractionType.NPC:
                popUp.SetActive(true);
                break;
        }
    }

    IEnumerator DoorRoutine(Transform player)
    {
        soundController.EventSoundPlay("DoorOpen");

        yield return StartCoroutine(fade.Fade(0.5f, Color.black, true));

        if (!isHouse)
        {
            player.transform.position = indoorPos;
            map.SetActive(false);
            house.SetActive(true);
        }

        else
        {
            player.transform.position = outdoorPos;
            map.SetActive(true);
            house.SetActive(false);
        }

        isHouse = !isHouse;


        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(fade.Fade(0.5f, Color.black, false));
        soundController.EventSoundPlay("DoorClose");
    }
}
