using UnityEngine;

public class LevelGoal : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer.enabled == false)
        {
            var sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
            sceneController.loadNextScene();
        }
    }
}
