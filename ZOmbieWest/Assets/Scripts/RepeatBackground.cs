using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{   
    public float scroll_Speed = 0.08f;
    private MeshRenderer mesh_Renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Time.time * scroll_Speed;
        Vector2 offset = new Vector2(0,y);
        
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
