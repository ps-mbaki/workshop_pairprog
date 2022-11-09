using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisLibrary;

namespace TennisLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void testGameNotNull()
    {
        Game game = new Game();
        Assert.IsNotNull(game);
        
    }

    [TestMethod]
    public void testScoreIsZero() {
        Game game = new Game();
        List<int> scores = game.getScore();

        // Verify both scores start at 0
        Assert.AreEqual(scores[0], 0);
        Assert.AreEqual(scores[1], 0);
    }

    
}