using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore = 0;
    private int _opponentScore = 0;

    public Ball ball;
    public Text playerScoreText;
    public Text opponentScoreText;

    public void PlayerScore()
    {
        _playerScore++;

        playerScoreText.text = _playerScore.ToString();
        
        ball.ResetPosition();
    }

    public void OpponentScore()
    {
        _opponentScore++;
        
        opponentScoreText.text = _opponentScore.ToString();
        
        ball.ResetPosition();
    }
}
