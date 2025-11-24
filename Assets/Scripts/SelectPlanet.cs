using UnityEngine;

public class SelectPlanet : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void Select()
    {
        panel.SetActive(true);
    }
}
