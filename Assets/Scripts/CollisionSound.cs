using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public float volumeCompressor = 10f;
    public float maxVolume = 3f;

    public float minPitch;
    public float maxPitch;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float collisionSpeed = collision.relativeVelocity.magnitude;

        float volume = collisionSpeed / volumeCompressor;
        float pitch = Random.Range(minPitch, maxPitch);

        if (volume > maxVolume)
        {
            volume = maxVolume;
        }
        AudioManager.HitSFX(volume, pitch);
    }
}
