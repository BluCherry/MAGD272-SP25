using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject player;
    public int minX, maxX, minY;

    void Update()
    {
        var location = player.GetComponent<Transform>();
        if (location.position.x < minX || location.position.x > maxX || location.position.y < minY)
        {
            var respawn = player.GetComponent<Respawn>();
            respawn.useRespawn();
        }
    }
}
