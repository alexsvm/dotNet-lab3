using System;
using System.Reflection;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace dotNet_lab3
{
    class CSCompiler
    {
     public static Delegate GetDelegate(Type DelegateType, string Expression)
        {
            // Получаем образ компилируемого метода для информации о параметрах(число, типы, имена)
            MethodInfo InvokeInfo = DelegateType.GetMethod("Invoke");
            if (InvokeInfo == null)
                throw new NotSupportedException(string.Concat("Type \"", DelegateType.ToString(), "\" must be is delegate"));
            else
            {
                // строка коспиляции С# кода
                StringBuilder compileString = new StringBuilder(128);
                // Обявляем класс со статическим методом "Invoke"
                compileString.Append("using System;");
                compileString.Append("class _My{public static ").Append(InvokeInfo.ReturnType == typeof(void) ? "void" : InvokeInfo.ReturnType.FullName).Append(" ").Append("Invoke(");
                // Получаем информацию обо всех параметрах функции
                // И заносим их в строку-компиляции
                foreach (var Param in InvokeInfo.GetParameters())
                {
                    // Если параметр имет тип ref или out
                    if (Param.ParameterType.IsByRef) compileString.Append("ref ").Append(Param.ParameterType.FullName.Replace('+', '.').TrimEnd('&')).Append(" ").Append(Param.Name).Append(",");
                    // Иначе
                    else compileString.Append(Param.ParameterType.FullName.Replace('+', '.')).Append(" ").Append(Param.Name).Append(",");
                }
                compileString[compileString.Length - 1] = ')';
                // Добавляем вместо тела функции наше выражение
                compileString.Append("{").Append(Expression).Append(";}}");

                //Объявляем провайдер кода С#
                CSharpCodeProvider prov = new CSharpCodeProvider();
                // В параметрах компидяции - подключаем все сборки "родительского" приложения(чтоб не мучиться)

                CompilerParameters cp = new CompilerParameters(Array.ConvertAll<Assembly, string>(AppDomain.CurrentDomain.GetAssemblies(), x => x.Location));
                // Помечаем сборку, как временную
                cp.GenerateInMemory = true;
                // Обрабатываем CSC компилятором
                CompilerResults results = prov.CompileAssemblyFromSource(cp, compileString.ToString());
                // Если есть ошибки - собираем их и выдаем исключение
                if (results.Errors.Count > 0)
                {
                    StringBuilder errorString = new StringBuilder("Error of C# Compilation CS");
                    errorString.AppendLine("Number of Errors: " + results.Errors.Count);
                    foreach (CompilerError err in results.Errors)
                        errorString.AppendLine(err.ErrorText);
                    throw new NotSupportedException(errorString.ToString());
                }
                // Если ошибок нет, то с помощью отражения достаем из временной сборки нашу функцию
                else return Delegate.CreateDelegate(DelegateType, results.CompiledAssembly.GetType("_My").GetMethod("Invoke"));
            }
        }
    }
}
