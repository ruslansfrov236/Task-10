using Task10.customer;
using Task10.IModel;
using Task10.IModel;
using Task10.Model;

namespace Task10;

class Program
{
    private readonly IEmployeeModel<Employee> _employeeModel;
    public static bool isboll = true;
    public Program(IEmployeeModel<Employee> employeeModel)
    {
        _employeeModel = employeeModel;
    }
    public void GetALL()
    {
        _employeeModel.GetEmployees();
    }
    public void GetById()
    {
        byte isCount = 3;
        bool isNumber = true;
        while(isNumber)
        {
            Console.Write("Enter the employee ID to get information:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                id = id;
                _employeeModel.GetEmployeeById(id);
            }
            else
            {
                Console.WriteLine("Enter the employee ID number");
                isCount--;
                if (isCount == 0){
                    isNumber=false;
                }
            }
        }
    
     
    }

    public void Dialog()
    {
        Console.WriteLine("Do you want to continue or not? Yes, go ahead, No, don't go ahead");
        string dialog = Console.ReadLine();
        switch (dialog)
        {
            case "Yes":
                isboll = true;
                break;
            case "No":
                isboll = false;
                break;
            default:
                Console.WriteLine("You can choose whether to continue by entering \"Yes\" and \"No\".");
                break;
        }

    }
 
    public void createEmployee()
    {
        _employeeModel.CreateEmployee();
    }
    public static async Task Main(string[] args)
    {
        IEmployeeModel<Employee> em = new EmployeeModel();
        Program program = new Program(em);
       
        string yes, no;
        while (isboll)
        {

            Console.WriteLine("\t\t\t\t\t\t\tMenu \n" +
                "1.Create Employee \n" +
                "2.Get all Employee\n" +
                "3.Get information based on ID\n" +
                "4.Exit.\n");
            Console.Write("choose:");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Loading ...");
            await Task.Delay(1000);

            switch (choose)
            {
                case 1:
                
                    program.createEmployee();
                    program.Dialog();

                    break;
                case 2:
                 
                    program.GetALL();
                    program.Dialog();
                    break;
                case 3:
                   
                    program.GetById();
                    program.Dialog();
                    break;
                case 4:
                    isboll = false ;
                    break;

                default:
                    Console.WriteLine("not found");

                    break;
            }




        }

    }
}
