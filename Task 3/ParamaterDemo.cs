namespace Task_3;


    class ParameterDemo
    {
        // Method 1: Using ref
        public void Increase(ref int number)
        {
            number = number + 10;
        }

        // Method 2: Using out
        public void GetFullName(out string fullname)
        {
            fullname = "Your Full Name";
        }

        // Method 3: Using params
        public int SumAll(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

}