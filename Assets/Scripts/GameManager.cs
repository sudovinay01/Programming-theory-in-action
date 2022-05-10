using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ENCAPSULATION
    public static GameManager Instance { get; private set; }

    [SerializeField] private string currentPlayerName;
    [SerializeField] private int score=0;

    private string bestScorePlayerName;
    private int bestScore;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //ABSTRACTION
    public void SetCurrentPlayersName(string name)
    {
        Instance.currentPlayerName = name;
    }

    public string GetBestScorePlayerName()
    {
        return Instance.bestScorePlayerName;
    }
    public int GetBestScore()
    {
        return Instance.bestScore;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score)
    {
        Instance.score += score;
    }
    public int GetScore()
    {
        return Instance.score;
    }
}
