namespace ConsoleApp2
{
    internal class Sum
    {
        Nlog ng = new Nlog();
        public void doSum(int a, int b)
        {
            if(a == 0 || b == 0)
            {
                ng.Logerror("a and b values are zero");
            }
            else
            {
                int c = a + b;
                ng.Logdebug("Debug Successfully!");
                ng.Loginfo("Addition of : " + a + " + " + b + " = " + c);
            }
        }
    }
}
