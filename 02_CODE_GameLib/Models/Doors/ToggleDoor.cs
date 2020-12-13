using System;

namespace CODE_GameLib.Models.Doors
{
    public class ToggleDoor : Door
    {
        public override ConsoleColor Color { get; set; } = ConsoleColor.White;

        public override bool Enter(Player player)
        {
            return Open;
        }
    }
}