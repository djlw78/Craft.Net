namespace Craft.Net.Data.Items
{
    public class IronPickaxeItem : ToolItem
    {
        public override ushort Id
        {
            get
            {
                return 257;
            }
        }

        public override int AttackDamage
        {
            get { return 4; }
        }
    }
}
