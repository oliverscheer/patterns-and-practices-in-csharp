using System.Diagnostics;

namespace OliverScheer.Samples.PeriodicElementNameGenerator;

internal class PeriodicElementNameGenerator
{
    internal Element[] Generate(string name)
    {
        Console.WriteLine("Input: " + name);

        List<Element> elements = [];

        name = name.ToLower();
        for (int i = 0; i < name.Length; i++)
        {
            for (int j = name.Length - i; j > 0; j--)
            {
                string s = name.Substring(i, j).ToString();
                foreach (Element element in periodicTable)
                {
                    if (element.Symbol.Equals(s, StringComparison.CurrentCultureIgnoreCase))
                    {
                        elements.Add(element);
                    }
                }
            }
        }

        return [.. elements];
    }

    internal void Output(Element[] result)
    {
        Console.WriteLine("Your periodic element name is: ");
        foreach (var element in result)
        {
            Console.WriteLine($"{element.Symbol} - {element.Name}");
        }
        Console.WriteLine("---");
    }

    internal void Process(string v)
    {
        var result = Generate(v);
        Output(result);
    }

    private Element[] periodicTable = [
            new(1, "Hydrogen", "H"),
            new(2, "Helium", "He"),
            new(3, "Lithium", "Li"),
            new(4, "Beryllium", "Be"),
            new(5, "Boron", "B"),
            new(6, "Carbon", "C"),
            new(7, "Nitrogen", "N"),
            new(8, "Oxygen", "O"),
            new(9, "Fluorine", "F"),
            new(10, "Neon", "Ne"),
            new(11, "Sodium", "Na"),
            new(12, "Magnesium", "Mg"),
            new(13, "Aluminum", "Al"),
            new(14, "Silicon", "Si"),
            new(15, "Phosphorus", "P"),
            new(16, "Sulfur", "S"),
            new(17, "Chlorine", "Cl"),
            new(18, "Argon", "Ar"),
            new(19, "Potassium", "K"),
            new(20, "Calcium", "Ca"),
            new(21, "Scandium", "Sc"),
            new(22, "Titanium", "Ti"),
            new(23, "Vanadium", "V"),
            new(24, "Chromium", "Cr"),
            new(25, "Manganese", "Mn"),
            new(26, "Iron", "Fe"),
            new(27, "Cobalt", "Co"),
            new(28, "Nickel", "Ni"),
            new(29, "Copper", "Cu"),
            new(30, "Zinc", "Zn"),
            new(31, "Gallium", "Ga"),
            new(32, "Germanium", "Ge"),
            new(33, "Arsenic", "As"),
            new(34, "Selenium", "Se"),
            new(35, "Bromine", "Br"),
            new(36, "Krypton", "Kr"),
            new(37, "Rubidium", "Rb"),
            new(38, "Strontium", "Sr"),
            new(39, "Yttrium", "Y"),
            new(40, "Zirconium", "Zr"),
            new(41, "Niobium", "Nb"),
            new(42, "Molybdenum", "Mo"),
            new(43, "Technetium", "Tc"),
            new(44, "Ruthenium", "Ru"),
            new(45, "Rhodium", "Rh"),
            new(46, "Palladium", "Pd"),
            new(47, "Silver", "Ag"),
            new(48, "Cadmium", "Cd"),
            new(49, "Indium", "In"),
            new(50, "Tin", "Sn"),
            new(51, "Antimony", "Sb"),
            new(52, "Tellurium", "Te"),
            new(53, "Iodine", "I"),
            new(54, "Xenon", "Xe"),
            new(55, "Cesium", "Cs"),
            new(56, "Barium", "Ba"),
            new(57, "Lanthanum", "La"),
            new(58, "Cerium", "Ce"),
            new(59, "Praseodymium", "Pr"),
            new(60, "Neodymium", "Nd"),
            new(61, "Promethium", "Pm"),
            new(62, "Samarium", "Sm"),
            new(63, "Europium", "Eu"),
            new(64, "Gadolinium", "Gd"),
            new(65, "Terbium", "Tb"),
            new(66, "Dysprosium", "Dy"),
            new(67, "Holmium", "Ho"),
            new(68, "Erbium", "Er"),
            new(69, "Thulium", "Tm"),
            new(70, "Ytterbium", "Yb"),
            new(71, "Lutetium", "Lu"),
            new(72, "Hafnium", "Hf"),
            new(73, "Tantalum", "Ta"),
            new(74, "Tungsten", "W"),
            new(75, "Rhenium", "Re"),
            new(76, "Osmium", "Os"),
            new(77, "Iridium", "Ir"),
            new(78, "Platinum", "Pt"),
            new(79, "Gold", "Au"),
            new(80, "Mercury", "Hg"),
            new(81, "Thallium", "Tl"),
            new(82, "Lead", "Pb"),
            new(83, "Bismuth", "Bi"),
            new(84, "Polonium", "Po"),
            new(85, "Astatine", "At"),
            new(86, "Radon", "Rn"),
            new(87, "Francium", "Fr"),
            new(88, "Radium", "Ra"),
            new(89, "Actinium", "Ac"),
            new(90, "Thorium", "Th"),
            new(91, "Protactinium", "Pa"),
            new(92, "Uranium", "U"),
            new(93, "Neptunium", "Np"),
            new(94, "Plutonium", "Pu"),
            new(95, "Americium", "Am"),
            new(96, "Curium", "Cm"),
            new(97, "Berkelium", "Bk"),
            new(98, "Californium", "Cf"),
            new(99, "Einsteinium", "Es"),
            new(100, "Fermium", "Fm"),
            new(101, "Mendelevium", "Md"),
            new(102, "Nobelium", "No"),
            new(103, "Lawrencium", "Lr"),
            new(104, "Rutherfordium", "Rf"),
            new(105, "Dubnium", "Db"),
            new(106, "Seaborgium", "Sg"),
            new(107, "Bohrium", "Bh"),
            new(108, "Hassium", "Hs"),
            new(109, "Meitnerium", "Mt"),
            new(110, "Darmstadtium", "Ds"),
            new(111, "Roentgenium", "Rg"),
            new(112, "Copernicium", "Cn"),
            new(113, "Nihonium", "Nh"),
            new(114, "Flerovium", "Fl"),
            new(115, "Moscovium", "Mc"),
            new(116, "Livermorium", "Lv"),
            new(117, "Tennessine", "Ts"),
            new(118, "Oganesson", "Og")
        ];
}

[DebuggerDisplay("No: {Number} - Name: {Name} - Symbol: {Symbol}")]
public class Element(int number, string name, string symbol)
{
    public int Number { get; set; } = number;
    public string Name { get; set; } = name;
    public string Symbol { get; set; } = symbol;
}

