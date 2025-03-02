namespace prjPastaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PastaFactory factory = new PastaFactory();
            Console.Write("Please enter your pasta type: ");
            String selectedPasta = Console.ReadLine();
            IPasta pasta = factory.getPasta(selectedPasta);
            Console.WriteLine("{0} noodles with {1} and {2}",
                pasta.getNoodle(), pasta.getMeat(),
                pasta.getSauce());
        }
    }
}
