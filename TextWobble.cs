using UnityEngine;
using TMPro;

public class TextWobble : MonoBehaviour
{
    private TMP_Text textMesh;
    private Mesh mesh;
    private Vector3[] vertices;

    public float wobbleSpeed = 2f; // Speed of the wobble
    public float wobbleStrength = 5f; // Strength of the wobble

    private void Start()
    {
        textMesh = GetComponent<TMP_Text>();
        textMesh.ForceMeshUpdate();
    }

    private void Update()
    {
        if(enabled)
        {
            ApplyWobbleEffect();
        }
    }

    void ApplyWobbleEffect()
    {
        textMesh.ForceMeshUpdate();
        mesh = textMesh.mesh;
        vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 offset = Wobble(Time.time + i);
            vertices[i] += offset;
        }

        mesh.vertices = vertices;
        textMesh.canvasRenderer.SetMesh(mesh);
    }

    Vector2 Wobble(float time)
    {
        return new Vector2(Mathf.Sin(time * wobbleSpeed), Mathf.Cos(time * wobbleSpeed * 0.5f)) * wobbleStrength;
    }
}
