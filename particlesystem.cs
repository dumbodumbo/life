using UnityEngine;

public class particlesystem : MonoBehaviour
{

    [SerializeField] ParticleSystem collectParticle = null;





    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == ("GreenBullet(Clone)"))
        {
            // Destroy(gameObject);//.name("Player1")

            Collect();
        }


    }

    public void Collect()
    {
        collectParticle.Play();
    }


}
