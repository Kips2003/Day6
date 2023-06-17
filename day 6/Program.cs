using System;
using System.Collections;
using System.Linq;

namespace MyProgram{
    public class MyWorld{
        public static void Main (string[] args){
            List<string> names = new List<string>();
            names.Add("giorgi");
            names.Add("goga");
            names.Add("ana");
            foreach(string name in names){
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine();

            List <int> numbers = new List <int>();
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(5);

            List <int> numbres1 = new List<int>();
            foreach(int number in numbers){
                numbres1.Add(number);
            }
            numbres1.Sort();
            System.Console.WriteLine("first list:");
            foreach(int number in numbers){
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine("Second list:");
            foreach(int number in numbres1){
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();

            List<int> ListNumbers = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> ListNumbers1 = new List<int>() { 6, 7, 8, 9, 10 };
            ListNumbers.AddRange(ListNumbers1);

            List <int> ListNumberXListNumbers1 = ListNumbers.Distinct().ToList();

            foreach(int number in ListNumberXListNumbers1){
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();



            Queue <int> numbres2 = new Queue<int>();
            numbres2.Enqueue(5);
            numbres2.Enqueue(1);
            numbres2.Enqueue(2);
            numbres2.Enqueue(4);
            numbres2.Enqueue(8);
            numbres2.Dequeue();
            foreach(int number in numbres2){
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();


            HashSet <int> numbers3 = new HashSet<int>();
            HashSet <int> numbers4 = new HashSet<int>();

            numbers3.Add(1);
            numbers3.Add(2);
            numbers3.Add(3);
            numbers3.Add(4);
            numbers3.Add(5);
            numbers3.Add(6);
            numbers4.Add(3);
            numbers4.Add(7);
            numbers4.Add(5);
            numbers4.Add(4);
            numbers4.Add(5);
            numbers4.Add(8);
            numbers4.Add(2);

            HashSet <int> numbers5 = new HashSet<int>();
            foreach(int number in numbers3){
                numbers5.Add(number);
            }
            foreach(int number in numbers4){
                numbers5.Add(number);
            }
            foreach(int number in numbers5){
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine();

            Dictionary<int, string> cars = new Dictionary<int, string>();

            cars.Add(1,"nissan");
            cars.Add(2, "mazda");
            cars.Add(3,"subaru");

            foreach()

        }
    }
}