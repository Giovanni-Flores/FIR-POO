using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 - Class Car

            Console.WriteLine($"--- Class Car");
            Car carOne = new Car();

            carOne.name = "BMW 118i";
            carOne.power = 136;

            Console.WriteLine($"\nThe car is a {carOne.viewName()} and your number maximum power is {carOne.viewPower()}horsepower");

            //Exercise 2 - Class Telephone
            Console.WriteLine($"\n--- Class Telephone");
            Telephone telephoneOne = new Telephone();

            telephoneOne.numberTelephone = "(51) 992450909";
            telephoneOne.mobileOperator = "VIVO";

            Console.WriteLine($"\nYour Number is: {telephoneOne.viewNumber()} and your mobile operator is: {telephoneOne.viewMobileOperator()}");

            Telephone telephoneTwo = new Telephone();
            telephoneTwo.numberTelephone = "(21) 998231679";
            telephoneTwo.mobileOperator = "TIM";

            Console.WriteLine($"Your second Number is: {telephoneTwo.viewNumber()} and your mobile operator is: {telephoneTwo.viewMobileOperator()}");

            //Exercise 3 - Class Person
            /*Console.WriteLine($"\n--- Class Person");

            Person personOne = new Person();

            Console.WriteLine($"\nForm 1:");
            Console.WriteLine($"\nWrite your name:");
            personOne.name = Console.ReadLine();
            Console.WriteLine($"\nWrite your age:");
            personOne.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nWrite your adress:");
            personOne.adress = Console.ReadLine();
            Console.WriteLine($"\nFirst Person: \nName:{personOne.name} \nAge:{personOne.age} \nAdress:{personOne.adress}");

            Console.WriteLine($"\nForm 2:");

            Person personTwo = new Person();

            Console.WriteLine($"\nWrite your name:");
            personTwo.name = Console.ReadLine();
            Console.WriteLine($"\nWrite your age:");
            personTwo.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nWrite your adress:");
            personTwo.adress = Console.ReadLine();
            Console.WriteLine($"\nSecond Person: \nName:{personTwo.name} \nAge:{personTwo.age} \nAdress:{personTwo.adress}");*/

            //Exercise 4 - Class Payment

            /*Console.WriteLine($"\n--- Class Payment");
            Console.WriteLine($"\nForm Payment:");*/

            Payment payment = new Payment();

            int i = 1;

            do
            {
                Console.WriteLine($"\n{i}- Write your name *for:");
                payment.name = Console.ReadLine();
                Console.WriteLine($"\n- Write your payment *for:");
                payment.wage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n*Name: {payment.validName()} \n*Wage: {payment.notNegativeWage()}");
                payment.array[i] = payment.wage;
                i++;

            } while (i < 3);

            Console.WriteLine($"\nTotal Wage: {payment.totalWage()}");

            /*float totalWage()
            {
                if (array[1] < 0)
                {
                    if (array[2] < 0)
                    {
                        return 0;
                    }
                    return array[2];
                }
                else if (array[2] < 0)
                {
                    return array[1];
                }
                else
                {
                    return result = array[1] + array[2];
                }
            }*/


            /*Console.WriteLine(array[1]);
            Console.WriteLine($"\n- Write your payment:");
            payment.wage1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n*Name: {payment.validName()} \n*Wage: {payment.notNegativeWage1()}");*/


            //Exercise 5 - Class Motorcycle

            /*Console.WriteLine($"\n--- Class Motorcycle");

            Console.WriteLine("\nMotorcycle 1");
            Motorcycle motorcycleOne = new Motorcycle();

            motorcycleOne.name = "YS 250 FAZER";
            motorcycleOne.brand = "Yamaha";
            motorcycleOne.power = 137;
            motorcycleOne.weight = 21;

            Console.WriteLine($"\nMotorcycle: {motorcycleOne.name} \nBrand: { motorcycleOne.brand} \nPower: { motorcycleOne.power} \nWeight: {motorcycleOne.weight}");

            Console.WriteLine("\nMotorcycle 2");
            Motorcycle motorcycleTwo = new Motorcycle();

            motorcycleTwo.name = "PCX 150 DLX";
            motorcycleTwo.brand = "PCX";
            motorcycleTwo.power = 137;
            motorcycleTwo.weight = 21;

            Console.WriteLine($"Motorcycle: {motorcycleTwo.name} \nBrand: {motorcycleTwo.brand} \nPower: {motorcycleTwo.power} \nWeight: { motorcycleTwo.weight}");*/


            Console.WriteLine($"\n--- End ****************");
        }
    }
}
