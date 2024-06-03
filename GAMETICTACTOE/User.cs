using System.Collections.Generic;
using System.Windows.Forms;

public abstract class User
{
    public string UserId { get; private set; }
    protected string UserPassword { get; set; } 

    public User(string id, string pass)
    {
        this.UserId = id;
        this.UserPassword = pass;
    }

    public bool VerifyLogin(string id, string pass)
    {
        return id.Equals(this.UserId) && pass.Equals(this.UserPassword);
    }

    public abstract void UpdatePassword(string newPassword);
}

public class Administrator : User
{
    public List<Player> Players { get; private set; }

    public Administrator(string adminId, string adminPassword) : base(adminId, adminPassword)
    {
        Players = new List<Player>();
    }

    public void CreatePlayer(string playerName, string playerId, string playerPassword)
    {
        Player newPlayer = new Player(playerName, playerId, playerPassword);
        Players.Add(newPlayer);
    }

    public void UpdatePlayerPassword(string playerId, string newPassword)
    {
        Player foundPlayer = Players.Find(p => p.UserId == playerId);

        if (foundPlayer != null)
        {
            foundPlayer.UpdatePassword(newPassword);
            MessageBox.Show("Password updated successfully for player: " + playerId);
        }
        else
        {
            MessageBox.Show("Player not found");
        }
    }

    public override void UpdatePassword(string newPassword)
    {
        
        UserPassword = newPassword;
    }
}

public class Player : User
{
    public string Name { get; private set; }
    public bool IsLoggedIn { get; set; }

    public Player(string name, string userId, string password) : base(userId, password)
    {
        Name = name;
    }

    public override void UpdatePassword(string newPassword)
    {
        UserPassword = newPassword;
    }
}
