namespace constructor2
{
    public class Counter
    {
        private Counter()
        {

        }
        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
}