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
                icon = "Food/Meat_Icon";
                mesh = "Food/Meat_Mesh";
                type = ItemType.Food;
                heal = 17;
                amount = 1;
                break;

            case 1:
                name = "Chicken";
                value = 10;
                description = "From a bird";
                icon = "Food/Chicken_Icon";
                mesh = "Food/Chicken_Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;

            case 2:
                name = "Bread";
                value = 1;
                description = "Have daily";
                icon = "Food/Bread_Icon";
                mesh = "Food/Bread_Mesh";
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
                icon = "Weapon/ShorSword_Icon";
                mesh = "Weapon/ShortSword_Mesh";
                type = ItemType.Weapon;
                damage = 15;
                amount = 1;
                break;

            case 101:
                name = "Long Sword";
                value = 50;
                description = "Size matters";
                icon = "Weapon/LongSword_Icon";
                mesh = "Weapon/LongSword_Mesh";
                type = ItemType.Weapon;
                damage = 25;
                amount = 1;
                break;

            case 102:
                name = "Axe";
                value = 75;
                description = "Big and beasty";
                icon = "Weapon/Axe_Icon";
                mesh = "Weapon/Axe_Mesh";
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
                icon = "Apparel/PeasantHat_Icon";
                mesh = "Apparel/PeasantHat_Mesh";
                type = ItemType.Apparel;
                armour = 2;
                amount = 1;
                break;

            case 201:
                name = "Steel Helm";
                value = 50;
                description = "A pot for your noggin";
                icon = "Apparel/SteelHelm_Icon";
                mesh = "Apparel/SteelHelm_Mesh";
                type = ItemType.Apparel;
                armour = 10;
                amount = 1;
                break;

            case 202:
                name = "Great Helm";
                value = 100;
                description = "A lordly helm";
                icon = "Apparel/GreatHelm_Icon";
                mesh = "Apparel/GreatHelm_Mesh";
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
                icon = "Crafting/Spring_Icon";
                mesh = "Crafting/Spring_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            case 301:
                name = "Mirror";
                value = 4;
                description = "Don't break its bad luck";
                icon = "Crafting/Mirror_Icon";
                mesh = "Crafting/Mirror_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            case 302:
                name = "Nut";
                value = 1;
                description = "essential for anything that is supposed to stay together";
                icon = "Crafting/Nut_Icon";
                mesh = "Crafting/Nut_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;

            #endregion
            #region Quest 400-499

            case 400:
                name = "Crystal Ball";
                value = 150;
                description = "Can you see the future yet";
                icon = "Quest/CrystalBall_Icon";
                mesh = "Quest/CrystalBall_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;

            case 401:
                name = "Staff";
                value = 240;
                description = "More than just a walking aid";
                icon = "Quest/Staff_Icon";
                mesh = "Quest/Staff_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;

            case 402:
                name = "Tome";
                value = 485;
                description = "Where knowledge is stored";
                icon = "Quest/Tome_Icon";
                mesh = "Quest/Tome_Mesh";
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
                icon = "Ingredients/BlueBerries_Icon";
                mesh = "Ingredients/BlueBerries_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;

            case 601:
                name = "Mushroom";
                value = 2;
                description = "Grows in much";
                icon = "Ingredients/Mushroom_Icon";
                mesh = "Ingredients/Mushroom_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;

            case 602:
                name = "Flower";
                value = 5;
                description = "Its pretty";
                icon = "Ingredients/Flower_Icon";
                mesh = "Ingredients/Flower_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;
            #endregion
            #region Potions 700-799

            case 700:
                name = "Green Health";
                value = 25;
                description = "a little pick me up";
                icon = "Potions/GreenHealth_Icon";
                mesh = "Potions/GreenHealth_Mesh";
                type = ItemType.Potions;
                heal = 25;
                amount = 1;
                break;

            case 701:
                name = "Blue Health";
                value = 75;
                description = "For Broken arms and punctured Spleens";
                icon = "Potions/BlueHealth_Icon";
                mesh = "Potions/BlueHealth_Mesh";
                type = ItemType.Potions;
                heal = 50;
                amount = 1;
                break;

            case 702:
                name = "Red Health";
                value = 150;
                description = "For near death experiences";
                icon = "Potions/RedHealth_Icon";
                mesh = "Potions/RedHealth_Mesh";
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
                icon = "Scrolls/BlankScroll_Icon";
                mesh = "Scrolls/BlankScroll_Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;

            case 801:
                name = "Historical Scroll";
                value = 150;
                description = "Brief account of local history";
                icon = "Scrolls/HistoricalScroll_Icon";
                mesh = "Scrolls/HistoricalScroll_Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;

            case 802:
                name = "Shipping Manifest";
                value = 50;
                description = "A list of items being sent to far away places";
                icon = "Scrolls/ShippingManifest_Icon";
                mesh = "Scrolls/ShippingManifest_Mesh";
                type = ItemType.Scrolls;
                amount = 1;
                break;
            #endregion

            default:
                itemID = 4;
                name = "Apple";
                value = 1;
                description = "Muchie and crunchy";
                icon = "Food/Apple_Icon";
                mesh = "Food/Apple_Mesh";
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
