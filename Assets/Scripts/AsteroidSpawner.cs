using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    #region References

    [Header("References")]
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private GameObject AsteroidPrefab;
    [SerializeField] private TMP_InputField MassInput, SpeedInput, YDirectionInput, XInput, ZInput;

    #endregion

    #region Stats

    [Header("Stats")]
    [SerializeField] [Range(0.5f, 5)] private float FireForce;
    [SerializeField] [Range(0.5f, 500)] private float Mass;
    [SerializeField] private float YRotationAngle;
    [SerializeField] private Quaternion Rotation;
    [SerializeField] private Vector3 Position;
    

    #endregion

    

    private void Update()
    {
        GetStats();
        SetSpawnPoint();
    }

    private void GetStats()
    {
        float.TryParse(MassInput.text, out Mass);
        float.TryParse(SpeedInput.text, out FireForce);
        float.TryParse(YDirectionInput.text, out YRotationAngle);
        float.TryParse(XInput.text, out Position.x);
        float.TryParse(ZInput.text, out Position.z);
    }

    public void SpawnAsteroid()
    {
        GameObject newAsteroid = Instantiate(AsteroidPrefab, SpawnPoint.position, SpawnPoint.rotation);

        Rigidbody rb = newAsteroid.GetComponent<Rigidbody>();
        rb.mass = Mass;
        rb.AddForce(SpawnPoint.forward * FireForce, ForceMode.VelocityChange);
    }

    private void SetSpawnPoint()
    {
        SpawnPoint.position = Position;
        Rotation = Quaternion.Euler(0, YRotationAngle, 0);
        SpawnPoint.rotation = Rotation;
    }

}
