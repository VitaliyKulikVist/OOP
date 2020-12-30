using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modifical_Acess
{
    class Point
    {

        int z = 3;//без вказання модифікатору по "Дефолту" встановлюється модифікатор private       !!!!!!!!!!!!!!!!!!!!!!!!!

        public int x=10;//дана зміна буде доступна "Снаружи" цього класу, проте....
        private int y=7;//дана зміна буде НЕ доступна "Снаружи" цього класу                   для особистого використання в середині цього класу!


        private void PrintX()//даний метод НЕ буде доступним "Снаружи" даного класу
        {
            Console.WriteLine("X: "+x);
        }

        public void PrintY()//даний метод буде доступним "Снаружи" даного класу і зможе вивести знаячення Y навіть по при те що воно private
        {
            y = 3;//Можем переназначити оскільки ми знаходимось зараз в цьому ж класі де ця змінна обумовлена як private
            Console.WriteLine("Y: " + y);

        }

        public void PrintPoint()//Цей Метод в середині класу і йому байдуже на те який рівень доступу оскільки він в цьому самому класі
        {
            PrintX();//Може викликати даний метод хочь він і private
            PrintY();//Може викликати даний метод хочь він і public
        }


    }
}
