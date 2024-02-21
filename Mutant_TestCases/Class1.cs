namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            // Add a mutant to check if the sum of 3 angles equal to 180
            if (((firstAngle + secondAngle + thirdAngle) == 180))
            {
                result = "The triangle is valid.";
            }
            // Add a mutant to check if the sum of 3 angles not equal to 180
            //if (((firstAngle +secondAngle + thirdAngle) != 180))
            //    {
            //    result = "The triangle is valid.";
            //}
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
       
    }
}