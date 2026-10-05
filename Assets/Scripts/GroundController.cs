using UnityEngine;
using UnityEngine.Video;

public class GroundController : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public Material winMaterial;
    public VideoPlayer video;
    public AudioSource GBM;
    public PlayerController playerScript; 

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.count == 12)
        {
            GBM.Stop();
            meshRenderer.material = winMaterial;
            video.Play();
        }
    }
}
