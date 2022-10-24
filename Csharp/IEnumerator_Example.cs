using System;
using System.Collections;

public class Player
{
    private string name;

    public Player()
    {
        name = "NoNamed";
    }

    public Player(string _name)
    {
        name = _name;
    }

    public string GetName()
    {
        return name;
    }
};

public class Group : IEnumerable
{
    private Player[] players;
    private string group_name;

    public Group(string _group_name)
    {
        group_name = _group_name;
        players = new Player[0];
    }

    public Group(string _group_name, Player[] _players)
    {
        group_name = _group_name;
        players = new Player[_players.Length];

        for (int index = 0; index < _players.Length; index++)
        {
            players[index] = _players[index];
        }
    }

    public Player[] GetPlayers()
    {
        return players;
    }

    public string GetGroupName()
    {
        return group_name;
    }

    public IEnumerator GetEnumerator()
    {
        return new PlayerEnum(players);
    }
}

public class PlayerEnum : IEnumerator
{
    private Player[] players;
    private int position = -1;

    public PlayerEnum(Player[] _players)
    {
        players = _players;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Player Current
    {
        get
        {
            return players[position];
        }
    }


    public bool MoveNext()
    {
        position++;
        return position < players.Length;
    }

    public void Reset()
    {
        position = -1;
    }
}


public class IEnumeratorTest
{
    static void Main(string[] args)
    {
        Player[] players;
        Group playerGroup;

        players = new Player[3]
        {
            new Player("Song"),
            new Player("Kim"),
            new Player("Lee")
        };

        playerGroup = new Group("Players", players);

        foreach (Player player in playerGroup)
        {
            Console.WriteLine(player.GetName());
        }
    }
}