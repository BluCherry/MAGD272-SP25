using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        var location = player.GetComponent<Transform>();
        if (location.position.x < -14 || location.position.x > 27 || location.position.y < -9)
        {
            var respawn = player.GetComponent<Respawn>();
            respawn.useRespawn();
        }
    }
}
