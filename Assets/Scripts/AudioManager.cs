using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;

    public static AudioManager Instance;

    public AudioClip UIClick;
    public AudioClip ResetConfirmation;
    public AudioClip hitSound;
    public AudioClip popSound;
    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioClip buttonClickSound;

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

    }

    public static void UIClickSound()
    {
        Instance.audioSource.PlayOneShot(Instance.UIClick, 2f);
    }
    public static void WinSFX()
    {
        Instance.audioSource.PlayOneShot(Instance.winSound, 2f);
    }
    public static void LoseSFX()
    {
        Instance.audioSource.PlayOneShot(Instance.loseSound, 2f);
    }


    public static void ResetConfirmationSound()
    {
        Instance.audioSource.PlayOneShot(Instance.ResetConfirmation, 2f);
    }
    public static void HitSFX(float volume, float pitch)
    {
        Instance.audioSource2.pitch = pitch;
        Instance.audioSource2.PlayOneShot(Instance.hitSound, volume);
    }
    public static void PopSFX()
    {
        Instance.audioSource.PlayOneShot(Instance.popSound, 2f);
    }
    public static void ButtonPushSFX()
    {
        Instance.audioSource.PlayOneShot(Instance.buttonClickSound, 2f);
    }
    
}
