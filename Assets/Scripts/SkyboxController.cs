using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }
}
