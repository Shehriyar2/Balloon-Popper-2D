using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BalloonSpawner : MonoBehaviour
{
    public float upSpeed;
    int score = 0;
    AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 7f)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown()
    {
        score++;
        scoreText.text = score.ToString();
        audioSource.Play();
        ResetPosition();
    }

    void ResetPosition()
    {
        float randomX = Random.Range(-2.4f , 2.4f);
        transform.position = new Vector2(randomX, -7f);
    }
}
