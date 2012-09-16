namespace Craft.Net.Data.Items
{

    public class IronBootsItem : ToolItem, IArmorItem
    {
        public override ushort Id
        {
            get
            {
                return 309;
            }
        }

        public int ArmorBonus
        {
            get { return 2; }
        }

        public ArmorSlot ArmorSlot
        {
            get { return ArmorSlot.Footwear; }
        }
    }
}
