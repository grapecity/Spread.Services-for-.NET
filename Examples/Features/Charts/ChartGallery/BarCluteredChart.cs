﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Spread.Examples.Features.Charts.ChartGallery
{
   public class BarCluteredChart : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Spread.Workbook workbook)
        {
            IWorksheet worksheet = workbook.Worksheets[0];
            GrapeCity.Documents.Spread.Drawing.IShape shape = worksheet.Shapes.AddChart(GrapeCity.Documents.Spread.Drawing.ChartType.BarClustered, 250, 20, 360, 230);
            worksheet.Range["A1:D2"].Value = new object[,] {
                { 100,200,300,400 },
                { 100,200,300,400 },            
            };
            shape.Chart.SeriesCollection.Add(worksheet.Range["A1:D2"], GrapeCity.Documents.Spread.Drawing.RowCol.Columns);
            shape.Chart.ChartTitle.Text = "Bar Clustered Chart";
            shape.Chart.Legend.Position = GrapeCity.Documents.Spread.Drawing.LegendPosition.Left;
        }

        public override bool IsNew
        {
            get
            {
                return true;
            }
        }
    }
}
