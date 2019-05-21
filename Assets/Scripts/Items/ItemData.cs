using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;

        switch (itemID)
        {
            #region Food 0-99
            case 0:
                name = "Meat";
                value = 15;
                description = "It comes from animals";
                icon = "Meat_Icon";
                mesh = "Meat Mesh";
                type = ItemType.Food;
                heal = 17;
                amount = 1;
                break;

            case 1:
                name = "Chicken";
                value = 10;
                description = "From a bird";
                icon = "Chicken_Icon";
                mesh = "Chicken Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;

            case 2:
                name = "Bread";
                value = 1;
                description = "Have daily";
                icon = "Bread_Icon";
                mesh = "Bread Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;


            #endregion
            #region Weapon 100-199
            case 100:
                name = "Short Sword";
                value = 25;
                description = "Stick em with the pointy end";
                icon = "ShorSword_Icon";
                mesh = "ShortSword Mesh";
                type = ItemType.Weapon;
                damage = 15;
                amount = 1;
                break;

            case 101:
                name = "Long Sword";
                value = 50;
                description = "Size matters";
                icon = "LongSword_Icon";
                mesh = "LongSword Mesh";
                type = ItemType.Weapon;
                damage = 25;
                amount = 1;
                break;

            case 102:
                name = "Axe";
                value = 75;
                description = "Big and beasty";
                icon = "Axe_Icon";
                mesh = "Axe Mesh";
                type = ItemType.Weapon;
                damage = 30;
                amount = 1;
                break;

            #endregion
            #region Apparel 200-299
            case 200:
                name = "Peasant Cap";
                value = 15;
                description = "For the simple life";
                icon = "PeasantHat_Icon";
                mesh = "PeasantHat Mesh";
                type = ItemType.Apparel;
                armour = 2;
                amount = 1;
                break;

            case 201:
                name = "Steel Helm";
                value = 50;
                description = "A pot for your noggin";
                icon = "SteelHelm_Icon";
                mesh = "SteelHelm Mesh";
                type = ItemType.Apparel;
                armour = 10;
                amount = 1;
                break;

            case 202:
                name = "Great Helm";
                value = 100;
                description = "A lordly helm";
                icon = "GreatHelm_Icon";
                mesh = "GreatHelm Mesh";
                type = ItemType.Apparel;
                armour = 20;
                amount = 1;
                break;

            #endregion
            #region Crafting 300-399
            case 300:
                name = "Spring";
                value = 2;
                description = "A metal spring";
                icon = "Spring_Icon";
                mesh = "Spring Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            case 301:
                name = "Mirror";
                value = 4;
                description = "Don't break its bad luck";
                icon = "Mirror_Icon";
                mesh = "Mirror Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            case 302:
                name = "Nut";
                value = 1;
                description = "essential for anything that is supposed to stay together";
                icon = "Nut_Icon";
                mesh = "Nut Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            #endregion
            #region Quest 400-499

            case 400:
                name = "Crystal Ball";
                value = 150;
                description = "Can you see the future yet";
                icon = "CrystalBall_Icon";
                mesh = "CrystalBall Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;

            case 401:
                name = "Staff";
                value = 240;
                description = "More than just a walking aid";
                icon = "Staff_Icon";
                mesh = "Staff Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;

            case 402:
                name = "Tome";
                value = 485;
                description = "Where knowledge is stored";
                icon = "Tome_Icon";
                mesh = "Tome Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            #endregion
            #region Currency 500-599
            #endregion
            #region Ingredients 600-699

            case 600:
                name = "Blueberries";
                value = 3;
                description = "Taken from bushes";
                icon = "Blueberries_Icon";
                mesh = "Blueberries Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;

            case 601:
                name = "Mushroom";
                value = 2;
                description = "Grows in much";
                icon = "Mushroom_Icon";
                mesh = "Mushroom Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;

            case 602:
                name = "Flower";
                value = 5;
                description = "Its pretty";
                icon = "Flower_Icon";
                mesh = "Flower Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;
            #endregion
            #region Potions 700-799

            case 700:
                name = "Green Health";
                value = 25;
                description = "a little pick me up";
                icon = "GreenHealth_Icon";
                mesh = "GreenHealth Mesh";
                type = ItemType.Potions;
                heal = 25;
                amount = 1;
                break;

            case 701:
                name = "Blue Health";
                value = 75;
                description = "For Broken arms and punctured Spleens";
                icon = "BlueHealth_Icon";
                mesh = "BlueHealth Mesh";
                type = ItemType.Potions;
                heal = 50;
                amount = 1;
                break;

            case 702:
                name = "Red Health";
                value = 150;
                description = "For near death experiences";
                icon = "RedHealth_Icon";
                mesh = "RedHealth Mesh";
                type = ItemType.Potions;
                heal = 80;
                amount = 1;
                break;
            #endregion
            #region Scrolls 800-899

            case 800:
                name = "Blank Scroll";
                value = 2;
                description = "It says nothing";
                icon = "BlankScroll_Icon";
                mesh = "BlankScroll Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;

            case 801:
                name = "Historical Scroll";
                value = 150;
                description = "Brief account of local history";
                icon = "HistoricalScroll_Icon";
                mesh = "HistoricalScroll Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;

            case 802:
                name = "Shipping Manifest";
                value = 50;
                description = "A list of items being sent to far away places";
                icon = "ShippingManifest_Icon";
                mesh = "ShippingManifest Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;
            #endregion

            default:
                itemID = 4;
                name = "Apple";
                value = 1;
                description = "Muchie and crunchy";
                icon = "Apple_Icon";
                mesh = "Apple Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;

        }
        Item temp = new Item
        {
            Name = name,
            Description = description,
            ID = itemID,
            Value = value,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Heal = heal,
            Type = type,
            Mesh = Resources.Load("Prefabs/" + mesh) as GameObject,
            Icon = Resources.Load("Icon/" + icon) as Texture2D


        };
        return temp;
    }
}
