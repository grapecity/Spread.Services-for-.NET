﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Spread.Examples.Features.Charts.ChartGallery
{
   public class Pie_DoughnutChart :ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Spread.Workbook workbook)
        {
            IWorksheet worksheet = workbook.Worksheets[0];
            GrapeCity.Documents.Spread.Drawing.IShape shape = worksheet.Shapes.AddChart(GrapeCity.Documents.Spread.Drawing.ChartType.Doughnut, 250, 20, 360, 230);
            worksheet.Range["A1:B6"].Value = new object[,] {
                {"S1" , "S2"},
                {10 , 25 },
                {51 , 36 },
                {52 , 85 },
                {22 , 65 },
                {23 , 69 },
            };
            shape.Chart.SeriesCollection.Add(worksheet.Range["A1:B6"], GrapeCity.Documents.Spread.Drawing.RowCol.Columns);
            shape.Chart.ChartTitle.Text = "Area Chart";
            shape.Chart.ChartGroups[0].DoughnutHoleSize = 50;
            shape.Chart.SeriesCollection[0].HasDataLabels = true;
            shape.Chart.SeriesCollection[1].HasDataLabels = true;
            shape.Chart.SeriesCollection[1].Explosion = 2;
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
