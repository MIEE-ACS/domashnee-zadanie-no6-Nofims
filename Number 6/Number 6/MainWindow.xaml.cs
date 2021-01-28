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
        public int counter = 1;
        virtual public int Counter
        {
            get
            {
                return counter;
            }
        }

                
        class mammal : pets
        {
            
            
           
            class cat : mammal
            { 

                double catage;
                public string live
                {
                    get
                    {
                        return "Квартира";
                    }
                }
                public string quirk
                {
                    get
                    {
                        return "Каждый день приносит мышку";
                    }
                }

                public override int age
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
                        catage = value;
                    }
                }
            }


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
        class dog : mammal
        {
          public double  dogage;
            public string live
            {
                get
                {
                    return "Квартира";
                }
            }
            public string quirk
            {
                get
                {
                    return "Нравится , когда глядят живот";
                }
            }
            public string food

            {
                get
                {
                    return "Chappi";
                }
            }
            public override int age
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
                    dogage = value;
                }
            }

        }
            public string type
            {
                get
                {
                    return "Собака";
                }

            }

        }
    

    
        }
        class reptile : pets
{
   
    class chameleon : reptile
    {
        public double chamage;
            public string live
            {
                get
                {
                    return "Вольер";
                }
            }
            public string food

        {
            get
            {
                return "Насекомые";
            }
        }
            public string quirk
            {
                get
                {
                    return "Не любит менять цвет";
                }
            }
            public override int age
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
                    chamage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Хамелеон";
            }

        }

    }

    class iguana : reptile
    {
        public double iguage;
            public string live
            {
                get
                {
                    return "Вольер";
                }
            }
            public string food

        {
            get
            {
                return "Фрукты";
            }
        }
            public string quirk
            {
                get
                {
                    return "Шипит при виде кошки";
                }
            }
            public override int age
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
                    iguage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Игуана";
            }

        }

    }
}
        class bird : pets
        {
   
    class parrot : bird
    {
        public double parrage;
            public string live
            {
                get
                {
                    return "Клетка";
                }
            }
            public string quirk
            {
                get
                {
                    return "Гадит на улице";
                }
            }
            public string food

        {
            get
            {
                return "Семечки";
            }
        }
            public override int age
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
                    parrage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Попугай";
            }

        }

    }
    class canary : bird
    {
        public double canage;
            public string live
            {
                get
                {
                    return "Клетка";
                }
            }
            public string food

        {
            get
            {
                return "Кукуруза сушеная";
            }
        }
            public string quirk
            {
                get
                {
                    return "Любит еду желтого цвета";
                }
            }
            public override int age
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
                   canage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Попугай";
            }

        }

    }

}
        class fish : pets
        {
    class carp : fish
    {
        public double carpage;
            public string live
            {
                get
                {
                    return "Пруд";
                }
            }

            public string quirk
            {
                get
                {
                    return "Плавает с друзьями";
                }
            }
            public string food

        {
            get
            {
                return "Корм для рыб";
            }
        }
            public override int age
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
                    carpage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Карп";
            }

        }

    }
    class goldfish : fish
    {
        public double goldage;
            public string live
            {
                get
                {
                    return "Аквариум";
                }
            }
            public string quirk
            {
                get
                {
                    return "Исполняет желания только 13-го в пятницу";
                }
            }
            public string food

        {
            get
            {
                return "Корм для рыб 'Особый' ";
            }
        }
            public override int age
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
                    goldage = value;
                }
            }

        }
        public string type
        {
            get
            {
                return "Золотая рыбка";
            }

        }

    }
}
        public partial class MainWindow : Window
    {
        
        

        List<pets> pet = new List<pets>()
        {
             new fish() {age = 3 },
            new fish() { age = 2},
             new fish() { age = 3},

            new reptile()  { age = 15},
            new reptile()  { age = 7},
            new reptile()  { age = 2},

            new bird() { age = 6},
            new bird() { age = 4},
          new bird() { age = 20},

          
        };

        public MainWindow()
            {
                InitializeComponent();
            }
        }
    }

