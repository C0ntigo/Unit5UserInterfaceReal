using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget ()
    {
        while (true) 
        {
            UpdateScore(5);
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
