using UnityEngine;

public class particlestop : MonoBehaviour {
    private ParticleSystem stars;
    public float time = 2f;
	// Use this for initialization
	void Start () {
        stars = GetComponent<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update () {
        stars.Pause();
	}
}
