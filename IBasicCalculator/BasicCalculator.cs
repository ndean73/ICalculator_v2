using System;
using IBasicCalculator;
using MathOperations;

namespace IBasicCalculator
{
    public interface IBasicCalculator {

        public int Add(int a,int b);
        public int Div(int a,int b);
        public int Sub(int a,int b);
        public double Multi(double a,double b);
        public double Sqr(double a,double b);
        public int SqrRoot(int a);
        public double Cube(double a);
    
    }

    public class BasicCalculator : Iadding,Isubtraction,Idivision,Imultiplication,ICube,Isquare,IsquareRoot
    {
        private  double a = 0;
        
        Adding add = new Adding();
        Subtraction sub = new Subtraction();
        Multiplication multi = new Multiplication();
        Division div = new Division();
        Cube cub = new Cube();
        Square sqr = new Square();
        SquareRoot sqrroot = new SquareRoot();

        public int result;

        public int Add(int a,int b)
        {
           result=add.Add(a,b);
           return result;
        }

        public double Cube(double a)
        {
            return cub.cube(a);
           // return result;
        }

        public int Div(int a,int b)
        {
           result= div.Div(a, b);
           return result;
        }

        public double Multi(double a,double b)
        {
            return multi.Multi(a, b);
           // return result;
        }

        public double Sqr(double a,double b)
        {
            return sqr.Sqr(a,b);
        }

        public int SqrRoot(int a)
        {
            result = sqrroot.SqrRoot(a);
            return result;
        }

        public int Sub(int a,int b)
        {
           result = sub.Sub(a,b);
           return result;

        }

        double ICube.cube(double a)
        {
            throw new NotImplementedException();
        }
    }
}
