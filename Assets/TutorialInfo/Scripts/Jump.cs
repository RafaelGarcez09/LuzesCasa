using UnityEngine;
using UnityEngine.VFX;
public class Jumpscript : MonoBehaviour
{
    
    public VisualEffect Jump;

    void Start()
    {
        
        Jump.Stop();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Jump.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump.Stop();
        }
    }
}



