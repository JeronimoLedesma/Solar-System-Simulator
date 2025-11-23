using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{

    readonly float G = 100f;
    GameObject[] celestials;

    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestial");
        InitialVelocity();
    }

    private void FixedUpdate()
    {
        Gravity();
    }

    void Gravity()
    {
        foreach (var body in celestials)
        {
            foreach (var body2 in celestials)
            {
                if (!body.Equals(body2))
                {
                    float m1 = body.GetComponent<Rigidbody>().mass;
                    float m2 = body2.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(body.transform.position, body2.transform.position);

                    body.GetComponent<Rigidbody>().AddForce((body2.transform.position - body.transform.position).normalized *
                        (G * (m1 * m2) / (r * r)));
                }
            }
        }
    }

    void InitialVelocity()
    {
        foreach (var body in celestials)
        {
            foreach (var body2 in celestials)
            {
                if (!body.Equals(body2))
                {
                    float m2 = body2.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(body.transform.position, body2.transform.position);
                    body.transform.LookAt(body2.transform);

                    body.GetComponent<Rigidbody>().linearVelocity += body.transform.right * Mathf.Sqrt((G * m2) / r);
                }
            }
        }
    }
}
