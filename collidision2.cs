
using UnityEngine;
using UnityEngine.UI;

public class collidision2 : MonoBehaviour
{

    // [SerializeField] ParticleSystem collectParticle = null;

    public GameObject yo;

    public Transform thisscript;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == ("GreenBullet(Clone)"))
        {

            yo = gameObject.Find("Destroyy");

           // invoke(Destroy , 2);
            
        }
        

    }

  


}
