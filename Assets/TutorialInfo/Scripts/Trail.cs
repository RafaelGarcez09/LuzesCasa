using UnityEngine;
using UnityEngine.VFX;
public class Trail : MonoBehaviour
{
    public VisualEffect rastro;

    void Start()
    {
        rastro.Stop();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        
           {
                rastro.Play();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                rastro.Stop();
            }
       
    }
}

 

