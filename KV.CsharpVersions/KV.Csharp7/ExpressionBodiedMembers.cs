using System;

namespace KV.Csharp7
{
    public static class ExpressionBodiedMembers
    {
        public static void Execute()
        {

        }

        public class ExpressionMembersExample
        {
            public ExpressionMembersExample(string label, string label2) => (Label,  Label2) = (label, label2);

            // Expression-bodied finalizer
            ~ExpressionMembersExample() => Console.Error.WriteLine("Finalized!");

            private string label;
            private string label2;

            // Expression-bodied get / set accessors.
            public string Label
            {
                get => label;
                set => label = value ?? "Default label";
            }

            public string Label2
            {
                get => label2;
                set => label2 = value ?? "Default label";
            }
        }

        public class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age) => (Name, Age) = (name, age);
        }
    }
}
