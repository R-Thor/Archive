using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.CodeDom;

//namespace DynamicObjectTest
//{
//    // The class derived from DynamicObject.
//    public class DynamicDictionary : DynamicObject
//    {
//        // The inner dictionary.
//        Dictionary<string, object> dictionary
//            = new Dictionary<string, object>();

//        // This property returns the number of elements
//        // in the inner dictionary.
//        public int Count
//        {
//            get
//            {
//                return dictionary.Count;
//            }
//        }

//        // If you try to get a value of a property 
//        // not defined in the class, this method is called.
//        public override bool TryGetMember(
//            GetMemberBinder binder, out object result)
//        {
//            // Converting the property name to lowercase
//            // so that property names become case-insensitive.
//            string name = binder.Name.ToLower();

//            // If the property name is found in a dictionary,
//            // set the result parameter to the property value and return true.
//            // Otherwise, return false.
//            return dictionary.TryGetValue(name, out result);
//        }

//        // If you try to set a value of a property that is
//        // not defined in the class, this method is called.
//        public override bool TrySetMember(
//            SetMemberBinder binder, object value)
//        {
//            // Converting the property name to lowercase
//            // so that property names become case-insensitive.
//            dictionary[binder.Name.ToLower()] = value;

//            // You can always add a value to a dictionary,
//            // so this method always returns true.
//            return true;
//        }
//        public override bool TryInvokeMember(InvokeMemberBinder binder,
//                                             object[] args,
//                                             out object result)
//        {
//            StringSearchOption StringSearchOption = StringSearchOption.StartsWith;
//            bool trimSpaces = true;

//            try
//            {
//                if (args.Length > 0) { StringSearchOption = (StringSearchOption)args[0]; }
//            }
//            catch
//            {
//                throw new ArgumentException("StringSearchOption argument must be a StringSearchOption enum value.");
//            }

//            try
//            {
//                if (args.Length > 1) { trimSpaces = (bool)args[1]; }
//            }
//            catch
//            {
//                throw new ArgumentException("trimSpaces argument must be a Boolean value.");
//            }

//            result = GetPropertyValue(binder.Name, StringSearchOption, trimSpaces);

//            return result == null ? false : true;
//        }

//    }
class Program
{
    static void Main(string[] args)
    {
        CodeEntryPointMethod start = new CodeEntryPointMethod();
        CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine", new CodePrimitiveExpression("Hello World!"));
        start.Statements.Add(cs1);
        

    }
}
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating a dynamic dictionary.
//            dynamic person = new DynamicDictionary();
//            person.Age = 5;
//            // Adding new dynamic properties. 
//            // The TrySetMember method is called.
//            person.FirstName = "Ellen";
//            person.LastName = "Adams";
//            person.Kill();
//            // Getting values of the dynamic properties.
//            // The TryGetMember method is called.
//            // Note that property names are case-insensitive.
//            Console.WriteLine(person.firstname + " " + person.lastname);

//            // Getting the value of the Count property.
//            // The TryGetMember is not called, 
//            // because the property is defined in the class.
//            Console.WriteLine(
//                "Number of dynamic properties:" + person.Count);

//            // The following statement throws an exception at run time.
//            // There is no "address" property,
//            // so the TryGetMember method returns false and this causes a
//            // RuntimeBinderException.
//            // Console.WriteLine(person.address);
//        }
//    }

//    // This example has the following output:
//    // Ellen Adams
//    // Number of dynamic properties: 2

//}
//using Microsoft.CSharp;
//using System.CodeDom.Compiler;
//using System.Reflection;
////using System.Text;

//namespace System
//{
//    public static class CompileCSCAtRuntime
//    {
//        public static void HelloWorld()
//        {
//            string code = @"
//                using System;
//
//                namespace First
//                {
//                    public class Program
//                    {
//                        public static void Main()
//                        {
//                        " +
//                            "Console.WriteLine(\"Hello, world!\");"
//                          + @"
//                        }
//                    }
//                }
//            ";

//            CSharpCodeProvider provider = new CSharpCodeProvider();
//            CompilerParameters parameters = new CompilerParameters();

//            // Reference to System.Drawing library
//            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
//            // True - memory generation, false - external file generation
//            parameters.GenerateInMemory = true;
//            // True - exe file generation, false - dll file generation
//            parameters.GenerateExecutable = true;

//            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);

//            if (results.Errors.HasErrors)
//            {
//                StringBuilder sb = new StringBuilder();

//                foreach (CompilerError error in results.Errors)
//                {
//                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
//                }

//                throw new InvalidOperationException(sb.ToString());
//            }

//            Assembly assembly = results.CompiledAssembly;
//            Type program = assembly.GetType("First.Program");
//            MethodInfo main = program.GetMethod("Main");

//            main.Invoke(null, null);
//        }

//        public static void TestMeothds()
//        {
//            MethodInfo function = CreateFunction("x + 2 * y");
//            var betterFunction = (Func<double, double, double>)Delegate.CreateDelegate(typeof(Func<double, double, double>), function);
//            Func<double, double, double> lambda = (x, y) => x + 2 * y;

//            DateTime start;
//            DateTime stop;
//            double result;
//            int repetitions = 5000000;

//            start = DateTime.Now;
//            for (int i = 0; i < repetitions; i++)
//            {
//                result = OriginalFunction(2, 3);
//            }
//            stop = DateTime.Now;
//            Console.WriteLine("Original - time: {0} ms", (stop - start).TotalMilliseconds);

//            start = DateTime.Now;
//            for (int i = 0; i < repetitions; i++)
//            {
//                result = (double)function.Invoke(null, new object[] { 2, 3 });
//            }
//            stop = DateTime.Now;
//            Console.WriteLine("Reflection - time: {0} ms", (stop - start).TotalMilliseconds);

//            start = DateTime.Now;
//            for (int i = 0; i < repetitions; i++)
//            {
//                result = betterFunction(2, 3);
//            }
//            stop = DateTime.Now;
//            Console.WriteLine("Delegate - time: {0} ms", (stop - start).TotalMilliseconds);

//            start = DateTime.Now;
//            for (int i = 0; i < repetitions; i++)
//            {
//                result = lambda(2, 3);
//            }
//            stop = DateTime.Now;
//            Console.WriteLine("Lambda - time: {0} ms", (stop - start).TotalMilliseconds);
//        }

//        public static double OriginalFunction(double x, double y)
//        {
//            return x + 2 * y;
//        }

//        public static MethodInfo CreateFunction(string function)
//        {
//            string code = @"
//                using System;
//            
//                namespace UserFunctions
//                {                
//                    public class BinaryFunction
//                    {                
//                        public static double Function(double x, double y)
//                        {
//                            return func_xy;
//                        }
//                    }
//                }
//            ";

//            string finalCode = code.Replace("func_xy", function);

//            CSharpCodeProvider provider = new CSharpCodeProvider();
//            CompilerResults results = provider.CompileAssemblyFromSource(new CompilerParameters(), finalCode);

//            Type binaryFunction = results.CompiledAssembly.GetType("UserFunctions.BinaryFunction");
//            return binaryFunction.GetMethod("Function");
//        }
//    }
//}
