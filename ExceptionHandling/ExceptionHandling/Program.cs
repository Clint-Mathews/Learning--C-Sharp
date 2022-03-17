using ExceptionHandling;

class Program
{
    static void Main(string[] args)
    {
        Test("Test");
    }
    static void Test(string fileName)
    {
        try
        {
            if(String.IsNullOrEmpty(fileName)) throw new CustomException("File name should not be null or empty");
            if (File.Exists(fileName))
            {
                File.OpenRead(fileName);
            } else
            {
                var data = new CustomException();
                data.Data.Add("Key", "Hello");
                throw data;
            }
        }
        catch (CustomException e) when (e.Data.Contains("Key"))
        {
            Console.WriteLine(e);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            Console.WriteLine("Excecution Done");
        }
    }
}