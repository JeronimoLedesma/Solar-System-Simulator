using TMPro;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    public GameObject Planet;
    public TMP_InputField newMass;
    private float mass;
    
    public void ChangeMass()
    {
        if (float.TryParse(newMass.text, out mass))
        {
            Planet.GetComponent<Rigidbody>().mass = mass;
        }
        else
        {
            return;
        }

    }
}
