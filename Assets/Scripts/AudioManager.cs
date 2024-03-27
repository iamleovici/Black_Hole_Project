using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public static AudioManager Instance;

    public AudioClip UIClick;
    public AudioClip ResetConfirmation;
    public AudioClip hitSound;
    public AudioClip popSound;
    public AudioClip winSound;
    public AudioClip loseSound;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Instance.audioSource.pitch = 1;

    }

    public static void UIClickSound()
    {
        Instance.audioSource.pitch = 1;
        Instance.audioSource.PlayOneShot(Instance.UIClick, 2f);
    }
    public static void WinSFX()
    {
        Instance.audioSource.pitch = 1;
        Instance.audioSource.PlayOneShot(Instance.winSound, 2f);
    }
    public static void LoseSFX()
    {
        Instance.audioSource.pitch = 1;
        Instance.audioSource.PlayOneShot(Instance.loseSound, 2f);
    }


    public static void ResetConfirmationSound()
    {
        Instance.audioSource.pitch = 1;
        Instance.audioSource.PlayOneShot(Instance.ResetConfirmation, 2f);
    }
    public static void HitSFX(float volume, float pitch)
    {
        Instance.audioSource.pitch = pitch;
        Instance.audioSource.PlayOneShot(Instance.hitSound, volume);
    }
    public static void PopSFX()
    {
        Instance.audioSource.pitch = 1;
        Instance.audioSource.PlayOneShot(Instance.popSound, 2f);
    }
}
