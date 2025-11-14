using UnityEngine;

public class SimpleFloat : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;

    public Material material;


    private void Update()
    {
        float offsetX =Time.time * speed;
        float offsetY =Time.time * speed;

        material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }
}
