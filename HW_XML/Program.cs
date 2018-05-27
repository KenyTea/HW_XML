using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW_XML
{
    class Program
    {
        /*Создайте XML- документ, представляющий информацию по определенной вариантом предметной области. Созданный документ должен соответствовать следующим требования:
1.	документы должны иметь глубину вложенности не менее четырех элементов;
2.	число элементов документа, не имеющих вложенных, должно быть не менее пяти;
3.	элементы документа должны содержать комментарии о своем содержании;
4.	документ должен включать элементы, содержащие символьные данные и дочерний элементы;
5.	Создание XML документа в текстовом редакторе и проверка структуры документа в программе-броузере Internet Explorer.
6.	Создать XML документ в файле 1.xml следующей структуры:
*/

        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Root");
            Console.WriteLine("Создан root");

            XmlElement Good = doc.CreateElement("Good");
            Console.WriteLine("Создан  элемент Good");
            Good.InnerText = "Electroscuter";

            XmlElement Name = doc.CreateElement("Name");
            Console.WriteLine("Создан  элемент Name");
            Name.InnerText = "Brend";

            #region Segway
            XmlElement Segway = doc.CreateElement("Segway");
            Console.WriteLine("Создан  элемент Segway");
            Segway.InnerText = "Segway";

            XmlElement ES1 = doc.CreateElement("ES1");
            ES1.InnerText = "Model ES1";

            XmlElement ES2 = doc.CreateElement("ES2");
            ES2.InnerText = "Model ES2";

            XmlElement ES4 = doc.CreateElement("ES4");
            ES4.InnerText = "Model ES4";

            XmlElement PriceES1 = doc.CreateElement("PriceES1");
            PriceES1.InnerText = "140000";

            XmlElement PriceES2 = doc.CreateElement("PriceES2");
            PriceES2.InnerText = "170000";

            XmlElement PriceES4 = doc.CreateElement("PriceES4");
            PriceES4.InnerText = "200000";
            #endregion

            #region Xiaomi
            XmlElement Xiaomi = doc.CreateElement("Xiaomi");
            Console.WriteLine("Создан элемент Xiaomi");
            Xiaomi.InnerText = "Xiaomi";

            XmlElement Model_1 = doc.CreateElement("Model_1");
            Model_1.InnerText = "Model_M365";

            XmlElement Price_M1 = doc.CreateElement("Price_M1");
            Price_M1.InnerText = "150000";

            XmlElement Model_2 = doc.CreateElement("Model_2");
            Model_2.InnerText = "Model_M187";

            XmlElement Price_M2 = doc.CreateElement("Price_M2");
            Price_M2.InnerText = "140000";
            #endregion

            Model_2.AppendChild(Price_M2);
            Model_1.AppendChild(Price_M1);
            Xiaomi.AppendChild(Model_2);
            Xiaomi.AppendChild(Model_1);

            Name.AppendChild(Xiaomi);

            ES4.AppendChild(PriceES4);
            ES2.AppendChild(PriceES2);
            ES1.AppendChild(PriceES1);
            Segway.AppendChild(ES4);
            Segway.AppendChild(ES2);
            Segway.AppendChild(ES1);

            Name.AppendChild(Segway);

            Good.AppendChild(Name);

            root.AppendChild(Good);

            doc.AppendChild(root);
            doc.Save("1.xml");
        }
    }
}
