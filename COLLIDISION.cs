
using UnityEngine;

public class COLLIDISION : MonoBehaviour
{


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == ("Bullet(Clone)"))
        {
            Destroy(gameObject);//.name("Player1")


        }
        if (collisionInfo.collider.name == ("eyes"))
        {
            Destroy(gameObject);

        }
        if(collisionInfo.collider.name == ("Enemy"))
        {
            Destroy(gameObject);
        }

    }



  
    void Start()
    {
        
    }
}
