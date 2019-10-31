﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminUI aui = new AdminUI();
            aui.DisplayUI();
            
        }
    }

    public interface IEmployeeReportBAL
    {
        void GeneratePFReport();
        void GenerateESICReport();
    }

    public interface IManagerReportBAL : IEmployeeReportBAL
    {
        void GenerateResourcePerformanceReport();
        void GenerateProjectSchedule();
    }

    public interface IAdminReportBAL : IManagerReportBAL
    {
        void GenerateProfitReport();
    }

    //public abstract class testAbstractClass
    //{
    //    public int MyProperty { get; set; }
    //    public string DoStuff()
    //    {
    //        return "test";
    //    }
    //}

    //public class testClass : testAbstractClass
    //{ 
    //}

    public class ReportBAL : IAdminReportBAL
    {
        public void GeneratePFReport()
        {/*...............*/}

        public void GenerateESICReport()
        {/*...............*/}

        public void GenerateResourcePerformanceReport()
        {/*...............*/}

        public void GenerateProjectSchedule()
        {/*...............*/}

        public void GenerateProfitReport()
        {/*...............*/}
    }

    public class EmployeeUI
    {
        public void DisplayUI()
        {
            IEmployeeReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
        }
    }

    public class ManagerUI
    {
        public void DisplayUI()
        {
            IManagerReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
            objBal.GenerateResourcePerformanceReport();
            objBal.GenerateProjectSchedule();
        }
    }

    public class AdminUI
    {
        public void DisplayUI()
        {
            IAdminReportBAL objBal = new ReportBAL();
            objBal.GenerateESICReport();
            objBal.GeneratePFReport();
            objBal.GenerateResourcePerformanceReport();
            objBal.GenerateProjectSchedule();
            objBal.GenerateProfitReport();
        }
    }
    
    


}
