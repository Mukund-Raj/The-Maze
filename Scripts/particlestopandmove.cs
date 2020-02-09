using UnityEngine;

public class particlestopandmove : MonoBehaviour {

    private ParticleSystem stars;
    public Vector3 speed;
    //public float time = 2f;
    // Use this for initialization
    void Start()
    {
        stars = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        stars.Pause();
        transform.Rotate(speed * Time.deltaTime * .2f);
    }
}
