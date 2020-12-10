﻿using BoozewasherApp.Enums;
using BoozewasherApp.IRepositories;
using BoozewasherApp.Models.Dtos;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.SummaryForms
{
    public partial class SummaryChart : Form
    {
        private ITransactionRepository TransactionRepository { get; set; }
        private List<SummaryDto> SummaryList { get; set; }
        public SummaryChart(ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            TransactionRepository = transactionRepository;
        }

        private void radSelectDate_Click(object sender, EventArgs e)
        {
            if (radSelectDate.Checked)
            {
                grpboxDate.Enabled = true;
                grpboxDateRange.Enabled = false;
            }
            else if (radSelectDateRange.Checked)
            {
                grpboxDate.Enabled = false;
                grpboxDateRange.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadData();
            DataComputations();

            if (SummaryList.Any())
            {
                DrawGraph();
            }
            else
            {
                MessageBox.Show("No transaction/s at selected date/s");
            }
        }

        private void LoadData()
        {
            SummaryDateAndDateRangeDto dateAndDateRangeDto = new SummaryDateAndDateRangeDto();

            if (radSelectDate.Checked)
            {
                dateAndDateRangeDto.DateTime = datePickerSelectDate.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDate(dateAndDateRangeDto)
                                                      .Select(a => new SummaryDto
                                                      {
                                                          Id = a.Id,
                                                          DateTime = a.DateTime,
                                                          PlateNumber = a.PlateNumber,
                                                          ServiceType = a.Service.Type,
                                                          Expense = a.Service.Expense.Value,
                                                          VehicleType = a.Vehicle.Type,
                                                          Brand = a.Vehicle.Brand,
                                                          Model = a.Vehicle.Model,
                                                          Cost = a.Cost
                                                      }).ToList();
            }
            else
            {
                dateAndDateRangeDto.DateTimeFrom = datePickerDateFromRange.Value.Date;
                dateAndDateRangeDto.DateTimeTo = datePickerDateToRange.Value.Date;

                SummaryList = TransactionRepository.GetTransactionsByDateRange(dateAndDateRangeDto)
                                                      .Select(a => new SummaryDto
                                                      {
                                                          Id = a.Id,
                                                          DateTime = a.DateTime,
                                                          PlateNumber = a.PlateNumber,
                                                          ServiceType = a.Service.Type,
                                                          Expense = a.Service.Expense.Value,
                                                          VehicleType = a.Vehicle.Type,
                                                          Brand = a.Vehicle.Brand,
                                                          Model = a.Vehicle.Model,
                                                          Cost = a.Cost
                                                      }).ToList();
            }

        }

        private void DataComputations()
        {

            #region Summary Computations
            //COUNT COMPUTATIONS
            var carwashCount = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Count();
            var detailingCount = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Count();
            var paintjobCount = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Count();
            var backtozeroCount = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Count();
            var overallTotalCount = carwashCount + detailingCount + paintjobCount + backtozeroCount;

            //COST COMPUTATIONS
            var carwashTotalCost = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Sum(a => a.Cost);
            var detailingTotalCost = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Sum(a => a.Cost);
            var paintjobTotalCost = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Sum(a => a.Cost);
            var backtozeroTotalCost = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Sum(a => a.Cost);
            var overallTotalCost = carwashTotalCost + detailingTotalCost + paintjobTotalCost + backtozeroTotalCost;

            //EXPENSE COMPUTATIONS
            var carwashTotalExpense = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Carwash).Sum(a => a.Expense);
            var detailingTotalExpense = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.Detailing).Sum(a => a.Expense);
            var paintjobTotalExpense = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.PaintJob).Sum(a => a.Expense);
            var backtozeroTotalExpense = SummaryList.Where(a => a.ServiceType == ServiceTypeConstants.BackToZero).Sum(a => a.Expense);
            var overallTotalExpense = carwashTotalExpense + detailingTotalExpense + paintjobTotalExpense + backtozeroTotalExpense;

            //PROFIT COMPUTATIONS
            var grossProfit = overallTotalCost - overallTotalExpense;
            var netProfit = grossProfit - (grossProfit * TaxConstants.BusinessTax);
            #endregion

            SummaryList.ForEach(a => a.CarwashCount = carwashCount);
            SummaryList.ForEach(a => a.DetailingCount = detailingCount);
            SummaryList.ForEach(a => a.PaintjobCount = paintjobCount);
            SummaryList.ForEach(a => a.BackToZeroCount = backtozeroCount);
            SummaryList.ForEach(a => a.OverallTotalCount = overallTotalCount);

            SummaryList.ForEach(a => a.CarwashTotalCost = carwashTotalCost);
            SummaryList.ForEach(a => a.DetailingTotalCost = detailingTotalCost);
            SummaryList.ForEach(a => a.PaintjobTotalCost = paintjobTotalCost);
            SummaryList.ForEach(a => a.BackToZeroTotalCost = backtozeroTotalCost);
            SummaryList.ForEach(a => a.OverallTotalCost = overallTotalCost);

            SummaryList.ForEach(a => a.CarwashTotalExpense = carwashTotalExpense);
            SummaryList.ForEach(a => a.DetailingTotalExpense = detailingTotalExpense);
            SummaryList.ForEach(a => a.PaintjobTotalExpense = paintjobTotalExpense);
            SummaryList.ForEach(a => a.BackToZeroTotalExpense = backtozeroTotalExpense);
            SummaryList.ForEach(a => a.OverallTotalExpense = overallTotalExpense);


            SummaryList.ForEach(a => a.GrossProfit = grossProfit);
            SummaryList.ForEach(a => a.NetProfit = netProfit);
        }

        private void DrawGraph()
        {
            if (radSelectDate.Checked)
            {
                //SummaryList = SummaryList.Select(e => e.DateTime).Distinct().ToList();
                var plt = new ScottPlot.Plot(600, 400);

                // generate random data to plot
                string[] groupNames = SummaryList.Select(a => a.DateTime.ToString("HH:mm")).ToArray();
                string[] seriesNames = { ServiceTypeConstants.Carwash, ServiceTypeConstants.BackToZero, ServiceTypeConstants.Detailing, ServiceTypeConstants.PaintJob };
                int groupCount = groupNames.Length;

                double[] ys1 = SummaryList.Select(a => decimal.ToDouble(a.CarwashTotalCost)).ToArray();
                double[] ys2 = SummaryList.Select(a => decimal.ToDouble(a.BackToZeroTotalCost)).ToArray();
                double[] ys3 = SummaryList.Select(a => decimal.ToDouble(a.DetailingTotalCost)).ToArray();
                double[] ys4 = SummaryList.Select(a => decimal.ToDouble(a.PaintjobTotalCost)).ToArray();

                formsPlot1.plt.PlotBarGroups(
                    groupLabels: groupNames,
                    seriesLabels: seriesNames,
                    ys: new double[][] { ys1, ys2, ys3, ys4 });

                // customize the plot to make it look nicer
                formsPlot1.plt.Grid(enableVertical: false, lineStyle: LineStyle.Dot);
                formsPlot1.plt.Legend(location: legendLocation.upperRight);
                formsPlot1.Render();
            }
        }
    }
}
