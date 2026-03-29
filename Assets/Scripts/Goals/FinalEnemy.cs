using UnityEngine;

public class FinalEnemy : MonoBehaviour
{
    public GameObject boss;
    public GameObject thisObject;
    private Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5)
        {
            boss.transform.Translate(0, -4, 0);
            thisObject.SetActive(false);
        }
    }
}
