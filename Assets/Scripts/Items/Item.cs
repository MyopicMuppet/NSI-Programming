//in this script  you will only need using UnityEngine as we just need the script to connect to unity
using UnityEngine;
//this public class doent inherit from MonoBehaviour
//this script is also referenced by other scripts but never attached to anything
public class Item
{
    //basic variables for items that we need are 
    #region Private Variables
    //Identification Number
    private int _idNum;
    //Object Name
    private string _name;
    //Value of the Object
    private int _value;
    //Description of what the Object is
    private string _description;
    //Icon that displays when that Object is in an Inventory
    private Texture2D _icon;
    //Mesh of that object when it is equipt or in the world
    private GameObject _mesh;
    //Enum ItemType which is the Type of object so we can classify them
    private ItemType _type;
    private int _heal;
    private int _damage;
    private int _armour;
    private int _amount;
    #endregion
    #region Constructors
    //A constructor is a bit of code that allows you to create objects from a class. You call the constructor by using the keyword new 
    //followed by the name of the class, followed by any necessary parameters.
    //the Item needs Identification Number, Object Name, Icon and Type
    //here we connect the parameters with the item variables

    public void ItenCon(int itemId, string itemName, Texture2D itemIcon, ItemType itemType)
    {
        _idNum = itemId;
        _name = itemName;
        _icon = itemIcon;
        _type = itemType;
    }
    #endregion
    #region Public Variables
    //here we are creating the public versions or our private variables that we can reference and connect to when interacting with items
    //public Identification Number 

        public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int ID
    {
        get { return _idNum; }
        set { _idNum = value; }
    }
    //get the private Identification Number
    //and set it to the value of our public Identification Number
    //public Name 
    public int Value
    {
        //get the private Name
        get { return _value; }
        set { _value = value; }

    }
    //and set it to the value of our public Name

    //public Value 

    public string Description
    {
        //public Description 
        //get the private Description
        //and set it to the value of our public Description

        get { return _description; }
        set { _description = value; }
    }
    //get the private Value
    //and set it to the value of our public Value
    //public Icon 

    public Texture2D Icon
    {
        //get the private Icon
        get { return _icon; }
        set { _icon = value; }
    }
    //and set it to the value of our public Icon
    //public Mesh 
    public GameObject Mesh
    {
        get { return _mesh; }
        set { _mesh = value; }
    }
    //get the private Mesh
    //and set it to the value of our public Mesh
    //public Type 
    //get the private Type

    public ItemType Type
    {
        get { return _type; }
        set { _type = value; }
    }
    //and set it to the value of our public Type

    public int Heal
    {
        get { return _heal;  }
        set { _heal = value; }
    }

    public int Damage
    {
        get { return _damage; }
        set { _damage = value;  }
    }

    public int Armour
    {
        get { return _armour; }
        set { _armour = value; }
    }

    public int Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    #endregion
}
#region Enums
//The Global Enum ItemType that we have created categories in
public enum ItemType
{
    Food,
    Weapon,
    Apparel,
    Crafting,
    Quest,
    Money,
    Ingredients,
    Potions,
    Scrolls
}
#endregion
