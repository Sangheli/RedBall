using UnityEngine;

public class ObjectCollectable : MonoBehaviour
{
    public int value;

    public void Collect()
    {
        gameObject.SetActive(false);
    }
}
