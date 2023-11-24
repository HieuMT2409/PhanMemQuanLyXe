using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using ThueXeOTo.Database;

namespace ThueXeOTo
{
    internal static class Program
    { 
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}