using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Number_6
{
    class pets
    {
        //public int counter = 1;

        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>

       // public virtual string type { get; set; }
        //public virtual string food { get; set; }
       // public virtual string habitat { get; set; }
        virtual public int age { get; set; }

        //virtual public int Counter
        {
          //  get
            //{
              //  return counter;
            //}
        //}

        class mammal : pets
        {
            public string live
            {
                get
                {
                    return "Flat";
                }
            }
            public double agee
            {
                get
                {
                    return age;

                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Возраст не может быть отрицательным!");
                    }
                    else if (value == 0)
                    {
                        throw new Exception("Возраст не может быть равным нулю , так как не только что родился!");
                    }
                    else
                    {
                        agee = value;
                    }
                }
            }
            // string ;  string ; double ; 
            class cat : mammal
            {
                double age;
                    public string food

                {
                    get
                    {
                        return "Kitecat";
                    }
                }

                public string type
                {
                    get
                    {
                        return "Кот";
                    }
                   
                }

                }
            }
            class ferret : mammal
        {
            public string type
            {
                get
                {
                    return "Хорёк";
                }

            }
            public string food
            {
                get
                {
                    return "Спецкорм";
                }
            }
        }
        }
        class reptile : pets
        {
            class chameleon : reptile { }
            class iguana : reptile { }
        }
        class bird : pets
        {
            class parrot : bird { }
            class canary : bird { }

        }
        class fish : pets
        {
            class carp : fish { }
            class goldfish : fish { }
        }
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }
        }
    }
}
