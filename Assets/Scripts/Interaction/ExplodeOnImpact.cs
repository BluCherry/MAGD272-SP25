using UnityEngine;

public class ExplodeOnImpact : MonoBehaviour
{
    public GameObject thisObject;

    private void OnCollisionEnter(Collision collision)
    {
        thisObject.SetActive(false);
    }
}
