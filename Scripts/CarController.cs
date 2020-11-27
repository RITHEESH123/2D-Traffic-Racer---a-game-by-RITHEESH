using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 myPosition;
    private AudioSource audioSource;
    private Text scoreText;
    private int score;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        myPosition = transform.position;
        StartCoroutine(IncreaseScore());
    }

    // Update is called once per frame
    void Update()
    {
        myPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = myPosition;
    }

    public void MoveRight()
    {
        myPosition.x += speed * Time.deltaTime;
        transform.position = myPosition;
    }
    public void MoveLeft()
    {
        myPosition.x -= speed * Time.deltaTime;
        transform.position = myPosition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            audioSource.Play();
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator IncreaseScore()
    {
        yield return new WaitForSeconds(1f);
        score++;
        scoreText.text = "Score : " + score;

        StartCoroutine(IncreaseScore());

    }
}
