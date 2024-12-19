using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public GameObject prefab;
    public void OnClick()
    {
        Instantiate(prefab, new Vector3(10, 0, 0), Quaternion.identity);
    }
}
