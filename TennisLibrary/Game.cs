namespace TennisLibrary;
public class Game
{
    int playerOneScore;
    int playerTwoScore;
    bool over;

    List<int> scores;

    public Game() {
        playerOneScore = 0;
        playerTwoScore = 0;

        scores = new List<int>();

        scores.Add(playerOneScore);
        scores.Add(playerTwoScore);
        over = false;
    }

    public List<int> getScore() {
        return scores;
    }

    public bool isOver(){
        return over;
    }

    public bool playerScores(int playerIndex) {
        if (playerIndex > 1 || playerIndex < 0 || over)
        {
            return false;
        }
        scores[playerIndex] = scores[playerIndex] + 1;
        checkWin();
        return true;
    }
    
    public bool checkWin() {
        if(scores[0] >= scores[1] + 2 && scores[0] >= 4) {
            over = true;
            return true;
        }
        else if(scores[1] >= scores[0] + 2 && scores[1] >= 4){
            over = true;
            return true;
        }
        return false;
    }

}
