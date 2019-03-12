using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class Save
{
    public static void SaveData(Player player)
    {
        //Binaryformatter
        BinaryFormatter formatter = new BinaryFormatter();
        //save path
        string path = Application.persistentDataPath + "/Bob_Cake.png";
        //file stream
        FileStream stream = new FileStream(path, FileMode.Create);
        //data
        Data data = new Data(player);
        //convert to binary and save to path
        formatter.Serialize(stream, data);
        //end
        stream.Close();

    }
    public static Data LoadData()
    {
        // have a path
        string path = Application.persistentDataPath + "/Bob_Cake.png";

        // check to see if path exists
        if (File.Exists(path))
        {
            //formatter
            BinaryFormatter formatter = new BinaryFormatter();
            //stream open
            FileStream stream = new FileStream(path, FileMode.Open);
            //data deserialize
            Data data = formatter.Deserialize(stream) as Data;
            //end
            stream.Close();
            //return
            return data;
        }


        //else
        else
        {
            Debug.Log ("Load error");
            return null;
        }

    }
}
