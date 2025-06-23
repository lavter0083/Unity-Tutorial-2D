using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameObject[] turretPreFab;

    private void OnMouseDown()
    {
        Instantiate(turretPreFab[SetTile.turretIndex], transform.position, Quaternion.identity);
        //          생성 대상        생성 위치           생성 회전 상태

    }
}
