using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisLibrary;

namespace TennisLibraryTest;

[TestClass]
public class UnitTest1
{

    Game game;

    [TestInitialize]
    public void testInitialize() {
        game = new Game();
    }

    [TestMethod]
    public void testGameNotNull()
    {
        Assert.IsNotNull(game);
        
    }

    [TestMethod]
    public void testScoreIsZero() {
        List<int> scores = game.getScore();

        // Verify both scores start at 0
        Assert.AreEqual(scores[0], 0);
        Assert.AreEqual(scores[1], 0);
    }

    [TestMethod]
    public void testScoreIsNotNull() {
        List<int> scores = game.getScore();

        // Verify both scores start at 0
        Assert.IsNotNull(scores);
    }

    [TestMethod]
    public void testPlayerScoresLargeIndexHandled() {
        Assert.IsFalse(game.playerScores(5));
    }

    [TestMethod]
    public void testPlayerOneScoresPoint() {
        Assert.IsTrue(game.playerScores(0));
        Assert.AreEqual(1, game.getScore()[0]);
    }

    [TestMethod]
    public void testPlayerTwoScoresPoint() {
        game.playerScores(1);
        Assert.AreEqual(1, game.getScore()[1]);
    }

    [TestMethod]
    public void checkGameIsOver() {
        game.playerScores(1);
        game.playerScores(1);
        game.playerScores(1);
        game.playerScores(0);
        game.playerScores(1);

        Assert.IsTrue(game.isOver());
    }

    [TestMethod]
    public void checkGameIsOverDeuce() {
        game.playerScores(1);
        game.playerScores(1);
        game.playerScores(1);
        game.playerScores(0);
        game.playerScores(0);
        game.playerScores(0);
        game.playerScores(1);
        game.playerScores(1);

        Assert.IsTrue(game.isOver());
    }

}