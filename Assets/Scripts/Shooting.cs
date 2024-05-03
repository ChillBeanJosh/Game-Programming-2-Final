using UnityEngine;

public class Shooting : MonoBehaviour
{
   
   public float damage = 25f;
   public float headshotDamage = 100f;
   public float range = 1000f;

    public Camera fpsCam;

    public ParticleSystem muzzleFlash;
    public AudioSource hitMarker;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
                hitMarker.Play();
            }
 
        }
    }

}
