using System;
using FK_CLI;

namespace _2_1
{
    class MyDate
    {
        private int _Month;
        private int _Day;

        public MyDate()
        {
            _Month = 1;
            _Day = 1;

        }

        public MyDate(int argM, int argD)
        {
            _Month = argM;
            _Day = argD;
        }

        public int Month
        {
            get { return _Month; }
            set
            {
                if(value >= 1 && value <= 12)
                {
                    _Month = value;
                }
                if(Month == 1||Month ==3||Month == 5||Month == 7||Month == 8||Month ==10||Month == 12)
                {
                    if(Day > 31)
                    {
                        Day = 31;
                    }
                }
                else if(Month == 4||Month == 6|| Month == 9||Month == 11)
                {
                    if (Day > 30)
                    {
                        Day = 30;
                    }
                }
                else if(Month == 2)
                {
                    if(Day > 28)
                    {
                        Day = 28;
                    }
                }

            }
        }

        public int Day
        {
            get { return _Day; }
            set
            {
                switch (Month)
                {
                    case 1:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 2:
                        if (value >= 1 && value <= 28)
                        {
                            _Day = value;
                        }
                        break;
                    case 3:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 4:
                        if (value >= 1 && value <= 30)
                        {
                            _Day = value;
                        }
                        break;
                    case 5:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 6:
                        if (value >= 1 && value <= 30)
                        {
                            _Day = value;
                        }
                        break;
                    case 7:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 8:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 9:
                        if (value >= 1 && value <= 30)
                        {
                            _Day = value;
                        }
                        break;
                    case 10:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    case 11:
                        if (value >= 1 && value <= 30)
                        {
                            _Day = value;
                        }
                        break;
                    case 12:
                        if (value >= 1 && value <= 31)
                        {
                            _Day = value;
                        }
                        break;
                    default:
                        _Day = 1;
                        break;
                }
               
            }
        }

        public void Print()
        {
            Console.WriteLine("{0}/{1}", _Month, _Day);
        }

        public void Inclement()
        {
            if (_Month == 1 ||_Month == 3 || _Month == 5 || _Month == 7 || _Month == 8 || _Month == 10 || _Month == 12)
            {
                if (_Day == 31)
                {
                    _Day = 1;
                    if(_Month < 12)
                    {
                        _Month += 1;
                    }
                    else if(_Month == 12)
                    {
                        _Month = 1;
                    }
                }
                else
                {
                    _Day += 1;
                }
            }
            else if (_Month == 4 || _Month == 6 || _Month == 9 || _Month == 11)
            {
                if (_Day == 30)
                {
                    _Day = 1;
                    _Month += 1;
                }
                else
                {
                    _Day += 1;
                }
            }
            else if (_Month == 2)
            {
                if (_Day == 28)
                {
                    _Day = 1;
                    _Month += 1;
                }
                else
                {
                    _Day += 1;
                }
            }
        }
    }


    class CSSamp
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate();
            
            Console.Write("month?");
            date.Month = int.Parse(Console.ReadLine());
            Console.Write("day?");
            date.Day = int.Parse(Console.ReadLine());

            date.Inclement();
            date.Inclement();
            date.Inclement();
            date.Print();
            Console.ReadKey();
        }
    }

    
}