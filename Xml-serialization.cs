using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace ekzamen_cSharp
{
    [Serializable]
    class Xml_serialization
    {
        public void Serializaton_Model()
        {
            Model m1 = new Model();
            XmlSerializer formatter = new XmlSerializer(typeof(Model));
            using (FileStream fs = new FileStream("Model.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, m1);
                Console.WriteLine("Объект сериализован");
            }
        }
        public void Serializaton_Modification()
        {
            Modification mod = new Modification();
            XmlSerializer formatter = new XmlSerializer(typeof(Modification));
            using (FileStream fs = new FileStream("Modification.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, mod);
                Console.WriteLine("Объект сериализован");
            }
        }
        public void Serializaton_Colour()
        {
            Colour col1 = new Colour();
            XmlSerializer formatter = new XmlSerializer(typeof(Colour));
            using (FileStream fs = new FileStream("Colour.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, col1);
                Console.WriteLine("Объект сериализован");
            }
        }
        public void desializaton_Model()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Model));
            using (FileStream fs = new FileStream("Model.xml", FileMode.OpenOrCreate))
            {
                Model newModel = (Model)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                newModel.print();
            }
        }
        public void desializaton_Modification()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Modification));
            using (FileStream fs = new FileStream("Modification.xml", FileMode.OpenOrCreate))
            {
                Modification newModification = (Modification)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                newModification.print();
            }
        }
        public void desializaton_Colour()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Colour));
            using (FileStream fs = new FileStream("Colour.xml", FileMode.OpenOrCreate))
            {
                Colour newColour = (Colour)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                newColour.print();
            }
        }
    }
}
