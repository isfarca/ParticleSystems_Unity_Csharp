using UnityEngine;

public class ParticleSystems : MonoBehaviour
{
    // Value types
    private int randomNumber;

    // Reference types
    private ParticleSystem particleSystemEffect;

    /// <summary>
    /// Get the particle system component.
    /// </summary>
    private void Awake()
    {
        particleSystemEffect = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update()
    {
        // When the particle system stopped, than generate a random number.
        if (particleSystemEffect.isStopped)
        {
            // Generate random number.
            randomNumber = Random.Range(0, 100);
            Debug.Log(randomNumber);

            // When the random number is five, than play the particle system.
            if (randomNumber == 5)
                particleSystemEffect.Play();
        }
    }
}
