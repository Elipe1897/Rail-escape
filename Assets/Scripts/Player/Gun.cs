using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject ImpactEffect;

    public AudioSource shootsound;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();

            shootsound.Play();
           
        }
    }
        void Shoot()
      {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) // if we hit something with the ray it saves the value of the thing it hit and saves it in the hit varible and then in the if statmets it tells what we hit
        {

            Target target = hit.transform.GetComponent<Target>(); 
            if(target != null)
            {
                target.TakeDamage(damage);
            }
           GameObject inpactGo = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inpactGo, 2f);
        }

      }
}