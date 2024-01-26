using System.IO;

namespace ShortcutFolder
{
    class LabelLine
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public string Via { get; private set; }
        public string myPngAdress { get; private set; }
        
        public LabelLine(string _name = "NEW SHORTCUT", string _adress = "<Put path here>",
            string _via = "-systemSettings", string _myPngAdress = "-default")
        {
            Name = _name; 
            Adress = _adress; 
            Via = _via; 
            myPngAdress = _myPngAdress;
        }

        public void reName(string newName) => Name = newName;
        public void reAdress(string newAdress) => Adress = newAdress;
        public void reVia(string newVia) => Via = newVia;
        public void reImgAdress(string newImgAdress) => myPngAdress = newImgAdress;

        public override string ToString()
        {
            string output = "";
            output += "{\n";
            output += $"\t_name_={Name};\n";
            output += $"\t_adress_={Adress};\n";
            output += $"\t_via_={Via};\n";
            output += $"\t_imgAdress_={myPngAdress};\n";
            output += "}\n";
            return output;
        }
    }
}