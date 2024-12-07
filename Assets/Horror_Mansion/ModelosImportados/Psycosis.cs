using UnityEngine;
using UHFPS.Tools;
using UHFPS.Rendering;
using static UHFPS.Runtime.GameManager;

namespace UHFPS.Runtime
{
    public class Psycosis : BaseHealthEntity
    {
        private PlayerHealth pHealth;
        private float timer;

        private void Awake()
        {
            pHealth = GetComponent<PlayerHealth>();
        }

        private void Update()
        {

            timer += Time.deltaTime;
            if (timer >= 5)
            {
                //Debug.Log(pHealth.EntityHealth);
                OnApplyPsicosis(2, pHealth.transform); // MADE BY MALTEN & GUILLE
                timer = 0;
            }

        }
        public void OnApplyPsicosis(int damage, Transform sender = null)
        {
            pHealth.UseDamageSounds = false;
            pHealth.OnApplyDamage(damage, sender);


            /*if (UseDamageSounds && DamageSounds.Length > 0)
            {
                int damageSound = GameTools.RandomUnique(0, DamageSounds.Length, lastDamageSound);
                GameTools.PlayOneShot2D(transform.position, DamageSounds[damageSound], DamageVolume, "DamageSound");
                lastDamageSound = damageSound;
            }*/
            if (pHealth.EntityHealth < 40)
            {
                pHealth.targetBlood = 1f;
                pHealth.bloodTime = pHealth.BloodDuration;
            }
        }
    }
}