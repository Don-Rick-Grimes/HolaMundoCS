using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class OperacionFracciones
    {
        private int num1,num2,num3,num4,resultado1,resultado2;
        private int a, b, mcd;

        public OperacionFracciones(int _num1,int _num2,int _num3, int _num4)
        {
            num1 = _num1;
            num2 = _num2;
            num3 = _num3;
            num4 = _num4;
        } 
        public void setNum1(int _num1)
        {
            num1 = _num1;
        }
        public int getNum1()
        {
            return num1;
        }
        public void setNum2(int _num2)
        {
            num2 = _num2;
        }
        public int getNum2()
        {
            return num2;
        }
        public void setNum3(int _num3)
        {
            num3 = _num3;
        }
        public int getNum3()
        {
            return num3;
        }
        public void setNum4(int _num4)
        {
            num4 = _num4;
        }
        public int getNum4()
        {
            return num4;
        }
        public void setResultado1(int _resultado1)
        {
            resultado1 = _resultado1;
        }

        public int getResultado1()
        {
            return resultado1;
        }
        public void setResultado2(int _resultado2)
        {
            resultado2 = _resultado2;
        }

        public int getResultado2()
        {
            return resultado2;
        }
        public void sumar()
        {
            setResultado1(num4*num1+num3*num2);
            setResultado2(num2 * num4);
            simplificar();
        }
        public void restar()
        {
            setResultado1(num4 * num1 - num3*num2);
            setResultado2(num2 * num4);
            simplificar();
        }
        public void dividir()
        {
            setResultado1(num1 * num4);
            setResultado2(num2 * num3);
            simplificar();
        }
        public void multiplicar()
        {
            setResultado1(num1 * num3);
            setResultado2(num2 * num4);
            simplificar();
        }

        public void simplificar()
        {
            if(resultado1 !=0 && resultado2 != 0) 
            {
                a = Math.Max(resultado1, resultado2);
                b = Math.Min(resultado1, resultado2);
                do //ciclo para hallar el mcd
                {
                    mcd = b;  // Guardamos el divisor en el resultado
                    b = a % b;      //Guardamos el resto en el divisor
                    a = mcd;  //El divisor para al dividendo
                }
                while
                (b != 0);
                setResultado1(resultado1 / mcd);
                setResultado2(resultado2 / mcd);
                if (resultado2 < 0) //simplificar signos
                {
                    setResultado1(resultado1 * -1);
                    setResultado2(resultado2 * -1);
                }
            }
        }
    }
}
