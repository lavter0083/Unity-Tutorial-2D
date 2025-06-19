using UnityEngine;

public class NOTCoin : MonoBehaviour, IItem
{
    private Inventory inventory;

    public enum CoinType { Coin, Ruppy }
    public CoinType coinType;

    public float price;

    public GameObject Obj { get; set; }

    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();

        Obj = gameObject;
    }

    void OnMouseDown()
    {
        Get();
    }

    public void Get()
    {
        Debug.Log($"{this.name}¿ª »πµÊ«ﬂΩ¿¥œ¥Ÿ.");

        inventory.AddItem(this);

        gameObject.SetActive( false );
    }
}
