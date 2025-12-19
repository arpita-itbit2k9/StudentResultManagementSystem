using StudentResultManagementSystem.BusinessLogic.Services;
using StudentResultManagementSystem.Contracts.Interfaces;
using StudentResultManagementSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IResultRepository repository = new CsvResultRepository();
            IResultService service = new ResultService(repository);

            
            Application.Run(new StudentResultManagementForm(service));
        }
    }
}
