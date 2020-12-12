namespace CODE_GameLib.Models.Doors
{
    public class ClosingGateDoor : Door
    {
        public override string Color { get; set; } = "white";

        public override bool Enter(Player player)
        {
            if (!Open)
            {
                return false;
            }

            Toggle();
            return true;
        }

        public override bool CanEnter(Player player)
        {
            return Open;
        }
    }
}