using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Get_Set_Value
{
    class Point
    {
     
     /// <summary>
     /// //////////////////////без використання властивостей це буде виглядати так/////////////////////////////////////////////////////////////////////////
     /// </summary>
        private int x;
        public void SetX(int x)//Set            присвоїти
        {
            //Логіка обмежень
            if(x<1)//якщо будемо передавати число менше 1 тоді буде присвоюватись всерівно 1
            {
                this.x = 1;
                return;
            }
            if(x>5)//якщо будемо передавати число більше 5 тоді буде присвоюватись всерівно 5
            {
                this.x = 5;
                return;
            }
            this.x = x;
        }
        public int GetX()//Get                  отримати
        {
            return x;
        }
        /// <summary>
        /// //////////////////////З використання властивостей це буде виглядати так/////////////////////////////////////////////////////////////////////////
        /// </summary>
        //propfull  +2click TAB             генеруємо властивості за допомогою ВС

        private int y;
        public int Y_set_get//////////////////////////////Властивість///////////////////////////////////////
        {
            get//Аксесор ГЕТ
            {
                return y;
            }
            set//Аксесор СЕТ
            {
                if (value < 1)
                {
                    this.y = 1;
                    return;
                }
                if (value > 5)
                {
                    this.y = 5;
                    return;
                }
                y = value;//змінна value це міститиме в собі всі вхідні з мейна значення і присвоювати їх змінній у тип данних буде такий самий як в методі Y_set_get
            }
        }
        /// <summary>//////////////////З використання АВТОМАТИЧНИХвластивостей це буде виглядати так/
        /// ///////////////////////////////////////////////////AutomaticProperty//////////////////////////////////////////////////////////
        /// </summary>
        /// prop + 2 click TAB
        public int Z_get_set
        {
            get;
            set;
        }
















        public void Print()
        {
            Console.WriteLine($"Znachenia X= {x}\nZnachenia Y={Y_set_get}\nZnachenia Z={Z_get_set} ");
        }



    }
}
