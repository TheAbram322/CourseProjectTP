using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace CloneOSU2
{
    [Serializable, XmlRoot("Players")]
    public class Players
    {
        public Players() { }

        public List<Player> listPlayers = new List<Player>();
    };

    [Serializable, XmlRoot("Player")]
    public class Player : IComparable
    {
        public Player() { }

        public Player(string name, int score)
        {
            this.name = name;
            this.scores = score;
        }

        public string name;
        public int scores;

        public int CompareTo(object o)
        {
            if (o == null) return 1;

            Player player = o as Player;
            if (player != null)
                return this.scores.CompareTo(player.scores);
            return 0;
        }
    };


    public class SerializingClass 
    {
        public SerializingClass() 
        {
            content = new Players();
        }
        
        public Players content;

        public void Serializing() 
        {
            XmlSerializer xml = new XmlSerializer(typeof(Players));

            using (FileStream fs = new FileStream("Players.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, content);
            }
        }

        public void Deserializing() {
            XmlSerializer xml = new XmlSerializer(typeof(Players));

            if (File.Exists("Players.xml"))
            {
                using (FileStream fs = new FileStream("Players.xml", FileMode.Open))
                {

                    content = (Players)xml.Deserialize(fs);
                }
            }
        }

    }
}
