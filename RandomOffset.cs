using UnityEngine;

public class RandomOffset : MonoBehaviour
{
    [Header("Offset Settings")]
    [Tooltip("Maximum distance from original position in each axis.")]
    public Vector3 offsetDistance = new Vector3(1f, 1f, 1f);

    [Tooltip("How fast the object moves around (frequency).")]
    public float offsetSpeed = 1f;

    [Header("Random Seed Settings")]
    [Tooltip("Set an integer seed. If 0, a random seed will be generated.")]
    public int randomSeed = 0;

    private Vector3 _originalPos;
    private float _seedOffset;

    void Start()
    {
        _originalPos = transform.localPosition;

        if (randomSeed == 0)
        {
            // Auto-generate different seed for each object if left at 0
            _seedOffset = Random.Range(0f, 1000f);
        }
        else
        {
            // Convert integer seed into a usable float offset
            _seedOffset = randomSeed * 100f;
        }
    }

    void Update()
    {
        float t = Time.time * offsetSpeed + _seedOffset;

        float x = (Mathf.PerlinNoise(t, 0f) - 0.5f) * 2f * offsetDistance.x;
        float y = (Mathf.PerlinNoise(0f, t) - 0.5f) * 2f * offsetDistance.y;
        float z = (Mathf.PerlinNoise(t, t) - 0.5f) * 2f * offsetDistance.z;

        transform.localPosition = _originalPos + new Vector3(x, y, z);
    }
}
