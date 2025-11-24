using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    private Animator anim;
    private bool on = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            on = !on;
            anim.SetBool("On", on);
        }
        if (Input.GetMouseButtonDown(0))
        {
            on = false;
            anim.SetBool("On", on);
        }
    }
}
