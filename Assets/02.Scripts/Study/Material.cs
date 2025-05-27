using UnityEngine;

public class Study_Material : MonoBehaviour
{
    public Material mat;
    public string hexCode;

    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat;
    
        mat = this.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }
    }
}
