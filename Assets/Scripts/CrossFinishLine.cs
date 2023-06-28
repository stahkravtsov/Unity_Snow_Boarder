using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossFinishLine : MonoBehaviour
{
    [SerializeField] private float _timeBeforeReload;    
    [SerializeField] private ParticleSystem _effect;
    [SerializeField] private AudioSource _sound;

    private const string TagPlayer = "Player";
    private const string MessageCrossFinish = "You finised the level opa";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagPlayer))
        {
            _effect.Play();
            _sound.Play();
            Invoke(nameof(ReloadScene), _timeBeforeReload);
        }
    }

    private void ReloadScene()
    {
        Debug.Log(MessageCrossFinish);
        SceneManager.LoadScene(0);
    }
}