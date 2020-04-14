using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using AutoMapper;
using InventoryAndBillingSystem.UI;

namespace InventoryAndBillingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //dependency injection with autofac
            var container = BuildContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                
            }
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            return builder.Build();
        }
    }
}
