using System;
using System.IO;

namespace минисессия_весна_
{
    internal class Program
    {
        class Simple
        {
            protected string _name;
            protected int _koef;
            protected int _price;

            public int Koef => _koef;
            public int Price => _price;

            public Simple(string name, int koef, int price)
            {
                _name = name;
                _koef = koef;
                _price = price;
            }

            public override string ToString()
            {
                return this.AsString;
            }

            public Simple(string s)
            {
                this.AsString = s;
            }

            public string AsString
            {
                get
                {
                    return $"{_name} {_koef} {_price}";
                }
                set
                {
                    var p = value.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    _price = int.Parse(p[p.Length - 1]);
                    _koef = int.Parse(p[p.Length - 2]);
                    for (int i = 0; i < p.Length - 2; i++)
                    {
                        _name += p[i] + " ";
                    }
                }
            }
        }

        class Group: Simple
        {
            protected string _name;
            protected Simple[] items;
            protected double _totalKoef;
            protected int _totalPrice;

            public int Count => items.Length;

            public void Add(Simple item)
            {
                if (items == null)
                {
                    items = new Simple[1];
                    items[0] = item;
                }
                else
                {
                    Simple[] temp = new Simple[Count + 1];
                    items.CopyTo(temp, 0);
                    items = temp;
                    items[Count - 1] = item;
                }

                if (item is Simple)
                {
                    _totalKoef *= item.Koef;
                    _totalPrice += item.Price;
                }
                else if (item is Group)
                {
                    _totalKoef *= ((Group)item)._totalKoef;
                    _totalPrice += ((Group)item)._totalPrice;
                }
            }

            public Simple CreateItem(string s, StreamReader sr)
            {
                var p = s.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if ((s != "") && (p[0] != "Сборка"))
                {
                    return new Simple(s);
                }
                else
                {
                    return new Group(sr, s);
                }
            }

            public Group(StreamReader sr, string Name) : this(Name)
            {
                var l = sr.ReadLine();
                while ((!sr.EndOfStream) && (l != ""))
                {
                    Add(CreateItem(l, sr));
                    l = sr.ReadLine();
                }
                if (l != "") Add(CreateItem(l, sr));
            }

            public Group(string Name): base(Name, 1, 0)
            {
                var a = Name.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 1; i < a.Length; i++)
                    _name += a[i] + " ";
                items = new Simple[0];
                _totalKoef = 1.0;
                _totalPrice = 0;
            }

            public override string ToString()
            {
                return this.AsString;
            }

            public string AsString
            {
                get
                {
                    return $"{_name} ({_totalKoef}, {_totalPrice})";
                }
                set
                {
                    var p = value.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    _totalPrice = int.Parse(p[p.Length - 1]);
                    _totalKoef = double.Parse(p[p.Length - 2]);
                    for (int i = 0; i < p.Length - 2; i++)
                    {
                        _name += p[i] + " ";
                    }
                }
            }

            public string DisplayHierarchy(int indent)
            {
                string output = new string(' ', indent) + _name + $" ({_totalKoef}, {_totalPrice})\n";

                foreach (Simple item in items)
                {
                    if (item is Group)
                    {
                        output += ((Group)item).DisplayHierarchy(indent + 5);
                    }
                    else
                    {
                        output += new string(' ', indent + 5) + item.ToString() + "\n";
                    }
                }

                return output;
            }

            public Simple FindMaxUnit()
            {
                Simple maxUnit = null;
                double maxRatio = 0.0;

                foreach (Simple item in items)
                {
                    if (item is Simple)
                    {
                        Simple unit = item;
                        double ratio = (double)unit.Koef / unit.Price;
                        if (ratio > maxRatio)
                        {
                            maxRatio = ratio;
                            maxUnit = unit;
                        }
                    }
                    else if (item is Group)
                    {
                        Simple subMaxUnit = ((Group)item).FindMaxUnit();
                        if (subMaxUnit != null)
                        {
                            double ratio = (double)((Group)item)._totalKoef / ((Group)item)._totalPrice;
                            if (ratio > maxRatio)
                            {
                                maxRatio = ratio;
                                maxUnit = subMaxUnit;
                            }
                        }

                        double groupRatio = (double)_totalKoef / _totalPrice;
                        if (groupRatio > maxRatio)
                        {
                            maxRatio = groupRatio;
                            maxUnit = item;
                        }
                    }
                }

                return maxUnit;
            }
        }

        static void Main(string[] args)
        {
            Group group = null;
            var sr = new StreamReader("/Users/sheisuka/Desktop/warehouse.txt");
            try
            {
                group = new Group(sr, "Сборка Сборка");
            }
            finally
            {
                sr.Close();
            }

            Simple maxUnit = group.FindMaxUnit();

            Console.WriteLine("Единица техники с максимальным отношением производительность/цена:");
            Console.WriteLine(maxUnit);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(group.DisplayHierarchy(2));
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
