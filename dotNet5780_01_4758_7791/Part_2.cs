using System;

namespace dotNet5780_01_4758_7791
{
    public class Part_2
    {
        bool[,] tfussa = new bool[13, 32];
        // we change month = 13 because of the index that starts at 0
        // and we need the month December

        public Part_2()
        {
            int choice;
            init();
            bool flag = true;
            do
            {
                choice = runtafrit();
                
            } while (choice != 4);

        }

        public int runtafrit()
        {
            int choix;
            string arrivingDate;
            int timeofStay;
            int day;
            int month;
            int temp;
            int tempDay;
            int tempMonth;

            int count = 0;
            Console.WriteLine("Enter your choice\n");
            choix = Int32.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.WriteLine("Enter your arriving date in this way XX/XX\n");
                    arrivingDate = Console.ReadLine();
                    Console.WriteLine("Enter the number days you would like yo stay\n");
                    timeofStay = Int32.Parse(Console.ReadLine());
                    day = Int32.Parse(arrivingDate.Substring(0, 2));
                    month = Int32.Parse(arrivingDate.Substring(3));
                    temp = timeofStay;
                    tempDay = day;
                    tempMonth = month;
                    if (tfussa[month,day]==false)
                    {
                        for (int i = timeofStay; i!=0; i--)
                        {
                            if(day != 31 && month!=12)
                            {
                                day++;
                                if (tfussa[month, day] == true)
                                {
                                    Console.WriteLine("Sorry, this dates are not available\n");
                                    break;
                                }
                            }
                            else if(day==31 && month!=12)
                            {
                                month = month + 1;
                                day = 1;
                                if (tfussa[month, day] == true)
                                {
                                    Console.WriteLine("Sorry, this dates are not available.\n");
                                    break;
                                }

                            }
                            else if (month == 12)
                            {
                                month = 1;
                                day = 1;
                                if (tfussa[month, day] == true)
                                {
                                    Console.WriteLine("Sorry, this dates are not available.\n");
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, this dates are not available.\n");
                        break;
                    }
                    for (int i = temp; i != 0; i--)
                    {
                        if (tempDay != 32)
                        {
                            tfussa[tempMonth, tempDay] = true;
                            tempDay++;
                        }
                        else
                        {
                            tempMonth = tempMonth + 1;
                            tempDay = 1;
                            tfussa[tempMonth, tempDay] = true;
                        }
                    }
                     Console.WriteLine("We are pleased to welcome you in our place.\n");
                    break;

                case 2:
                    for (int i = 1; i < 13; i++)
                    {

                        int j = 1;
                        while (j<31)
                        {
                            bool flag = false;
                            int tempj = j;
                            while (tfussa[i, j] == true && j<31)
                            {
                                j = j + 1;
                                count++;
                                flag = true;
                            }


                            if (flag==true)
                            {
                                Console.WriteLine("The hotel is busy since : {0}/{1}, to : {2}/{1}\n", tempj, i, tempj + count);

                            }

                           

                            count = 0;
                            j++;

                        }

                        if (j == 31 && tfussa[i, j] == true)
                        {
                            Console.WriteLine("the hotel is occupied : {0}/{1}", j, i);
                        }

                    }

                    break;
                case 3:
                    int counter = 0;
                    for (int i = 1; i < 13; i++)
                    {
                        for (int j = 1; j < 31; j++)
                        {
                            if (tfussa[i,j]==true)
                            {
                                counter++;
                            }
                        }

                    }
                    Console.WriteLine("There is {0} occupied days in the year\n", counter);
                    float ahouz = 100 * counter / 365;
                    Console.WriteLine("The percentage of occupied days is {0} %\n", ahouz);
                    break;
                case 4:
                   Console.WriteLine("See you next time\n");
                    break;
          
                default:
                    break;
            }
            return choix;

        }

        private void init()
        {
            for (int i = 0; i < tfussa.GetLength(0); i++)
            {
                for (int j = 0; j < tfussa.GetLength(1); j++)
                {
                    tfussa[i, j] = false;
                }
            }
        }
    }
}