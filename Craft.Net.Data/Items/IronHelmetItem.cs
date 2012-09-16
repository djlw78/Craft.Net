namespace Craft.Net.Data.Items
{
    public class IronHelmetItem : ToolItem, IArmorItem
    {
        public override ushort Id
        {
            get
            {
                return 306;
            }
        }

        public int ArmorBonus
        {
            get { return 2; }
        }

        public ArmorSlot ArmorSlot
        {
            get { return ArmorSlot.Headgear; }
        }
    }
}
