using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjsda
{
    internal class Scripts
    {

        public static string teleportToRandomScript = "" +
            "local currentPlayer = game:GetService('Players').LocalPlayer.Name" +
            "\nlocal players = {}" +
            "\nlocal index = 1" +
            "\nfor i, v in pairs(game:GetService('Players'):GetPlayers()) do" +
            "\n   table.insert(players, index, v.Name)" +
            "\n   index = index + 1" +
            "\nend" +
            "\nlocal randomPlayer = players[math.random(1, #players)]" +
            "\nlocal localPlayerCharacter = game.Workspace[currentPlayer]" +
            "\nlocalPlayerCharacter.HumanoidRootPart.CFrame = game.Workspace[randomPlayer].HumanoidRootPart.CFrame" +
            "";
        public static string superJumpAndSpeed = "" +
            "local currentPlayer = game:GetService('Players').LocalPlayer.Name" +
            "\ngame.Workspace[currentPlayer].Humanoid.WalkSpeed = 200" +
            "\ngame.Workspace[currentPlayer].Humanoid.JumpPower = 200" +
            "\n" +
            "\n" +
            "\n";
        public static string teleportJump = "" +
            "local currentPlayer = game:GetService('Players').LocalPlayer.Name" +
            "\nlocal character = game.Workspace[currentPlayer].HumanoidRootPart" +
            "\nlocal c = character.CFrame" +
            "\ncharacter.CFrame = CFrame.new(c.X, c.Y + 100, c.Z)" +
            "\n" +
            "\n";
    }
}
