using System;

[System.Serializable]
public class PlayerScore : IComparable<PlayerScore>
{
    // Each Player Score has a Name(Initials) and a Score
    public string playerName;

    public int score;

    // Constructor for PlayerScore <Name,Score>
    public PlayerScore(string playerName, int score)
    {
        this.playerName = playerName;
        this.score = score;
    }

    // CompareTo used in IComparable which is used later on to Sort Player Score By Highest to Lowest
    public int CompareTo(PlayerScore other)
    {
        if (other == null)
        {
            return 1;
        }

        return score - other.score;
    }
}