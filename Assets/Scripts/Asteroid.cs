using Unity.VisualScripting;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private SolarSystemManager solarSystemManager;
    private void Start()
    {
        solarSystemManager = GameObject.Find("SolarSystemManager").GetComponent<SolarSystemManager>();
        solarSystemManager.celestials.Add(gameObject);
    }
}
