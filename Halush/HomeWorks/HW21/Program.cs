using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create 2 generic interfaces one with covariance and another with contravariance for generic type. 
Implement concrete classes that implement those interfaces. Create example of usage for covariance and contravariance in generic interfaces. 
Remember class implementations of generic interfaces do not support variance
*/

namespace HW21
{
    //Covariant interface
    public interface ICovariance<out T>
    {
        T CovarianceMethod<T>();
    }
    //Contravariant interface
    public interface IContravariance<in T>
    { }

    class CovariantClass<T> : ICovariance<T>
    {
        public T CovarianceMethod<T>()
        {
            throw new Exception("This is covariance method.");
        }
    }

    class ContravariantClass<T> : IContravariance<T>
    { }

    public class Program
    {
        public static void Main()
        {
            //Covariance
            ICovariance<string> covariantItem = new CovariantClass<string>();
            ICovariance<object> covariance = covariantItem;
            //Contravariance
            IContravariance<object> contravariantObject = new ContravariantClass<object>();
            IContravariance<string> contravariantString = contravariantObject;
        }
    }
}
