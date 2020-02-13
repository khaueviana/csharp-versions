namespace KV.Csharp7
{
    public static class InferredTupleElementNames
    {
        public static void Execute()
        {
            // :(
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count: count, label: label);

            // :)
            var pair2 = (count, label); // element names are "count" and "label"
        }
    }
}
