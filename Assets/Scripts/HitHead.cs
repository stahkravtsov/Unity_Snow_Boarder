using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class HitHead : MonoBehaviour
{
    private const string TagSnow = "Snow";
    [SerializeField] private Collider2D _headHead;
    [SerializeField] private Collider2D _snow;
    [SerializeField] private float _timeBeforeReload;
    [SerializeField] private ParticleSystem _effect;
    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioSource _soundKillEnemy;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("fff");
        Debug.Log("148891298598146450763456");
        if (other.gameObject.CompareTag(TagSnow) && _headHead.IsTouching(_snow))
        {
            _effect.Play();
            _sound.Play();
            Invoke(nameof(ReloadScene), _timeBeforeReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}