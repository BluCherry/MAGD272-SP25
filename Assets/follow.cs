// Source - https://stackoverflow.com/a/65821523
// Posted by Zaphod, modified by community. See post 'Timeline' for change history
// Retrieved 2026-02-11, License - CC BY-SA 4.0

using UnityEngine;

public class Follow_player : MonoBehaviour
{
    public Transform player;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        pos = player.transform.position + new Vector3(0, 1, -5);

        transform.position = pos;
    }
}
