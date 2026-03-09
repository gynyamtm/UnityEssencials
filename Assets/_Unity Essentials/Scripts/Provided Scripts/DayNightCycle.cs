using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds it takes for a full day (360 degrees) to pass.")]
    public float secondsPerDay = 120f;

    // Update is called once per frame
    void Update()
    {
        // Calculate degrees per second: 360 degrees / total seconds
        float rotationAngle = 360f / secondsPerDay;

        // Rotate the light around its local X-axis
        // Multiplied by Time.deltaTime to ensure smooth motion regardless of frame rate
        transform.Rotate(Vector3.right, rotationAngle * Time.deltaTime);
    }
}