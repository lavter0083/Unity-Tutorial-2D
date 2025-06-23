using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SetTile : MonoBehaviour
{
    public GameObject tilePerfab;
    public int rows = 5, cols = 5;
    // rows Çà cols ¿­

    public Button[] buttons;

    public GameObject[,] tileArray;

    public static int turretIndex;
    private void Awake()
    {
        //buttons[0].onClick.AddListener(() => ChangeIndex(0));
        //buttons[1].onClick.AddListener(() => ChangeIndex(1));
        //buttons[2].onClick.AddListener(() => ChangeIndex(2));
        //buttons[3].onClick.AddListener(() => ChangeIndex(3));
        //buttons[4].onClick.AddListener(() => ChangeIndex(4));

        for (int k = 0; k < 5; k++)
        {
            int h = k;
            buttons[k].onClick.AddListener(() => ChangeIndex(h));
        }    
    }

    private IEnumerator Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                var pos = new Vector3(j, 0, i);
                GameObject tile = Instantiate(tilePerfab, pos, Quaternion.identity);
                Renderer renderer = tile.GetComponent<Renderer>();
                if ((i + j) % 2 == 0) // Â¦¼ö
                {
                    renderer.material.color = Color.white;
                }
                else
                {
                    renderer.material.color = Color.black;
                }

                    yield return new WaitForSeconds(0.1f);
            }
        }
    }

    void ChangeIndex(int index)
    {
        turretIndex = index;
    }
}
