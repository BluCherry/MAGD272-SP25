using UnityEngine;

public class PassDamage : MonoBehaviour
{
    public GameObject player;
    public GameObject thisObject;
    private Transform transform;
    public bool finalObject;

    private void Start()
    {
       transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5)
        {
            player.GetComponent<Health>().TakeDamage(1);
            if (finalObject == false)
            {
                thisObject.SetActive(false);
            }
        }
    }
}
